using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBookshelf.Models;

namespace WebBookshelf.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var values = c.Categories.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            c.Categories.Add(category);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCategory(int id)
        {
            var category = c.Categories.Find(id);
            c.Categories.Remove(category);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var values = c.Categories.Find(id);
            return View("UpdateCategory", values);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category ca)
        {
            c.Categories.Update(ca);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DetailsCategory(int id)
        {
            var values = c.Books.Where(x => x.CategoryId == id).ToList();
            var categoryName = c.Categories.Where(x => x.CategoryId == id).Select(y => y.CategoryName).FirstOrDefault();
            ViewBag.v1 = categoryName;
            return View(values);
        }
    }
}
