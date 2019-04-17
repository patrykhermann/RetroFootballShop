using RetroFootballShop.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RetroFootballShop.Controllers
{
    public class ShopController : Controller
    {
        ShopContext db = new ShopContext();

        // GET: Shop
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var product = db.Products.Find(id);

            return View(product);
        }

        [ChildActionOnly]
        [OutputCache(Duration = 86400)]
        public ActionResult CategoriesMenu()
        {
            var categories = db.Leagues.ToList();

            return View(categories);
        }

        public ActionResult List(string categoryname)
        {
            var category = db.Leagues.Include("Products").Where(c => c.Name.ToLower().Replace(" ", "-") == categoryname).Single();
            var products = category.Products;

            return View(products);
        }

        public ActionResult SearchResult(string searchString)
        {
            var filteredProducts = db.Products.Where(p => p.ClubName.ToLower().Contains(searchString.ToLower()));

            return View(filteredProducts.ToList());
        }
    }
}