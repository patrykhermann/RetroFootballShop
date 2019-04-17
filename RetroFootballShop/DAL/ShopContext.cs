using RetroFootballShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RetroFootballShop.DAL
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base("ShopContext") { }

        public DbSet<Product> Products { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}