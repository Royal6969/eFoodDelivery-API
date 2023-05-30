using eFoodDelivery_API.DbContexts;
using eFoodDelivery_API.DTOs;
using eFoodDelivery_API.Entities;
using eFoodDelivery_API.Models;
using eFoodDelivery_API.Services.Interfaces;
using eFoodDelivery_API.Tools;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace eFoodDelivery_API.Controllers
{
    // [Route("api/[controller]")] // instead a dynamic route, if I change the controller name, the route does not get updated
    [Route("api/Product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // dependencies to inject
        private readonly ApplicationDbContext _dbContext; // read property for our context
        private readonly IBlobService _blobService; // read property to CreateProduct() and UpdateProduct()
        protected ApiResponse _apiResponse; // property for our API response

        // dependency injection
        public ProductController(ApplicationDbContext dbContext, IBlobService blobService) // dependency injection
        {
            _dbContext = dbContext;
            _blobService = blobService;
            _apiResponse = new ApiResponse();
        }



        /// <summary>
        /// 1º endpoint to get all products from db
        /// </summary>
        /// <returns>Ok with apiResponse complete</returns>
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            // return Ok(_dbContext.ProductsDbSet); // it will go to DB and fetch all products and return back, but I want to get better control for api response

            _apiResponse.Result = _dbContext.ProductsDbSet;
            _apiResponse.StatusCode = HttpStatusCode.OK;
            return Ok(_apiResponse);
        }



        /// <summary>
        /// 2º endpoint to get a product by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>BadResquest, NotFound or Ok with apiResponse</returns>
        [HttpGet("{id:int}", Name = "GetProduct")] // like this method has a parameter, I need to specify what parameter is (name:type) // also specify a Name for the action method in CreateProduct()
        public async Task<IActionResult> GetProduct(int id)
        {
            if (id == 0) // check for BadRequest
            {
                _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                _apiResponse.Success = false;
                return BadRequest(_apiResponse);
            }
            
            Product product = _dbContext.ProductsDbSet.FirstOrDefault(p => p.Id == id);
            
            if(product == null) // check for NotFound
            {
                _apiResponse.StatusCode = HttpStatusCode.NotFound;
                _apiResponse.Success = false;
                return NotFound(_apiResponse);
            }

            _apiResponse.Result = product;
            _apiResponse.StatusCode = HttpStatusCode.OK;
            return Ok(_apiResponse);
        }



        /// <summary>
        /// 3º endpoint to create a new product
        /// </summary>
        /// <param name="productCreateDTO"></param>
        /// <returns>BadRequest or CreateAtRoute with apiResponse</returns>
        [HttpPost]
        [Authorize(Roles = Constants.ROLE_ADMIN)]
        public async Task<ActionResult<ApiResponse>> CreateProduct([FromForm] ProductCreateDTO productCreateDTO) // I'm not using [FromBody] and I'm using [FromForm] bacause we also need to upload an image when we creating a product
        {
            try
            {
                if (ModelState.IsValid) // like we have some required fields, it will validate if all the endpoints are valid
                {
                    if (productCreateDTO.Image == null || productCreateDTO.Image.Length == 0)
                    {
                        _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                        _apiResponse.Success = false;
                        return BadRequest();
                    }

                    // get the imageName = name + .extension
                    string imageName = $"{Guid.NewGuid()}{Path.GetExtension(productCreateDTO.Image.FileName)}";

                    // create the new Product object through its dto
                    Product productToCreate = new Product();
                    productToCreate.Name = productCreateDTO.Name;
                    productToCreate.Description = productCreateDTO.Description;
                    productToCreate.Tag = productCreateDTO.Tag;
                    productToCreate.Category = productCreateDTO.Category;
                    productToCreate.Price = productCreateDTO.Price;
                    productToCreate.Image = await _blobService.UploadBlob(imageName, Constants.SD_STORAGE_CONTAINER, productCreateDTO.Image); // upload the blob and it will return back the URL which we will save in the image
                    
                    // save the object in DB
                    _dbContext.ProductsDbSet.Add(productToCreate);
                    _dbContext.SaveChanges();
                    _apiResponse.Result = productToCreate;
                    _apiResponse.StatusCode = HttpStatusCode.Created;
                    
                    // return go to GetProduct() method to view the new product created
                    return CreatedAtRoute("GetProduct", new { id = productToCreate.Id }, _apiResponse);
                }
                else _apiResponse.Success = false;

            } catch (Exception ex)
            {
                _apiResponse.Success = false;
                _apiResponse.ErrorsList = new List<string>() { ex.ToString() };
            }

            return _apiResponse;
        }



        /// <summary>
        /// 4º endpoint to update a product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="productUpdateDTO"></param>
        /// <returns>BadResquest or Ok with apiResponse</returns>
        [HttpPut("{id:int}")]
        [Authorize(Roles = Constants.ROLE_ADMIN)]
        public async Task<ActionResult<ApiResponse>> UpdateProduct(int id, [FromForm] ProductUpdateDTO productUpdateDTO) // I'm not using [FromBody] and I'm using [FromForm] bacause we also need to upload an image when we creating a product
        {
            try
            {
                if (ModelState.IsValid) // like we have some required fields, it will validate if all the endpoints are valid
                {
                    if (productUpdateDTO == null || id != productUpdateDTO.Id)
                    {
                        _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                        _apiResponse.Success = false;
                        return BadRequest();
                    }
                    
                    // Product productRetrievedFromDb = await _dbContext.ProductsDbSet.FirstOrDefaultAsync(p => p.Id == id);
                    Product productRetrievedFromDb = await _dbContext.ProductsDbSet.FindAsync(id); // FindAsync() search by PK and in this case it works

                    if (productRetrievedFromDb == null) 
                    {
                        _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                        _apiResponse.Success = false;
                        return BadRequest(); 
                    }

                    productRetrievedFromDb.Name = productUpdateDTO.Name;
                    productRetrievedFromDb.Description = productUpdateDTO.Description;
                    productRetrievedFromDb.Tag = productUpdateDTO.Tag;
                    productRetrievedFromDb.Category = productUpdateDTO.Category;
                    productRetrievedFromDb.Price = productUpdateDTO.Price;

                    if (productUpdateDTO.Image != null && productUpdateDTO.Image.Length > 0)
                    {
                        // get the imageName = name + .extension
                        string imageName = $"{Guid.NewGuid()}{Path.GetExtension(productUpdateDTO.Image.FileName)}";

                        // first, we need to delete the old image, and we have to get it with the URL after the second slash
                        // https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/6622221b-7bf8-4204-9fb8-8e96d4e6490c.jpg
                        await _blobService.DeleteBlob(productRetrievedFromDb.Image.Split('/').Last(), Constants.SD_STORAGE_CONTAINER);
                        
                        // second, upload the new product
                        productRetrievedFromDb.Image = await _blobService.UploadBlob(imageName, Constants.SD_STORAGE_CONTAINER, productUpdateDTO.Image); // upload the blob and it will return back the URL which we will save in the image
                    }

                    // update the object in DB
                    _dbContext.ProductsDbSet.Update(productRetrievedFromDb);
                    _dbContext.SaveChanges();
                    _apiResponse.StatusCode = HttpStatusCode.NoContent;

                    return Ok(_apiResponse);
                }
                else _apiResponse.Success = false;

            }
            catch (Exception ex)
            {
                _apiResponse.Success = false;
                _apiResponse.ErrorsList = new List<string>() { ex.ToString() };
            }

            return _apiResponse;
        }



        /// <summary>
        /// 5º endpoint to delete a product by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>BadRequest or Ok with apiResponse</returns>
        [HttpDelete("{id:int}")]
        [Authorize(Roles = Constants.ROLE_ADMIN)]
        public async Task<ActionResult<ApiResponse>> DeleteProduct(int id)
        {
            try
            {
                if (id == 0) 
                {
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    _apiResponse.Success = false;
                    return BadRequest(); 
                }

                // Product productRetrievedFromDb = await _dbContext.ProductsDbSet.FirstOrDefaultAsync(p => p.Id == id);
                Product productRetrievedFromDb = await _dbContext.ProductsDbSet.FindAsync(id); // FindAsync() search by PK and in this case it works

                if (productRetrievedFromDb == null) 
                {
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    _apiResponse.Success = false;
                    return BadRequest(); 
                }

                // first, we need to delete the old image, and we have to get it with the URL after the second slash
                // https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/6622221b-7bf8-4204-9fb8-8e96d4e6490c.jpg
                await _blobService.DeleteBlob(productRetrievedFromDb.Image.Split('/').Last(), Constants.SD_STORAGE_CONTAINER);
                
                // remove the object in DB
                _dbContext.ProductsDbSet.Remove(productRetrievedFromDb);
                _dbContext.SaveChanges();
                _apiResponse.StatusCode = HttpStatusCode.NoContent;

                return Ok(_apiResponse);

            }
            catch (Exception ex)
            {
                _apiResponse.Success = false;
                _apiResponse.ErrorsList = new List<string>() { ex.ToString() };
            }

            return _apiResponse;
        }
    }
}
