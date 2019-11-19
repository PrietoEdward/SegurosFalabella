using Dapper;
using SegurosFalabellaDAL.Connection;
using SegurosFalabellaEntity;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SegurosFalabellaDAL
{
    public class ProductDAL
    {
        private string CadenaConexion;
        public ProductDAL()
        {
            CadenaConexion = ConnectionDAL.ObtenerCadenaConexiondb();
        }

        /// <summary>
        /// Select 
        /// </summary>
        /// <returns></returns>
        public List<Product> SelectProduct()
        {
            List<Product> resultado = new List<Product>();
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                DynamicParameters parameters = new DynamicParameters();

                resultado = conexion.Query<Product>("[dbo].[SP_GET_PRODUCT]", parameters, commandType: CommandType.StoredProcedure).ToList();

                conexion.Close();
            }

            return resultado;
        }

        /// <summary>
        /// Select Id
        /// </summary>
        /// <param name="prod_id"></param>
        /// <returns></returns>
        public Product SelectProductId(int prod_id)
        {
            Product resultado = new Product();
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@prod_id", prod_id);
                resultado = conexion.Query<Product>("[dbo].[SP_GET_PRODUCT_ID]", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();

                conexion.Close();
            }

            return resultado;
        }

        /// <summary>
        /// insert
        /// </summary>
        /// <param name="Obejto"></param>
        public void AddProduct(Product Obejto)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@prod_code", Obejto.prod_code);
                parameters.Add("@prod_name", Obejto.prod_name);
                parameters.Add("@prod_features", Obejto.prod_features);
                parameters.Add("@comp_id", Obejto.comp_id);
                conexion.Execute("[dbo].[SP_INSERT_PRODUCT]", parameters, commandType: CommandType.StoredProcedure);
                conexion.Close();
            }
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="Obejto"></param>
        public void UpdateProduct(Product Obejto)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@prod_id", Obejto.prod_id);
                parameters.Add("@prod_code", Obejto.prod_code);
                parameters.Add("@prod_name", Obejto.prod_name);
                parameters.Add("@prod_features", Obejto.prod_features);
                conexion.Execute("[dbo].[SP_UPDATE_PRODUCT]", parameters, commandType: CommandType.StoredProcedure);
                conexion.Close();
            }
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="prod_id"></param>
        public void DeleteProduct(int prod_id)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@prod_id", prod_id);
                conexion.Execute("[dbo].[SP_DELETE_PRODUCT]", parameters, commandType: CommandType.StoredProcedure);
                conexion.Close();
            }
        }
    }
}
