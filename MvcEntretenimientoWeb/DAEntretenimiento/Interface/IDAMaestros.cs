using BEEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAEntretenimiento
{
    public interface IDAMaestros
    {
        List<BEJuego> LeerJuegos();
        List<BEClub> LeerClubs();
        List<BEServicio> LeerServicios();
    }
}
