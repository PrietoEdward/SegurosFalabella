using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seguros.Falabella.Application.Models
{
    public class CustomerModels
    {
        public int cust_id { get; set; }

        public int cust_cc { get; set; }

        public string cust_name { get; set; }

        public string cust_lastName { get; set; }

        public DateTime cust_dateOfBirth { get; set; }

        public string cust_address { get; set; }

        public string cust_city { get; set; }

        public int cust_phone { get; set; }
    }
}