using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobilYonlendirmeSubfolder.Areas.Mobile.Controllers
{
    public class HomeController : Controller
    {
        // GET: Mobile/Home
        [DesktopRedirectAttribute]
        public ActionResult Index()
        {
            return View();
        }


    }
}