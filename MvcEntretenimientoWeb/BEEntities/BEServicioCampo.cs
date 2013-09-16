using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BEEntities
{
    [DataContract]
    
    public class BESolicitudCampo
    {
        [DataMember]
        public int CoResponsable { get; set; }

        [DataMember]
        public DateTime FeDiaCampo { get; set; }

        [DataMember]
        public int NuTotalPersonas { get; set; }


        [DataMember]
        public int CoClub { get; set; }
    }
}
