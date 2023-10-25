using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH03.Models;
using System.Data.Entity;

namespace TH03.Controllers
{
    public class HomeController : Controller
    {
        private EshopDB db = new EshopDB();
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Category);
            return View(products.ToList());
        }

    }
}