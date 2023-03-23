using System.ComponentModel.DataAnnotations;

namespace eFoodDelivery_API.DTOs
{
    public class ProductUpdateDTO
    {
        [Required]
        [StringLength(30, ErrorMessage = "El nombre del producto no puede exceder los 30 caracteres")]
        public string Name { get; set; }

        [StringLength(250, ErrorMessage = "La descripción del producto no puede exceder los 250 caracteres")]
        public string Description { get; set; }

        [StringLength(20, ErrorMessage = "La etiqueta del producto no puede exceder los 20 caracteres")]
        public string Tag { get; set; }

        [StringLength(20, ErrorMessage = "La categoría del producto no puede exceder los 20 caracteres")]
        public string Category { get; set; }

        [Range(1, 99, ErrorMessage = "El precio del producto no puede ser mayor a 99,00€")]
        public double Price { get; set; }

        public IFormFile Image { get; set; }
    }
}
