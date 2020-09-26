using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebfixShop.Entities;
using WebfixShop.Services;

namespace WebFixShop.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductsService productservice = new ProductsService();
        // GET: Product
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult ProductTable(string search)
        {
            var products = productservice.GetProducts();
            if (string.IsNullOrEmpty(search) == false)
            {
                products = products.Where(x => x.Name.Contains(search)).ToList();
            }
            
            return PartialView(products);

        }
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {

            productservice.SaveProduct(product);
            return RedirectToAction("ProductTable");

        }

    }
}