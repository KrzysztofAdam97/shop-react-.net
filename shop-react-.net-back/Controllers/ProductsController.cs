using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shop_react_.net_back.Data;
using shop_react_.net_back.Entities;

namespace shop_react_.net_back.Controllers
{
    public class ProductsController : BaseApiController
    {
        private readonly ShopContext _context;

        public ProductsController(ShopContext context)
        { 
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<product>>> GetProducts()
        {
            return await _context.products.ToListAsync();
        }

        [HttpGet("{id}")] // na przykład api/products/1
        public async Task<ActionResult<product>> GetProduct(int id)
        {
            return await _context.products.FindAsync(id);
        }
        

    }
}
