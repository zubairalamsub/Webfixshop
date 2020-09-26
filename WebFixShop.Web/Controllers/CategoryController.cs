using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebfixShop.Entities;
using WebfixShop.Services;

namespace WebFixShop.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesService categoriesService = new CategoriesService();

        [HttpGet]
        public ActionResult Index()
        {
            var categoies = categoriesService.GetCategories();
            //List<Category> Cats = categoriesService.GetCategories();
            return View(categoies);
        }

        // GET: Category
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {

            categoriesService.SaveCategory(category);
            return View();

        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var category = categoriesService.GetCategories(ID);
            return View(category);

        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {

            categoriesService.UpdateCategory(category);
            return RedirectToAction("Index");

        }


        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var category = categoriesService.GetCategories(ID);
            return View(category);

        }

        [HttpPost]
        public ActionResult Delete(Category category)
        {

            categoriesService.DeleteCategory(category.ID);
            return RedirectToAction("Index");

        }



    }


}