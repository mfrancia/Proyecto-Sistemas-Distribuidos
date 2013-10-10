using BEEntities;
using DAEntretenimiento;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Messaging;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;


namespace WCFConsole
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.

    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServiceEntretenimiento
    {
      UnityContainer container = new UnityContainer();
      [OperationContract]
      [WebInvoke(Method="POST",UriTemplate = "/Service/RegistrarCabeceraCampo",
             RequestFormat = WebMessageFormat.Json, ResponseFormat=WebMessageFormat.Json)]
        public int RegistrarCabeceraCampo(BESolicitudCampo besolicitudcampo)
        {
            container.RegisterType<IDASolicitudCampo, DASolicitudCompra>();
            IDASolicitudCampo dacampo = container.Resolve<IDASolicitudCampo>();
            
            return dacampo.RegistrarSolicitudCampo(besolicitudcampo);
        }

      [OperationContract]
      [WebInvoke(Method = "POST", UriTemplate = "/Service/RegistrarServicioCampo",
             RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
      public void RegistrarServicioCampo(List<BEServicioCampo> listbeserviciocampo)
      {
          container.RegisterType<IDASolicitudCampo, DASolicitudCompra>();
          IDASolicitudCampo dacampo = container.Resolve<IDASolicitudCampo>();

          dacampo.RegistrarServicioJuegoCampo(listbeserviciocampo);
      }

      [OperationContract]
      public List<BEClub> LeerClubs()
      {
          container.RegisterType<IDAMaestros, DAMaestros>();
          IDAMaestros dacampo = container.Resolve<IDAMaestros>();

          return dacampo.LeerClubs();
      }

      [OperationContract]
      public List<BEJuego> LeerJuegos()
      {
          container.RegisterType<IDAMaestros, DAMaestros>();
          IDAMaestros dacampo = container.Resolve<IDAMaestros>();

          return dacampo.LeerJuegos();
      }

      [OperationContract]
      public List<BEServicio> LeerServicios()
      {
          container.RegisterType<IDAMaestros, DAMaestros>();
          IDAMaestros dacampo = container.Resolve<IDAMaestros>();

          return dacampo.LeerServicios();
      }
      
      [OperationContract]
      public List<BEOferta> ReceiveOferta()
      {
          container.RegisterType<IDAMaestros, DAMaestros>();
          IDAMaestros damaestro = container.Resolve<IDAMaestros>();
          try
          {
              string path = @".\private$\mfrancia";
              if (!MessageQueue.Exists(path))
              {
                  MessageQueue.Create(path);
              }
              MessageQueue cola = new MessageQueue(path);
              cola.Formatter = new XmlMessageFormatter(new Type[] { typeof(BEOferta) });
              Message mensaje = cola.Receive(new TimeSpan(0,0,0,5));
              BEOferta oferta = (BEOferta)mensaje.Body;
              BEOferta ofertaBD = new BEOferta();
             
              if (oferta != null)
              {
                  ofertaBD = damaestro.RegistrarOferta(oferta);
              }

          }
          catch (Exception ex)
          {
              return damaestro.LeerOfertas();
              
          }
         
          return damaestro.LeerOfertas();
      }

    }
}
