using eFoodDelivery_API.DbContexts;
using eFoodDelivery_API.DTOs;
using eFoodDelivery_API.Entities;
using eFoodDelivery_API.Models;
using eFoodDelivery_API.Services.Implementations;
using eFoodDelivery_API.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Net;

namespace eFoodDelivery_API.Controllers
{
    // [Route("api/[controller]")] // instead a dynamic route, if I change the controller name, the route does not get updated
    [Route("api/Logger")]
    [ApiController]
    public class LoggerController : ControllerBase
    {
        // dependencies to inject
        private readonly ApplicationDbContext _dbContext; // read property for our context
        protected ApiResponse _apiResponse; // property for our API response

        // dependency injection
        public LoggerController(ApplicationDbContext dbContext) // dependency injection
        {
            _dbContext = dbContext;
            _apiResponse = new ApiResponse();
        }



        /// <summary>
        /// 1º endpoint to get all logs from db
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetLogs()
        {
            _apiResponse.Result = _dbContext.LoggerDbSet;
            _apiResponse.StatusCode = HttpStatusCode.OK;
            return Ok(_apiResponse);
        }



        /// <summary>
        /// 2º endpoint to create a new log
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> CreateLog(string log) // I'm not using [FromBody] and I'm using [FromForm] bacause we also need to upload an image when we creating a product
        {
            try
            {
                Logger newLog = new Logger();
                
                if (!log.IsNullOrEmpty())
                {
                    newLog.Log = log;

                    _dbContext.LoggerDbSet.Add(newLog);
                    _dbContext.SaveChanges();

                    _apiResponse.Result = newLog;
                    _apiResponse.StatusCode = HttpStatusCode.Created;
                    return Ok(_apiResponse);
                }
                else
                {
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    _apiResponse.Success = false;
                    return BadRequest();
                }
                
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
