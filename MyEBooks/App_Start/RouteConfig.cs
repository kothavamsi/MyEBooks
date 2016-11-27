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
                name: "SearchPage",
                url: "search/{keyword}/page/{pageNo}",
                defaults: new { controller = "Search", action = "Index" }
            );

            routes.MapRoute(
                name: "Search",
                url: "search/{keyword}",
                defaults: new { controller = "Search", action = "Index" }
             );

            routes.MapRoute(
                name: "CategoryPage",
                url: "category/{categoryName}/page/{pageNo}",
                defaults: new { controller = "Category", action = "Index" }
            );

            routes.MapRoute(
                name: "Category",
                url: "category/{categoryName}",
                defaults: new { controller = "Category", action = "Index" }
            );

            routes.MapRoute(
                name: "YearAndMonth",
                url: "{Year}/{Month}",
                defaults: new { controller = "Home", action = "YearAndMonth" },
                constraints: new { Year = @"\d{4}", Month=@"\d{1,2}" }

            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" }
            );
        }
    }
}