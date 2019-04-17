using RetroFootballShop.DAL;
using RetroFootballShop.Infrastructure;
using RetroFootballShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RetroFootballShop.Controllers
{
    public class CartController : Controller
    {
        private ShopContext db = new ShopContext();
        private ISessionManager sessionManager { get; set; }
        private ShoppingCartManager cartManager;

        public CartController()
        {
            sessionManager = new SessionManager();
            cartManager = new ShoppingCartManager(this.sessionManager, db);
        }

        // GET: Cart
        public ActionResult Index()
        {
            var cartItems = cartManager.GetCart();
            var cartTotalPrice = cartManager.GetCartTotalPrice();

            var cartVM = new CartViewModel()
            {
                CartItems = cartItems,
                TotalPrice = cartTotalPrice
            };

            return View(cartVM);
        }

        public ActionResult AddToCart(int id)
        {
            cartManager.AddToCart(id);

            return RedirectToAction("Index");
        }

        public ActionResult RemoveFromCart(int id)
        {
            int itemCount = cartManager.RemoveFromCart(id);

            return RedirectToAction("Index");
        }

        public int GetCartItemsCount()
        {
            return cartManager.GetCartItemsCount();
        }
    }
}