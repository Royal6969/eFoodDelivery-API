using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eFoodDelivery_API.Entities
{
    [Table("dwh_cartItem", Schema = "dwh_efooddelivery_api")]
    public class CartItem
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

        [Column("ProductId")]
        [Display(Name = "ProductId")]
        public int ProductId { get; set; }

        [Column("Quantity")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Column("CartId")]
        [Display(Name = "CartId")]
        public int CartId { get; set; }


        /*************************************** Relational fields *************************************/

        [ForeignKey("ProductId")]
        public Product Product { get; set; } = new Product();
    }
}