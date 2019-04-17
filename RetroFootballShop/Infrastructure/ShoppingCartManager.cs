using RetroFootballShop.DAL;
using RetroFootballShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RetroFootballShop.Infrastructure
{
    public class ShoppingCartManager
    {
        private ShopContext db;

        private ISessionManager session;

        public const string CartSessionKey = "CartData";

        public ShoppingCartManager(ISessionManager session, ShopContext db)
        {
            this.session = session;
            this.db = db;
        }

        public void AddToCart(int productId)
        {
            var cart = GetCart();

            var cartItem = cart.Find(c => c.Product.ProductId == productId);

            if (cartItem != null)
                cartItem.Quantity++;
            else
            {
                var productToAdd = db.Products.Where(p => p.ProductId == productId).SingleOrDefault();

                if(productToAdd != null)
                {
                    var newCartItem = new CartItem()
                    {
                        Product = productToAdd,
                        Quantity = 1,
                        TotalPrice = productToAdd.Price
                    };

                    cart.Add(newCartItem);
                }
            }

            session.Set(CartSessionKey, cart);
        }

        public List<CartItem> GetCart()
        {
            List<CartItem> cart;

            if (session.Get<List<CartItem>>(CartSessionKey) == null)
            {
                cart = new List<CartItem>();
            }
            else
            {
                cart = session.Get<List<CartItem>>(CartSessionKey) as List<CartItem>;
            }

            return cart;
        }

        public int RemoveFromCart(int productId)
        {
            var cart = GetCart();

            var cartToRemove = cart.Find(c => c.Product.ProductId == productId);

            if (cartToRemove != null)
            {
                if (cartToRemove.Quantity > 1)
                {
                    cartToRemove.Quantity--;
                    return cartToRemove.Quantity;
                }
                else
                    cart.Remove(cartToRemove);
            }

            return 0;
        }

        public decimal GetCartTotalPrice()
        {
            var cart = GetCart();
            return cart.Sum(c => (c.Quantity * c.Product.Price));
        }

        public int GetCartItemsCount()
        {
            var cart = GetCart();

            int count = cart.Sum(c => c.Quantity);

            return count;
        }

        public void EmptyCart()
        {
            session.Set<List<CartItem>>(CartSessionKey, null);
        }
    }
}