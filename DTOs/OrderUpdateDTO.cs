using eFoodDelivery_API.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eFoodDelivery_API.DTOs
{
    public class OrderUpdateDTO
    {
        public int OrderId { get; set; }

        public string ClientName { get; set; }

        public string ClientPhone { get; set; }

        public string ClientEmail { get; set; }

        public string OrderPaymentID { get; set; }

        public string OrderStatus { get; set; }
    }
}