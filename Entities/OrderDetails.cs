using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eFoodDelivery_API.Entities
{
    [Table("dwh_orderDetails", Schema = "dwh_efooddelivery_api")]
    public class OrderDetails
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
        [Column("OrderDetailsId")]
        [Display(Name = "OrderDetailsId")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderDetailsId { get; set; }

        // we need a mapping with the order id, because in order there is a OneToMany relation
        // so for that we will have a property OrderId, and inside the order, I will have a collection property of OrderDetails
        [Required]
        [Column("OrderId")]
        [Display(Name = "OrderId")]
        public int OrderId { get; set; }

        // we need the item id similar to what we had inside the CartItem with the productId
        [Required]
        [Column("ProductId")]
        [Display(Name = "ProductId")]
        public int ProductId { get; set; }

        // we need the quantity of the item that they want to order
        [Required]
        [Column("Quantity")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        // and from the Product, we can retrieve the name and price of that product
        // but sometimes what can happen is that product, the name or price gets updated
        // in that case, we don't want it to toggle the price that order was placed with
        // so that is why right here I will also add two more columns for item name and item price
        [Required]
        [Column("Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Column("Price")]
        [Display(Name = "Price")]
        [Range(1, 99, ErrorMessage = "El precio del producto no puede ser mayor a 99,00€")]
        public double Price { get; set; }


        /*************************************** Relational fields *************************************/
        // we need the navigation property and the FK relation
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}