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
            ServiceReference1.ServiceEntretenimientoClient service = new ServiceReference1.ServiceEntretenimientoClient();

            this.ViewData["ddlservicio"] = new SelectList(service.LeerServicios(), "CoServicio", "TxtDescripcion");
            this.ViewData["ddljuego"] = new SelectList(service.LeerJuegos(), "CoJuego", "TxtDescripcion");
            this.ViewData["ddlclub"] = new SelectList(service.LeerClubs(), "CoClub", "NoClub");
            
            return View();
        }

        public ActionResult RegistrarCampo()
        {
            
            return View();
        }

        
        protected override void Dispose(bool disposing)
        {
           
            base.Dispose(disposing);
        }
    }
}
