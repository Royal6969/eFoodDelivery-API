using System.Net;

namespace eFoodDelivery_API.Models
{
    public class ApiResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool Success { get; set; } = true;
        public List<string> ErrorsList { get; set; }
        public object Result { get; set; }
    
        public ApiResponse() 
        {
            ErrorsList = new List<string>();
        }
    }
}
