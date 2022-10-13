using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;

namespace DigiShop.Models
{
        public class Cart
        {
                public Cart()
                {
                    cartId++;
                   // Product = new List<Product>();
                }
                [Required]
                public int cartId { get; set; }
                [ForeignKey("productId")]
                public int productId { get; set; }
                [ForeignKey("customreId")]
                public int customerId { get; set; }
                [Required]
                public int itemCount { get; set; }
                [ForeignKey("customreId")]
                public virtual Customer Customer { get; set; }
                [ForeignKey("productId")]   
                //public virtual ICollection<Product> Product { get; set; }
                public virtual Product Product { get; set; }

    }
}
