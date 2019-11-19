using Dapper;
using SegurosFalabellaDAL.Connection;
using SegurosFalabellaEntity;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SegurosFalabellaDAL
{
    public class SaleDAL
    {
        private string CadenaConexion;
        public SaleDAL()
        {
            CadenaConexion = ConnectionDAL.ObtenerCadenaConexiondb();
        }
        /// <summary>
        /// Select 
        /// </summary>
        /// <returns></returns>
        public List<Sale> SelectSale()
        {
            List<Sale> resultado = new List<Sale>();
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                DynamicParameters parameters = new DynamicParameters();

                resultado = conexion.Query<Sale>("[dbo].[SP_GET_SALE]", parameters, commandType: CommandType.StoredProcedure).ToList();

                conexion.Close();
            }

            return resultado;
        }

        /// <summary>
        /// Select Id
        /// </summary>
        /// <param name="sale_id"></param>
        /// <returns></returns>
        public Sale SelectSaleId(int sale_id)
        {
            Sale resultado = new Sale();
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@sale_id", sale_id);
                resultado = conexion.Query<Sale>("[dbo].[SP_GET_SALE_ID]", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();

                conexion.Close();
            }

            return resultado;
        }

        /// <summary>
        /// Select Id
        /// </summary>
        /// <returns></returns>
        public List<Customer> SelectCustomer()
        {
            List<Customer> resultado = new List<Customer>();
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                DynamicParameters parameters = new DynamicParameters();
                resultado = conexion.Query<Customer>("[dbo].[SP_GET_CUSTOMERS]", parameters, commandType: CommandType.StoredProcedure).ToList();

                conexion.Close();
            }

            return resultado;
        }

        /// <summary>
        /// insert sale
        /// </summary>
        /// <param name="Obejto"></param>
        public void AddSale(Sale Obejto)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@sale_coverage", Obejto.sale_coverage);
                parameters.Add("@sale_prima", Obejto.sale_prima);
                parameters.Add("@sale_assistance", Obejto.sale_assistance);
                parameters.Add("@prod_id", Obejto.prod_id);
                parameters.Add("@cust_id", Obejto.cust_id);
                conexion.Execute("[dbo].[SP_INSERT_SALE]", parameters, commandType: CommandType.StoredProcedure);
                conexion.Close();
            }
        }

        /// <summary>
        /// insert sale and customer
        /// </summary>
        /// <param name="Obejto"></param>
        public void AddSaleCustomer(Sale Obejto)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@sale_coverage", Obejto.sale_coverage);
                parameters.Add("@sale_prima", Obejto.sale_prima);
                parameters.Add("@sale_assistance", Obejto.sale_assistance);
                parameters.Add("@prod_id", Obejto.prod_id);
                parameters.Add("@cust_cc", Obejto.cust_cc);
                parameters.Add("@cust_name", Obejto.cust_name);
                parameters.Add("@cust_lastName", Obejto.cust_lastName);
                parameters.Add("@cust_dateOfBirth", Obejto.cust_dateOfBirth);
                parameters.Add("@cust_address", Obejto.cust_address);
                parameters.Add("@cust_city", Obejto.cust_city);
                parameters.Add("@cust_phone", Obejto.cust_phone);
                conexion.Execute("[dbo].[SP_INSERT_SALE_CUSTOMER]", parameters, commandType: CommandType.StoredProcedure);
                conexion.Close();
            }
        }
    }
}
