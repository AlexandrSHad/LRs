using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LR38_WebAPI.Models;

namespace LR38_WebAPI.Controllers
{
    public class ProductController : ApiController
    {
        private readonly DataContext _context;

        public ProductController()
        {
            _context = new DataContext();
        }
        
        // GET api/values
        public IEnumerable<Product> Get()
        {
            return _context.Products.ToList();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
