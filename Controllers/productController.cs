using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class productController : Controller
    {
        ApplicationDbContext dbcontext = new ApplicationDbContext();


        // GET: product
        public ActionResult Index()
        {
            var products = dbcontext.products.ToList();
            return View(products);
        }
        public ActionResult Create()        {
            return View();
        }
        [HttpPost]
       public ActionResult Create(product products)
        {
            dbcontext.products.Add(products);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id)
        {
            var product = dbcontext.products.SingleOrDefault(e => e.id == id);
            dbcontext.products.Remove(product);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Edit(int ?id)
        {
            var product = dbcontext.products.SingleOrDefault(e => e.id == id);
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(product products)
        {
            dbcontext.Entry(products).State = System.Data.Entity.EntityState.Modified;
            dbcontext.SaveChanges();

            return View();

        }
       




























    }
}