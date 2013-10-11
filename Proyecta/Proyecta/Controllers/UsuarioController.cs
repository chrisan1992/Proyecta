using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecta.Controllers
{
    public class UsuarioController : Controller
    {
        //
        // GET: /Usuario/

        public ActionResult Crear()
        {
            ViewBag.Result = "nada";
            return View();
        }

        // POST: /Usuario/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(Proyecta.Models.Usuario us)
        {
            if (ModelState.IsValid)
            {
                
                if (us.CreateUsario(us))
                {
                    ViewBag.Result = ":D";
                }
                else
                {
                    ViewBag.Result = ":(";
                }
            }
            return View(us);
        }

    }
}
