using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seguros.Falabella.Application.Models
{
    public class CompanyModels
    {
        public int comp_id { get; set; }

        public string comp_nit { get; set; }

        public string comp_name { get; set; }

        public string comp_address { get; set; }

        public string comp_city { get; set; }

        public int comp_phone { get; set; }
    }
}