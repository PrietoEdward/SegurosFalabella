using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SegurosFalabellaDAL.Connection
{
    public class ConnectionDAL
    {
        public static string ObtenerCadenaConexiondb()
        {
            var value = ConfigurationManager.ConnectionStrings["pruebas"];

            if (value == null)
            {
                throw new Exception("Cadena de conexión a BD no establecida ");
            }

            return value.ToString();
        }
    }
}
