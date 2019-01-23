using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyECommerce.Models;

namespace MyECommerce.Controllers.Api
{
    public class ProductCategoriesController : ApiController
    {
        private ApplicationDbContext _context;
        public ProductCategoriesController()
        {
            _context = new ApplicationDbContext();
        }

        // POST  /api/products
        [HttpPost]
        public ProductCategory CreateProduct(ProductCategory productCategory)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.ProductCategories.Add(productCategory);
            _context.SaveChanges();

            return productCategory;
        }


        // DELETE /api/productCategories/1
        [HttpDelete]
        public void DeleteCategory(int id)
        {
            var categoryInDb = _context.ProductCategories.SingleOrDefault(p => p.Id == id);

            if (categoryInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.ProductCategories.Remove(categoryInDb);
            _context.SaveChanges();
        }
    }
}
