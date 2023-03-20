using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eFoodDelivery_API.Models
{
    [Table("product", Schema = "dwh_efooddelivery_api")]
    public class Product
    {
        [Column("Md_uuid")]
        [Display(Name = "Md_uuid")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Md_uuid { get; set; } = Guid.NewGuid();

        [Column("Md_date")]
        [Display(Name = "Md_date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Md_date { get; set; } = DateTime.Now;

        [Key]
        [Column("Id")]
        [Display(Name = "Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [Column("Name")]
        [Display(Name = "Name")]
        [StringLength(25, ErrorMessage = "El nombre del producto no puede exceder los 25 caracteres")]
        public string Name { get; set; }

        [Column("Description")]
        [Display(Name = "Description")]
        [StringLength(60, ErrorMessage = "La descripción del producto no puede exceder los 60 caracteres")]
        public string Description { get; set; }

        [Column("Tag")]
        [Display(Name = "Tag")]
        [StringLength(15, ErrorMessage = "La etiqueta del producto no puede exceder los 15 caracteres")]
        public string Tag { get; set; }

        [Column("Category")]
        [Display(Name = "Category")]
        [StringLength(10, ErrorMessage = "La categoría del producto no puede exceder los 10 caracteres")]
        public string Category { get; set; }

        [Column("Price")]
        [Display(Name = "Price")]
        [Range(1, 99, ErrorMessage = "El precio del producto no puede ser mayor a 99,00€")]
        public double Price { get; set; }

        [Required]
        [Column("Image")]
        [Display(Name = "Image")]
        public string Image { get; set; }
    }
}
