using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyEBooks
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Search",
                url: "search/{keyword}",
                defaults: new { controller = "Search", action = "Index", keyword = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Category",
                url: "category/{categoryName}",
                defaults: new { controller = "Category", action = "Index", categoryName = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}