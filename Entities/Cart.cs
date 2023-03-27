using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eFoodDelivery_API.Entities
{
    [Table("dwh_cart", Schema = "dwh_efooddelivery_api")]
    public class Cart
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

        [Column("UserId")]
        [Display(Name = "UserId")]
        public string UserId { get; set; } // the UserId in dlk_users table

        // for when someone tries to check out with the items in the cart, we will need three more attributes...
        [NotMapped]
        public double Total { get; set; }

        [NotMapped] 
        public string PaymentAttempId { get; set; } // stripe payment gateway will give us a SecretID that will be used to check out

        [NotMapped]
        public string ClientSecret { get; set; } // stripe client secret


        /*************************************** Relational fields *************************************/
        // OneToMany
        public ICollection<CartItem> CartItemsList { get; set; }
    }
}