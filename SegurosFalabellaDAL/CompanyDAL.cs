using Dapper;
using SegurosFalabellaDAL.Connection;
using SegurosFalabellaEntity;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SegurosFalabellaDAL
{
    public class CompanyDAL
    {
        private string CadenaConexion;
        public CompanyDAL()
        {
            CadenaConexion = ConnectionDAL.ObtenerCadenaConexiondb();
        }

        /// <summary>
        /// Select 
        /// </summary>
        /// <returns></returns>
        public List<Company> SelectCompany()
        {
            List<Company> resultado = new List<Company>();
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                DynamicParameters parameters = new DynamicParameters();

                resultado = conexion.Query<Company>("[dbo].[SP_GET_COMPANY]", parameters, commandType: CommandType.StoredProcedure).ToList();

                conexion.Close();
            }

            return resultado;
        }

        /// <summary>
        /// Select Id
        /// </summary>
        /// <param name="comp_id"></param>
        /// <returns></returns>
        public Company SelectCompanyId(int comp_id)
        {
            Company resultado = new Company();
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@comp_id", comp_id);
                resultado = conexion.Query<Company>("[dbo].[SP_GET_COMPANY_ID]", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();

                conexion.Close();
            }

            return resultado;
        }

        /// <summary>
        /// insert
        /// </summary>
        /// <param name="Obejto"></param>
        public void AddCompany(Company Obejto)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@comp_nit", Obejto.comp_nit);
                parameters.Add("@comp_name", Obejto.comp_name);
                parameters.Add("@comp_address", Obejto.comp_address);
                parameters.Add("@comp_city", Obejto.comp_city);
                parameters.Add("@comp_phone", Obejto.comp_phone);
                conexion.Execute("[dbo].[SP_INSERT_COMPANY]", parameters, commandType: CommandType.StoredProcedure);
                conexion.Close();
            }
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="Obejto"></param>
        public void UpdateCompany(Company Obejto)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@comp_id", Obejto.comp_id);
                parameters.Add("@comp_address", Obejto.comp_address);
                parameters.Add("@comp_city", Obejto.comp_city);
                parameters.Add("@comp_phone", Obejto.comp_phone);
                conexion.Execute("[dbo].[SP_UPDATE_COMPANY]", parameters, commandType: CommandType.StoredProcedure);
                conexion.Close();
            }
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="comp_id"></param>
        public void DeleteCompany(int comp_id)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@comp_id", comp_id);
                conexion.Execute("[dbo].[SP_DELETE_COMPANY]", parameters, commandType: CommandType.StoredProcedure);
                conexion.Close();
            }
        }
    }
}
