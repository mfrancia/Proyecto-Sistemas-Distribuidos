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


    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServiceEntretenimiento : IServiceEntretenimiento
    {
      [WebInvoke(Method = "POST", UriTemplate = "Service/RegistrarCabeceraCampo",
            BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json)]
        public void RegistrarCabeceraCampo(BEEntities.BESolicitudCampo besolicitudcampo)
        {
            UnityContainer container = new UnityContainer();
            container.RegisterType<IDASolicitudCampo, DASolicitudCompra>();
            IDASolicitudCampo dacampo = container.Resolve<IDASolicitudCampo>();
            
            dacampo.RegistrarSolicitudCampo(besolicitudcampo);
        }
    }
}
