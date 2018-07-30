using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApI.Models;

namespace WebApI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private static List<Products> p = new List<Products>(new[]
        {
            new Products() {id = 1, name = "deepika" },
            new Products() {id = 2, name = "deepthi" },
            new Products() {id = 3, name = "spoorthi" }
        });
        [HttpGet]
        public List<Products> Get()
        {
            return p;
        }
        [HttpGet("{id}")]
        public Products Get(int id)
        {
            return p.SingleOrDefault(p => p.id == id);
        }
        [HttpPost]
        public void Post([FromBody] Products pr)
        {
            p.Add(pr);
        }
    }
}