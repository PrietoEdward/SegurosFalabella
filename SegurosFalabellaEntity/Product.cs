using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SegurosFalabellaEntity
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int prod_id { get; set; }

        [DataMember]
        public string prod_code { get; set; }

        [DataMember]
        public string prod_name { get; set; }

        [DataMember]
        public string prod_features { get; set; }

        [DataMember]
        public int comp_id { get; set; }

        [DataMember]
        public string comp_name { get; set; }
    }
}
