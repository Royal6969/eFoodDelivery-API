using System.Net;

namespace eFoodDelivery_API.Models
{
    public class ApiResponse
    {
        public HttpStatusCode StatusCode { get; set; } // eg: 404
        public bool Success { get; set; } = true; // true or false
        public List<string> ErrorsList { get; set; } // eg: "there's no products avaible right now"
        public object Result { get; set; } // object fetched

        public ApiResponse() 
        {
            ErrorsList = new List<string>();
        }
    }
}
