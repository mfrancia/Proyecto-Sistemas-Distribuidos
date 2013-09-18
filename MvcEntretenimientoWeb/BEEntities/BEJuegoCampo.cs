using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BEEntities
{
    [DataContract]
    public class BEJuegoCampo
    {
        [DataMember]
        public int CoDiaCampo { get; set; }

        [DataMember]
        public int CoResponsable { get; set; }

        [DataMember]
        public int CoServicio { get; set; }

        [DataMember]
        public int CoJuego { get; set; }

        [DataMember]
        public int NuPersonas { get; set; }

        [DataMember]
        public int NuSecuencia { get; set; }

        [DataMember]
        public decimal SsPrecioPersona { get; set; }

        [DataMember]
        public decimal SsImporte { get; set; }

        [DataMember]
        public string TxtComentario { get; set; }

        [DataMember]
        public string NameJuego { get; set; }
    }
}
