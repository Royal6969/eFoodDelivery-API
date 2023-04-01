using eFoodDelivery_API.Entities;
using eFoodDelivery_API.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eFoodDelivery_API.DTOs
{
    public class OrderCreateDTO
    {
        [Required]
        public string ClientName { get; set; }

        [Required]
        public string ClientPhone { get; set; }

        [Required]
        public string ClientEmail { get; set; }
        
        public string ClientId { get; set; }
        
        public double OrderTotal { get; set; }
        
        public string OrderPaymentID { get; set; }
        
        public string OrderStatus { get; set; }
        
        public int OrderQuantityItems { get; set; }

        public IEnumerable<OrderDetails> OrderDetails { get; set; }
    }
}