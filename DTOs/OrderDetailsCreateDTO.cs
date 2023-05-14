using System.ComponentModel.DataAnnotations;

namespace eFoodDelivery_API.DTOs
{
    public class OrderDetailsCreateDTO
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 99, ErrorMessage = "El precio del producto no puede ser mayor a 99,00€")]
        public double Price { get; set; }
    }
}
