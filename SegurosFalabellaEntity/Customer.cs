using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFalabellaEntity
{
    [DataContract]
    public class Customer
    {
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
