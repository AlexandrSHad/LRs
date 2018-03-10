using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using LR38_WebAPI.Models;
using System.Data.Entity;

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
        public IHttpActionResult Get(int id)
        {
            var model = _context.Products.FirstOrDefault(p => p.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

        // POST api/values
        public IHttpActionResult Post([FromBody]Product model)
        {
            if (model == null)
            {
                return BadRequest();
            }

            _context.Products.Add(model);
            _context.SaveChanges();

            return Ok();
        }

        // PUT api/values/5
        public IHttpActionResult Put([FromBody]Product model)
        {
            if (model == null)
            {
                return BadRequest();
            }

            _context.Products.Attach(model);
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok();
        }

        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            var model = _context.Products.FirstOrDefault(p => p.Id == id);

            if (model == null)
            {
                return BadRequest();
            }

            _context.Products.Remove(model);
            _context.SaveChanges();

            return Ok();
        }
    }
}
