using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;
using IvanCafe.Models;

namespace IvanCafe.Controllers.Api
{
    public class ProductController : ApiController
    {
        private PubDbContext _context;

        public ProductController()
        {
            _context = new PubDbContext();
        }
        // GET /api/product
        public IEnumerable<Product> GetProduct()
        {
            return _context.Products.ToList();
        }

        // GET /api/product/1
        public Product GetProduct(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);

            if (product == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return product;
        }
        // POST /api/product
        [HttpPost]
        public Product CreateProduct(Product product)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Products.Add(product);
            _context.SaveChanges();

            return product;

        }

        // PUT /api/product/1
        [HttpPut]
        public void UpdateProduct(int id, Product product)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var productInDb = _context.Products.SingleOrDefault(p => p.Id == id);

            if (productInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            productInDb.ProductTypeId = product.ProductTypeId;
            productInDb.Name = product.Name;
            productInDb.Price = product.Price;

            _context.SaveChanges();
        }

        // DELETE /api/product/1
        [HttpDelete]
        public void DeleteProduct(int id)
        {
            var productInDb = _context.Products.SingleOrDefault(c => c.Id == id);

            if (productInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.Products.Remove(productInDb);
            _context.SaveChanges();
        }
    }
}