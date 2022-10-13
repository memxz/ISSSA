using DotNetCA.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DotNetCA.Controllers
{
    [Route("Product")]
    public class ProductController : Controller
    {
        private DB db;

        public ProductController(IConfiguration cfg)
        {
            db = new DB(cfg.GetConnectionString("db_conn"));
        }
        [Route("Index")]
        public IActionResult Index()
        {
            ViewData["viewProduct"] = getAllProduct();
            return View();
        }
        //ADD TO CART
        [Route("AddToView/{id?}")]
        public IActionResult AddToCart(int id)
        {
            var cart = HttpContext.Session.GetString("cart");//get key cart
            if (cart == null)
            {
                var product = getDetailProduct(id);
                List<Cart> listCart = new List<Cart>()
               {
                   new Cart
                   {
                       Product = product,
                       quantity = 1
                   }
               };
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));

            }
            else
            {
                List<Cart>? dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                bool check = true;
                for (int i = 0; i < dataCart?.Count(); i++)
                {
                    if (dataCart[i].Product.productId == id)
                    {
                        dataCart[i].quantity++;
                        check = false;
                    }
                }
                if (check)
                {
                    dataCart?.Add(new Cart
                    {
                        Product = getDetailProduct(id),
                        quantity = 1
                    });
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                
            }

            ///return RedirectToAction("Index","Product");
            return Redirect(Request.Headers["Referer"].ToString());
        }
        [Route("ViewCart")]
        //View Cart, Display all the product in cart
        public IActionResult ViewCart()
        {
            var cart = HttpContext.Session.GetString("cart");//get key cart
            if (cart != null)
            {
                List<Cart>? dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (dataCart?.Count() > 0)
                {
                    ViewData["Grandtotal"]=dataCart.Sum(x => x.quantity * x.Product.ProductPrice);
                    ViewData["viewCart"] = dataCart;
                    //return RedirectToAction("ViewCart","Product");
                }
            }
            return View();
        }
        //Update cart
        [HttpPost]
        public IActionResult UpdateCart(int id, int quantity)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<Cart>? dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (quantity > 0)
                {
                    for (int i = 0; i < dataCart?.Count; i++)
                    {
                        if (dataCart[i].Product.productId == id)
                        {
                            dataCart[i].quantity = quantity;
                        }
                    }


                    HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                }
                var cart2 = HttpContext.Session.GetString("cart");
                return Ok(quantity);
            }
            return BadRequest();

        }
        [Route("RemoveCart")]
        public IActionResult RemoveCart(int id)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<Cart>? dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);

                for (int i = 0; i < dataCart.Count; i++)
                {
                    if (dataCart[i].Product.productId == id)
                    {
                        dataCart.RemoveAt(i);
                    }
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                return RedirectToAction(nameof(ViewCart));
            }
            return RedirectToAction(nameof(Index));
        }
        //GET ALL PRODUCT
        public List<Product> getAllProduct()
        {
            return db.GetProductList();

        }

        //GET  PRODUCT DETAIL
        public Product getDetailProduct(int id)
        {
            var product = db.GetProductById(id);
            return product;
        }
    }
}
