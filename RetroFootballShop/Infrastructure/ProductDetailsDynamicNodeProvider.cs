using MvcSiteMapProvider;
using RetroFootballShop.DAL;
using RetroFootballShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RetroFootballShop.Infrastructure
{
    public class ProductDetailsDynamicNodeProvider : DynamicNodeProviderBase
    {

        private ShopContext db = new ShopContext();

        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            var returnValue = new List<DynamicNode>();

            foreach (Product itm in db.Products)
            {
                DynamicNode n = new DynamicNode();
                n.Title = itm.ClubName;
                n.Key = "Product_" + itm.ProductId;
                n.ParentKey = "Category_" + itm.LeagueId;
                n.RouteValues.Add("id", itm.ProductId);
                returnValue.Add(n);
            }

            return returnValue;
        }
    }
}