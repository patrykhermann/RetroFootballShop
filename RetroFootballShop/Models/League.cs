using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RetroFootballShop.Models
{
    public class League
    {
        public int LeagueId { get; set; }

        [Required(ErrorMessage = "Musisz podać nazwę ligi.")]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}