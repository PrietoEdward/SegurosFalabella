using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seguros.Falabella.Application.Models
{
    public class ProductModels
    {
        public int prod_id { get; set; }

        public string prod_code { get; set; }

        public string prod_name { get; set; }

        public string prod_features { get; set; }

        public int comp_id { get; set; }

        public string comp_name { get; set; }
    }
}