using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecta.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/Index

        public ActionResult Index()
        {
            return View();
        }

        // GET: /Home/AcercaDe

        public ActionResult AcercaDe()
        {
            return View();
        }

    }
}
