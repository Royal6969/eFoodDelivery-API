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
        [Range(1, 99, ErrorMessage = "El precio del producto no puede ser mayor a 99,00€")]
        public double ItemPrice { get; set; }
    }
}
