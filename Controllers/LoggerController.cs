using eFoodDelivery_API.DbContexts;
using eFoodDelivery_API.DTOs;
using eFoodDelivery_API.Entities;
using eFoodDelivery_API.Models;
using eFoodDelivery_API.Services.Implementations;
using eFoodDelivery_API.Services.Interfaces;
using eFoodDelivery_API.Tools;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Net;
using System.Text.Json;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

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
        [Authorize(Roles = Constants.ROLE_ADMIN)]
        public async Task<ActionResult<ApiResponse>> GetLogs(
            string logSearch, string logLevel,  // search and level are for search functionality
            int pageNumber = 1, int pageSize = 20     // this is for pagination functionality, we'll start in page numer 1 and we'll see 20 logs per page    
        )
        {
            try
            {
                IEnumerable<Logger> logsRetrievedFromDb = _dbContext.LoggerDbSet
                    .OrderByDescending(log => log.Id) // specify the way we want to order the resulting objects
                ;

                // the first one we can check if logSearch string is not empty, then we will filter our logs by the log itself
                // if any log have the search string within it, then we will display and assign that to log
                if (!string.IsNullOrEmpty(logSearch))
                {
                    logsRetrievedFromDb = logsRetrievedFromDb.Where(log =>
                        log.Log.ToLower().Contains(logSearch.ToLower())
                    );
                }
                // similarly, if logLevel is not empty, we will filter based on status and converting to lower case
                if (!string.IsNullOrEmpty(logLevel))
                {
                    logsRetrievedFromDb = logsRetrievedFromDb.Where(log => log.Level.ToLower() == logLevel.ToLower());
                }
                // whith that, we added the search functionality to logs

                // first, create a pagination object and populate actual page, page size and records number
                Pagination pagination = new Pagination();
                pagination.ActualPage = pageNumber;
                pagination.PageSize = pageSize;
                pagination.RecordsNumber = logsRetrievedFromDb.Count();

                // note that we have to add the "X-Pagination" special type for the Headers in the response to allow the pagination
                Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(pagination));

                // aply filter for pagination
                // so where we're returning the complete logs, we'll be using .Skip() and .Take() with Enumerable
                _apiResponse.Result = logsRetrievedFromDb
                    .Skip((pageNumber - 1) * pageSize) // so think about pageNumber is 2, how many records we want to skip?
                    .Take(pageSize) //we want to take records base on the pageSize, if our pageSize is 10, we want to take the next 10 records to be displayed
                ;

                _apiResponse.StatusCode = HttpStatusCode.OK;
                return Ok(_apiResponse);
            }
            catch (Exception ex)
            {
                _apiResponse.Success = false;
                _apiResponse.ErrorsList = new List<string>() { ex.ToString() };
            }

            return _apiResponse;
        }



        /// <summary>
        /// 2º endpoint to create a new log
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> CreateLog(string log, string level)
        {
            try
            {
                if (!log.IsNullOrEmpty())
                {
                    Logger newLog = new Logger();
                    newLog.Log = log;
                    newLog.Level = level;

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
