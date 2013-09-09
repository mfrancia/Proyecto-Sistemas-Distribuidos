using MvcEntretenimientoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcEntretenimientoWeb.Controllers
{
    public class RegistroCampoController : Controller
    {
        //
        // GET: /RegistroCompra/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegistrarCampo()
        {
            
            return View();
        }

        public JsonResult GetServicios()
        {
            ent_familiarEntities db = new ent_familiarEntities();
            List<servicio> servicio = (from s in db.servicio
                            select s).ToList();

            return Json(servicio);
        }


    }
}
