using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BEEntities
{
    [DataContract]
    public class BEOferta
    {
        [DataMember]
        public long CoOferta { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public DateTime FechaCaducidad { get; set; }
        [DataMember]
        public DateTime FechaInicio { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
    }
}
