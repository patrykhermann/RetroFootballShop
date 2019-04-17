using RetroFootballShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RetroFootballShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> NewArrivals { get; set; }

        public IEnumerable<League> Leagues { get; set; }
    }
}