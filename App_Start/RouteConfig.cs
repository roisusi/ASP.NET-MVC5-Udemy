﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //calling it to enable it
            routes.MapMvcAttributeRoutes();

            //list of Routs from the most important to last
            //routes.MapRoute("MoviesByReleasedDate", "movies/released/{year}/{month}",
            //    new { controller = "Movies", action = "ByReleaseDate" },new {year = @"2015|2016",month = @"\d{2}"});

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
