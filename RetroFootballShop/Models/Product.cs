using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RetroFootballShop.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int LeagueId { get; set; }

        [Required(ErrorMessage = "Musisz podać nazwę klubu." )]
        [StringLength(100)]
        public string ClubName { get; set; }

        [StringLength(4)]
        [Required(ErrorMessage = "Musisz podać rok, z którego pochodzi produkt.")]
        public string Year { get; set; }

        [Required(ErrorMessage = "Musisz podać cenę produktu.")]
        public decimal Price { get; set; }

        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public string ImgFileName { get; set; }

    }
}