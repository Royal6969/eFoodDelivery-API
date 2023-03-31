using eFoodDelivery_API.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eFoodDelivery_API.Entities
{
    [Table("dwh_order", Schema = "dwh_efooddelivery_api")]
    public class Order
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
        [Column("OrderId")]
        [Display(Name = "OrderId")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [Required]
        [Column("ClientName")]
        [Display(Name = "ClientName")]
        public string ClientName { get; set; }

        [Required]
        [Column("ClientPhone")]
        [Display(Name = "ClientPhone")]
        public string ClientPhone { get; set; }

        [Required]
        [Column("ClientEmail")]
        [Display(Name = "ClientEmail")]
        public string ClientEmail { get; set; }

        // we have the application user id that needs to be a FK to the user table
        // because only if a user is registered, they will be able to place an order 
        [Column("ClientId")]
        [Display(Name = "ClientId")]
        public string ClientId { get; set; }

        [Column("OrderTotal")]
        [Display(Name = "OrderTotal")]
        public double OrderTotal { get; set; }

        // let's define an order date, basically defines when the order was placed 
        // to differentiate it from date metadata
        [Column("OrderDate")]
        [Display(Name = "OrderDate")]
        public DateTime OrderDate { get; set; } 

        // we have the client payment id that basically be the iD od the payment that user makes
        // this is a column that we add if we want to store the payment information
        [Column("OrderPaymentID")]
        [Display(Name = "OrderPaymentID")]
        public string OrderPaymentID { get; set; }

        [Column("OrderStatus")]
        [Display(Name = "OrderStatus")]
        public string OrderStatus { get; set; }

        [Column("OrderQuantityItems")]
        [Display(Name = "OrderQuantityItems")]
        public int OrderQuantityItems { get; set; }


        /*************************************** Relational fields *************************************/
        // with EF Core, we can add the navigation property of ApplicationUser and define FK relation
        [ForeignKey("ClientId")]
        public ApplicationUser User { get; set; }

        // OneToMany
        public IEnumerable<OrderDetails> OrderDetails { get; set; }
    }
}