using RetroFootballShop.DAL;
using RetroFootballShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RetroFootballShop.Controllers
{
    public class HomeController : Controller
    {
        ShopContext db = new ShopContext();

        // GET: Home
        public ActionResult Index()
        {

            var newArrivals = db.Products.OrderByDescending(p => p.DateAdded).Take(6).ToList();

            var categories = db.Leagues.ToList();

            var homeVM = new HomeViewModel() { NewArrivals = newArrivals, Leagues = categories };

            return View(homeVM);
        }

        public ActionResult StaticContent(string viewname)
        {
            return View(viewname);
        }
    }
}