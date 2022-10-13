namespace DotNetCA.Models
{
    public class Cart
    {
        public int cartId { get; set; }
        public int quantity { get; set; }
        public Product Product { get; set; }    
    }
}