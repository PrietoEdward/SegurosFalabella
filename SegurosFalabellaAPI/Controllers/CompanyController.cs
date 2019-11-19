using SegurosFalabellaDAL;
using SegurosFalabellaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SegurosFalabellaAPI.Controllers
{
    public class CompanyController : ApiController
    {
        private CompanyDAL CompDAL = new CompanyDAL();

        // GET: api/Company
        public List<Company> Get()
        {
            List<Company> respuesta = new List<Company>();
            try
            {
                respuesta = CompDAL.SelectCompany();
                return respuesta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        // GET: api/Company/5
        public Company Get(int id)
        {
            Company respuesta = new Company();
            try
            {
                respuesta = CompDAL.SelectCompanyId(id);
                return respuesta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        // POST: api/Company
        public void Post(Company Objeto)
        {
            try
            {
                CompDAL.AddCompany(Objeto);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        // PUT: api/Company/5
        public void Put(int id, Company Objeto)
        {
            try
            {
                CompDAL.UpdateCompany(Objeto);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        // DELETE: api/Company/5
        public void Delete(int id)
        {
            try
            {
                CompDAL.DeleteCompany(id);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
