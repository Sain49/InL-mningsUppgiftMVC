using System.Linq;
using System.Net.Http;
using System.Web.Mvc;
using MyECommerce.Models;
using MyECommerce.ViewModels;

namespace MyECommerce.Controllers
{
    public class ProductCategorysController : Controller
    {
        private ApplicationDbContext _context;

        public ProductCategorysController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: ProductCategorys
       [AllowAnonymous]
        public ViewResult ReadOnlyList()
        {
            return View();
        }

        [AllowAnonymous]
        public ViewResult List()
        {
            var categories = _context.ProductCategories.ToList();

            if (User.IsInRole("CanManageProducts"))
                return View(categories);

            return View("ReadOnlyList", categories);
        }

        // Create New Category
       [HttpPost]
        public ActionResult Save(ProductCategory productCategory)
        {
            if (productCategory.Id == 0)
                _context.ProductCategories.Add(productCategory);
            else
            {
                UpdateModel(productCategory);
            }
            _context.SaveChanges();

            return RedirectToAction("List", "ProductCategorys");
        }

        public ActionResult CategoryForm()
        {
            return View();
        }

        // Category Details
        [AllowAnonymous]
        public ViewResult Details(int id)
        {
            var categories = _context.ProductCategories.SingleOrDefault(c => c.Id == id);

            var products = _context.Products.Where(p => p.Category_Id == categories.Id).ToList();

            if (categories == null) return null;
            var viewModel = new CategoryFormViewModel
            {
                Name = categories.Name,
                Products = products
            };
            return View(viewModel);
        }

        // Edit a Category
        public ActionResult Edit(int id)
        {
            var category = _context.ProductCategories.SingleOrDefault(c => c.Id == id);

            if (category == null)
                return HttpNotFound();

            var viewModel = new CategoryFormViewModel
            {
                Name = category.Name
            };
            return View("CategoryForm", viewModel);
        }


        // Delete Category
        public ActionResult Delete(int id)
        {
            var category = _context.ProductCategories.SingleOrDefault(c => c.Id == id);

            if (category == null)
                return HttpNotFound();

            _context.ProductCategories.Remove(category);
            _context.SaveChanges();

            return RedirectToAction("List", "ProductCategorys");
        }
    }
}