using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobilYonlendirmeSubfolder.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [MobileRedirectAttribute]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OnlyDesktop()
        {
            return View();
        }

        
    }
}