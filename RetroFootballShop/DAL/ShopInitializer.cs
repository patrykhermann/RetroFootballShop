using RetroFootballShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RetroFootballShop.DAL
{
    public class ShopInitializer : DropCreateDatabaseAlways<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {

            var leagues = new List<League>
            {
                new League() { LeagueId = 1, Name = "Liga angielska" },
                new League() { LeagueId = 2, Name = "Liga hiszpańska" },
                new League() { LeagueId = 3, Name = "Liga niemiecka" },
                new League() { LeagueId = 4, Name = "Liga włoska" },
                new League() { LeagueId = 5, Name = "Pozostałe ligi" },
                new League() { LeagueId = 6, Name = "Reprezentacje" },
            };

            leagues.ForEach(l => context.Leagues.Add(l));
            context.SaveChanges();



            var products = new List<Product>
            {
                new Product() { ProductId = 1, ClubName = "Manchester United", Year = "1995", ImgFileName="manutd95.jpg", Description = "Domowa koszulka Manchester'u United z roku 1995 w rozmiarze XL.", Price = 219, LeagueId = 1, DateAdded = DateTime.Now.AddDays(-1) },
                new Product() { ProductId = 2, ClubName = "Chelsea London", Year = "1998", ImgFileName="chelsea89.jpg", Description = "Domowa koszulka Manchester'u United z roku 1995 w rozmiarze XL.", Price = 199, LeagueId = 1, DateAdded = DateTime.Now.AddDays(-1) },
                new Product() { ProductId = 3, ClubName = "Bayern Munich", Year = "1995", ImgFileName="bayern95.jpg", Description = "Domowa koszulka Manchester'u United z roku 1995 w rozmiarze XL.", Price = 199, LeagueId = 3, DateAdded = DateTime.Now.AddDays(-1) },
                new Product() { ProductId = 4, ClubName = "AC Milan", Year = "1997", ImgFileName="milan97.jpg", Description = "Domowa koszulka Manchester'u United z roku 1995 w rozmiarze XL.", Price = 219, LeagueId = 4, DateAdded = DateTime.Now.AddDays(-1) },
                new Product() { ProductId = 5, ClubName = "Real Madryt", Year = "1998", ImgFileName="real98.jpg", Description = "Domowa koszulka Manchester'u United z roku 1995 w rozmiarze XL.", Price = 199, LeagueId = 2, DateAdded = DateTime.Now.AddDays(-1) },
                new Product() { ProductId = 5, ClubName = "FC Barcelona", Year = "1998", ImgFileName="barcelona98.jpg", Description = "Domowa koszulka Manchester'u United z roku 1995 w rozmiarze XL.", Price = 199, LeagueId = 2, DateAdded = DateTime.Now.AddDays(-1) },
                new Product() { ProductId = 7, ClubName = "Arsenal London", Year = "1994", ImgFileName="arsenal94.jpg", Description = "Domowa koszulka Manchester'u United z roku 1995 w rozmiarze XL.", Price = 239, LeagueId = 1, DateAdded = DateTime.Now.AddDays(-1) },
                new Product() { ProductId = 8, ClubName = "Atletico Madrid", Year = "1995", ImgFileName="atletico95.jpg", Description = "Domowa koszulka Manchester'u United z roku 1995 w rozmiarze XL.", Price = 199, LeagueId = 2, DateAdded = DateTime.Now.AddDays(-1) },
                new Product() { ProductId = 9, ClubName = "Inter Mediolan", Year = "2004", ImgFileName="inter04.jpg", Description = "Domowa koszulka Manchester'u United z roku 1995 w rozmiarze XL.", Price = 199, LeagueId = 4, DateAdded = DateTime.Now.AddDays(-1) },
                new Product() { ProductId = 10, ClubName = "Juventus Turin", Year = "2004", ImgFileName="juve04.jpg", Description = "Domowa koszulka Manchester'u United z roku 1995 w rozmiarze XL.", Price = 199, LeagueId = 4, DateAdded = DateTime.Now.AddDays(-1) },
                new Product() { ProductId = 11, ClubName = "Manchester United", Year = "2012", ImgFileName="manunited12.jpg", Description = "Domowa koszulka Manchester'u United z roku 1995 w rozmiarze XL.", Price = 199, LeagueId = 1, DateAdded = DateTime.Now.AddDays(-1) },
                new Product() { ProductId = 12, ClubName = "Newcastle United", Year = "2010", ImgFileName="newcastle10.jpg", Description = "Domowa koszulka Manchester'u United z roku 1995 w rozmiarze XL.", Price = 199, LeagueId = 1, DateAdded = DateTime.Now.AddDays(-1) },
                new Product() { ProductId = 13, ClubName = "Polska", Year = "2002", ImgFileName="poland02.jpg", Description = "Domowa koszulka Manchester'u United z roku 1995 w rozmiarze XL.", Price = 199, LeagueId = 6, DateAdded = DateTime.Now.AddDays(-1) },
                new Product() { ProductId = 14, ClubName = "Rosenborg", Year = "1996", ImgFileName="rosenborg96.jpg", Description = "Domowa koszulka Manchester'u United z roku 1995 w rozmiarze XL.", Price = 199, LeagueId = 5, DateAdded = DateTime.Now.AddDays(-1) },
                new Product() { ProductId = 15, ClubName = "Valencia", Year = "2004", ImgFileName="valencia04.jpg", Description = "Domowa koszulka Manchester'u United z roku 1995 w rozmiarze XL.", Price = 199, LeagueId = 2, DateAdded = DateTime.Now.AddDays(-1) },
                new Product() { ProductId = 16, ClubName = "West Ham United", Year = "1999", ImgFileName="westham99.jpg", Description = "Domowa koszulka Manchester'u United z roku 1995 w rozmiarze XL.", Price = 199, LeagueId = 1, DateAdded = DateTime.Now.AddDays(-1) },
            };

            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
        }
    }
}