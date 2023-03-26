using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class productsController : ControllerBase 
    {
        private readonly StoreContext _context;
        public productsController(StoreContext context)
        {
            _context = context;
            
        }
       [HttpGet]
       public async Task<ActionResult<List<Product>>> GetProducts()

       {
        var products = await _context.products.ToListAsync();
        return products;
       } 
        [HttpGet("{id}")]
       public async Task<ActionResult<Product>> GetProducts(int id)

       {
        return await _context.products.FindAsync(id);
       } 
    }
}