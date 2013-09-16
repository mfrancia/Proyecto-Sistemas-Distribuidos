using BEEntities;
using DAEntretenimiento;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
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
      [OperationContract]
      [WebInvoke(Method="POST",UriTemplate = "/Service/RegistrarCabeceraCampo",
             RequestFormat = WebMessageFormat.Json, ResponseFormat=WebMessageFormat.Json)]
        public int RegistrarCabeceraCampo(BESolicitudCampo besolicitudcampo)
        {
            UnityContainer container = new UnityContainer();
            container.RegisterType<IDASolicitudCampo, DASolicitudCompra>();
            IDASolicitudCampo dacampo = container.Resolve<IDASolicitudCampo>();
            
            return dacampo.RegistrarSolicitudCampo(besolicitudcampo);
        }

      [OperationContract]
      [WebInvoke(Method = "POST", UriTemplate = "/Service/RegistrarServicioCampo",
             RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
      public void RegistrarServicioCampo(BEServicioCampo beserviciocampo)
      {
          UnityContainer container = new UnityContainer();
          container.RegisterType<IDASolicitudCampo, DASolicitudCompra>();
          IDASolicitudCampo dacampo = container.Resolve<IDASolicitudCampo>();

          dacampo.RegistrarServicioCampo(beserviciocampo);
      }
    }
}
