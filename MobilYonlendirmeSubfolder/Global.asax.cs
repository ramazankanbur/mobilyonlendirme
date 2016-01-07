using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MobilYonlendirmeSubfolder
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        //Her sayfanın mobil versiyonunun olduğunu varsaydığımız senaryoda yönlendirme kodlarını Session_Start eventi içine yazabiliriz. Begin_Request event i burada kullanılamaz. Çünkü her istekte event tekrar tetiklenip sonsuz döngü içine girecektir. Ama yine de begin_Request eventi kullanılmak istenirse string işlemleri ile path içinde "/mobile/" varsa kontrolü yapılarak her istekte yönlendirme kontrolü yapılabilir.

        //void Session_Start(object sender, EventArgs e)
        //{
        //    var path = Request.Url.AbsolutePath;
        //    if (Request.Browser.IsMobileDevice)
        //    {
        //        Response.Redirect("~/mobile" + path);
        //    }
        //}
    }
}
