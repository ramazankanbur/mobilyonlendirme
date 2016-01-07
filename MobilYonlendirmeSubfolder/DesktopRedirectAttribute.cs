using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobilYonlendirmeSubfolder
{
    public class DesktopRedirectAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Bu attribute mobil url i masaüstüne yazan kullanıcıları masaüstüne yönlendirecektir.
            var path = filterContext.HttpContext.Request.Url.AbsolutePath;
            if (!filterContext.HttpContext.Request.Browser.IsMobileDevice)
            {
                path = path.Contains("/mobile/") ? path.Substring(7) : path;
                filterContext.HttpContext.Response.Redirect(path);
            }


        }
    }
}