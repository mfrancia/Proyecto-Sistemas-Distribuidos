using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BEEntities
{
   
    [DataContract]
    public class BEClub
    {

         [DataMember]
         public int CoClub { get; set; }

         [DataMember]
         public string NoClub { get; set; }
    }
}
