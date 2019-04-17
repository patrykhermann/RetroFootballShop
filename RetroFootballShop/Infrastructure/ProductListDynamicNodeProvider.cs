using MvcSiteMapProvider;
using RetroFootballShop.DAL;
using RetroFootballShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RetroFootballShop.Infrastructure
{
    public class ProductListDynamicNodeProvider : DynamicNodeProviderBase
    {
        private ShopContext db = new ShopContext();

        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            var returnValue = new List<DynamicNode>();

            foreach (League itm in db.Leagues)
            {
                DynamicNode n = new DynamicNode();
                n.Title = itm.Name;
                n.Key = "Category_" + itm.LeagueId;
                n.RouteValues.Add("categoryname", itm.Name.ToLower().Replace(" ","-"));
                returnValue.Add(n);
            }

            return returnValue;
        }
    }
}