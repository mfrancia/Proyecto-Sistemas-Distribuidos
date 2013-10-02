using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MvcEntretenimientoWeb.Motor;
using System.Data;

namespace MvcEntretenimientoWeb.Cotizador
{
    public partial class Cotizador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServicioMotorCalculoService objServicio = new ServicioMotorCalculoService();

            try
            {

             string sCodCampo =  Request.QueryString["CodCampo"].ToString();
             string sCodResponsable = Request.QueryString["CoResponsable"].ToString();

             var Cotizacion = objServicio.getCotizacion(sCodCampo, sCodResponsable);

                var objCotizacion = Cotizacion[0];

                //Cargamos Datos Afiliado
                lblAfiliado.Text = objCotizacion.afiliado.ToString();
                lblDNI.Text = objCotizacion.dni.ToString();

                //Cargamos datos de la solicitud
                lblAfiliado2.Text = objCotizacion.nombres;
                lblPaterno.Text = objCotizacion.apellidoPaterno;
                lblMaterno.Text = objCotizacion.apellidoMaterno;
                lblFechaSolicitud.Text = objCotizacion.fechaSolicitud;
                lblFechaRecepcion.Text = objCotizacion.fechaRecepcion;
                lblNumeroOperacion.Text = objCotizacion.nroOperacion; 

                //Cargamos los servicios
                var query =  from a in objCotizacion.AServicios.AsEnumerable()                                    
                                select a;

                System.Nullable<Decimal> totalServicios = (from a in objCotizacion.AServicios.AsEnumerable()
                                                           select Decimal.Parse(a.importe)).Sum();

                lblTotalServicio.Text = totalServicios.ToString();

                gvServicios.DataSource = query.ToList();
                gvServicios.DataBind();
                
                
                //Cargamos los juegos
                var query1 = from a in objCotizacion.AJuegos.AsEnumerable()
                             select a;                

                System.Nullable<Decimal> totalJuegos = (from a in objCotizacion.AJuegos.AsEnumerable()
                                                           select Decimal.Parse(a.importe)).Sum();

                lblTotalJuegos.Text = totalJuegos.ToString();

                gvJuegos.DataSource = query1.ToList(); ;
                gvJuegos.DataBind();


                lblTotalCotizacion.Text = (totalServicios + totalJuegos).ToString();
            }
            catch (Exception ex )
            {
                throw ex;
            }
        }
    }
}