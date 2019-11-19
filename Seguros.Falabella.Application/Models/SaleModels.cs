using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seguros.Falabella.Application.Models
{
    public class SaleModels
    {
        public int sale_id { get; set; }

        public string sale_coverage { get; set; }

        public decimal sale_prima { get; set; }

        public string sale_assistance { get; set; }

        public int prod_id { get; set; }

        public string prod_code { get; set; }

        public string prod_name { get; set; }

        public string prod_features { get; set; }

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