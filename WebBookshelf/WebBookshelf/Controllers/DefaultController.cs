using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBookshelf.Models;

namespace WebBookshelf.Controllers
{
    [Authorize]
    public class DefaultController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var values = c.Books.Include(x => x.Category).ToList(); //ilişkisel veritabanında ilişkili id'nin adını yazdırmak için
            return View(values);                                    //Include metodu gerekli.
        }
        [HttpGet]
        public IActionResult AddBook()
        {
            List<SelectListItem> books = (from x in c.Categories.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.CategoryName,
                                              Value = x.CategoryId.ToString()
                                          }).ToList();
            ViewBag.value = books;
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(Book b)
        {
            var book = c.Categories.Where(x => x.CategoryId == b.Category.CategoryId).FirstOrDefault();
            b.Category = book;
            c.Books.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");

            //c.Books.Add(b);
            //c.SaveChanges();
            //return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateBook(int id)
        {
            List<SelectListItem> books = (from x in c.Categories.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.CategoryName,
                                              Value = x.CategoryId.ToString()
                                          }).ToList();
            ViewBag.value = books;
            var values = c.Books.Find(id);
            return View("UpdateBook", values);
        }
        [HttpPost]
        public IActionResult UpdateBook(Book b)
        {
            var book = c.Categories.Where(x => x.CategoryId == b.Category.CategoryId).FirstOrDefault();
            b.Category = book;
            c.Books.Update(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteBook(int id)
        {
            var book = c.Books.Find(id);
            c.Books.Remove(book);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
