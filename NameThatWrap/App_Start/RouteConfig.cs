using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NameThatWrap
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "AccountRoute",
                url: "members/account/{action}",
                defaults: new { controller = "Account", action = "Index" }
            );

            routes.MapRoute(
                name: "FeedbackRoute",
                 url: "feedback/{action}",
                 defaults: new { controller = "Feedback", action = "Suggestion" }
            );

            routes.MapRoute(
                name: "WrapRoute",
                url: "content/{action}",
                defaults: new { controller = "Home", action = "WrapList" }
            );

            routes.MapRoute(
                name: "LevelRoute",
                url: "content/{action}",
                defaults: new { controller = "Home", action = "Level"}
                );

            routes.MapRoute(
                name: "Default",
                url: "{action}/",
               defaults: new { controller = "Account", action = "Index" }
                //took out controller and id from url
                //took out id from default
            );
        }
    }
}