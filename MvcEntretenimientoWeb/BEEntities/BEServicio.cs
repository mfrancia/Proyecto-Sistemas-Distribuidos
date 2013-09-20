using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BEEntities
{

    [DataContract]
    public class BEServicio
    {

        [DataMember]
        public int CoServicio { get; set; }

        [DataMember]
        public string TxtDescripcion { get; set; }
    }
}
