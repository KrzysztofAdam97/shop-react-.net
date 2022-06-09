using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using shop_react_.net_back.Data;
using shop_react_.net_back.Entities;

namespace shop_react_.net_back.Controllers
{
    public class ProductsController : BaseApiController
    {
        private readonly ShopContext context;
        public ProductsController(ShopContext context)
        {
            this.context = context;
            
        }

        [HttpGet]
        public ActionResult<List<product>> GetProducts()
        {
            var products = context.products.ToList();

            return Ok(products);
        }

        [HttpGet("{id}")] // na przykład api/products/1
        public ActionResult<product> GetProduct(int id)
        {
            return context.products.Find(id);
        }

    }
}
