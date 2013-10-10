using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcEntretenimiento.Controllers
{
    public class OfertasController : Controller
    {
        //
        // GET: /Ofertas/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetOfertas()
        {
            localhost.ServiceEntretenimiento service = new localhost.ServiceEntretenimiento();
            var oferta = service.ReceiveOferta();
            return Json(oferta, JsonRequestBehavior.AllowGet);
        }

    }
}
