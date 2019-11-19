using SegurosFalabellaDAL;
using SegurosFalabellaEntity;
using System.Collections.Generic;

namespace SegurosFalabellaBL
{
    public class CompanyBL
    {
        private CompanyDAL CompDAL = new CompanyDAL();

        /// <summary>
        /// select
        /// </summary>
        /// <returns></returns>
        public List<Company> SelectCompany()
        {
            List<Company> resultado = new List<Company>();
            var lista = CompDAL.SelectCompany();
            resultado = lista;
            return resultado;
        }

        /// <summary>
        /// select Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Company SelectCompanyId(int id)
        {
            Company resultado = new Company();
            var lista = CompDAL.SelectCompanyId(id);
            resultado = lista;
            return resultado;
        }

        /// <summary>
        /// insert
        /// </summary>
        /// <param name="Obejto"></param>
        public void AddCompany(Company Obejto)
        {
            CompDAL.AddCompany(Obejto);
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="Obejto"></param>
        public void UpdateCompany(Company Obejto)
        {
            CompDAL.UpdateCompany(Obejto);
        }


        /// <summary>
        /// delete
        /// </summary>
        /// <param name="id"></param>
        public void DeleteCompany(int id)
        {
            CompDAL.DeleteCompany(id);
        }
    }
}
