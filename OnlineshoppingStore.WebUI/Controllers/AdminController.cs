using OnlineShoppingStore.Domain.Abstract;
using OnlineShoppingStore.Domain.Entities;
using System.Linq;
using System.Web.Mvc;

namespace OnlineshoppingStore.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductRepository _repo;

        public AdminController(IProductRepository repo)
        {
            _repo = repo;
        }
       
        // GET: Admin
        public ViewResult Index()
        {
            return View(_repo.Products);
        }

        public ViewResult Edit(int productId)
        {
            Product product = _repo.Products.FirstOrDefault(p => p.ProductId == productId);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _repo.SaveProduct(product);
                TempData["message"] = string.Format("{0} has been saved", product.Name);
                return RedirectToAction("Index");
            }
            else
            {
            }
            // there is something wrong with the data values
            return View(product);
        }
    }
}