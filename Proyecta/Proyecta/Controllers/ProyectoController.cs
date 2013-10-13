﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecta.Controllers
{
    public class ProyectoController : Controller
    {
        //
        // GET: /Proyecto/
        

        public ActionResult Index(string id = "")
        {
            Models.Proyecto p = new Models.Proyecto();
            return View(p.GetProyecto(new Guid(id)));
        }

        public ActionResult BuscarProyecto()
        {
            return View();
        }

    }
}
