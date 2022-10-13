using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiShop.Models
{
        public class Product
        {
            public Product()
            {
                productId++;
                Cart = new List<Cart>();
                Order = new List<Order>();
            }
            [Required]
            public int productId { get; set; }
            public string productName { get; set; }
            //public int Quantity { get; set; }
            public decimal productPrice { get; set; }
            public string productDesc { get; set; }
            public string productIMG { get; set; }
            public virtual ICollection<Cart> Cart { get; set; }
            public virtual ICollection<Order> Order { get; set; }
        
        }
}
