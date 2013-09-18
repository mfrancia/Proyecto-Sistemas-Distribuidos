using BEEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAEntretenimiento
{
    public interface IDASolicitudCampo
    {
        int RegistrarSolicitudCampo(BESolicitudCampo besolicitudcampo);
        void RegistrarServicioJuegoCampo(List<BEEntities.BEServicioCampo> beserviciocampo);
       
    }
}
