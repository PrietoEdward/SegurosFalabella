using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SegurosFalabellaEntity
{
    [DataContract]
    public class Sale
    {
        [DataMember]
        public int sale_id { get; set; }

        [DataMember]
        public string sale_coverage { get; set; }

        [DataMember]
        public decimal sale_prima { get; set; }

        [DataMember]
        public string sale_assistance { get; set; }

        [DataMember]
        public int prod_id { get; set; }

        [DataMember]
        public string prod_code { get; set; }

        [DataMember]
        public string prod_name { get; set; }

        [DataMember]
        public string prod_features { get; set; }

        [DataMember]
        public int cust_id { get; set; }

        [DataMember]
        public int cust_cc { get; set; }

        [DataMember]
        public string cust_name { get; set; }

        [DataMember]
        public string cust_lastName { get; set; }

        [DataMember]
        public DateTime cust_dateOfBirth { get; set; }

        [DataMember]
        public string cust_address { get; set; }

        [DataMember]
        public string cust_city { get; set; }

        [DataMember]
        public int cust_phone { get; set; }
    }
}
