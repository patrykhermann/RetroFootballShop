using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RetroFootballShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Musisz wprowadzić imię.")]
        public string FirstName { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Musisz wprowadzić nazwisko")]
        public string LastName { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "Musisz wprowadzić adres.")]
        public string Address { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "Musisz wprowadzić kod pocztowy i miasto.")]
        public string CodeAndCity { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "Musisz wprowadzić numer telefonu.")]
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Comment { get; set; }
        public DateTime DateCreated { get; set; }
        public OrderState OrderState { get; set; }

        public decimal TotalPrice { get; set; }

        public List<OrderItem> OrderItems { get; set; }

    }

    public enum OrderState
    {
        [Display(Name = "Nowe")]
        New,
        [Display(Name = "Wysłane")]
        Shipped
    }
}