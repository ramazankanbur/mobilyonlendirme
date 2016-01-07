using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MobilYonlendirmeSubfolder
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
           
            // 1. Senaryo başlangıç. Her sayfanın mobilinin olduğu varsayılıyor. 
          //Mobil sayfa için yazılan route
          //routes.MapRoute(
          //"Mobile_Default",
          //"Mobile/{controller}/{action}/{id}",
          //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
          //namespaces: new[] { "MobilYonlendirmeSubfolder.Areas.Mobile.Controllers" }
          //).DataTokens.Add("Area", "Mobile");



           //Masaüstü sayfa için yazılan route
           // routes.MapRoute(
           //  name: "Default",
           //  url: "{controller}/{action}/{id}",
           //  defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
           //  namespaces: new[] { "MobilYonlendirmeSubfolder.Controllers" }
           //);

           // 1. senaryo bitiş.


            //2. Senaryo başlangıç
            //Sadece masaüstü görünümünün olduğu sayfa.
            routes.MapRoute(
            name: "Only",
            url: "OnlyDesktop/hoop",
            defaults: new { controller = "Home", action = "OnlyDesktop", id = UrlParameter.Optional },
            namespaces: new[] { "MobilYonlendirmeSubfolder.Controllers" }
          );



            //Mobil sayfa için yazılan route
            routes.MapRoute(
            "Mobile_Default",
            "Mobile/{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            namespaces: new[] { "MobilYonlendirmeSubfolder.Areas.Mobile.Controllers" }
            ).DataTokens.Add("Area", "Mobile");



            //Masaüstü sayfa için yazılan route
             routes.MapRoute(
              name: "Default",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
              namespaces: new[] { "MobilYonlendirmeSubfolder.Controllers" }
            );

        }
    }
}
