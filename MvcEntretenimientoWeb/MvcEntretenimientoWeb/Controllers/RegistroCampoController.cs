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
        private ent_familiarEntities db = new ent_familiarEntities();
        public ActionResult Index()
        {
            
            this.ViewData["ddlservicio"] = new SelectList(db.servicio, "CoServicio", "TxtDescripcion");
            this.ViewData["ddljuego"] = new SelectList(db.juego, "CoJuego", "TxtDescripcion");
            this.ViewData["ddlclub"] = new SelectList(db.club, "CoClub", "NoClub");
            
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

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
