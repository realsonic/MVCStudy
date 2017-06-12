using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lesson_02
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{op1}/{op2}",
                defaults: new { controller = "Home", action = "Index", op1 = UrlParameter.Optional, op2 = UrlParameter.Optional }
            );
        }
    }
}
