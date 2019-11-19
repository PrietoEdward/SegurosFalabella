using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace SegurosFalabellaEntity
{
    [DataContract]
    public class Company
    {
        [DataMember]
        public int comp_id { get; set; }
        
        [DataMember]
        public string comp_nit { get; set; }

        [DataMember]
        public string comp_name { get; set; }

        [DataMember]
        public string comp_address { get; set; }

        [DataMember]
        public string comp_city { get; set; }

        [DataMember]
        public int comp_phone { get; set; }
    }
}
