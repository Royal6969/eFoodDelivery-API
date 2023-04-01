using System.ComponentModel.DataAnnotations;

namespace eFoodDelivery_API.DTOs
{
    public class OrderDetailsCreateDTO
    {
        [Required]
        public int ItemId { get; set; }

        [Required]
        public int ItemQuantity { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public string ItemPrice { get; set; }
    }
}
