using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DigiShop.Models;
using DigiShop.Infrastructure;

namespace DigiShop.Controllers
{
    [Route("Product")]
    public class ProductController : Controller
        {
                private readonly MyDbContext _context;

                public ProductController(MyDbContext context)
                {
                        _context = context;
                }
                [Route("Index")]        
                public IActionResult Index()
                {
            
                    return View(_context.Product.OrderBy(p => p.productId));
                }
                
    }
}
