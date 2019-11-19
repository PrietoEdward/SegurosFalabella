using SegurosFalabellaDAL;
using SegurosFalabellaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFalabellaBL
{
    public class SaleBL
    {
        private SaleDAL SalDAL = new SaleDAL();

        /// <summary>
        /// select Sale
        /// </summary>
        /// <returns></returns>
        public List<Sale> SelectSale()
        {
            List<Sale> resultado = new List<Sale>();
            var lista = SalDAL.SelectSale();
            resultado = lista;
            return resultado;
        }

        /// <summary>
        /// select Customer
        /// </summary>
        /// <returns></returns>
        public List<Customer> SelectCustomer()
        {
            List<Customer> resultado = new List<Customer>();
            var lista = SalDAL.SelectCustomer();
            resultado = lista;
            return resultado;
        }

        /// <summary>
        /// select Id
        /// </summary>
        /// <returns></returns>
        public Sale SelectSaleId(int id)
        {
            Sale resultado = new Sale();
            var lista = SalDAL.SelectSaleId(id);
            resultado = lista;
            return resultado;
        }

        /// <summary>
        /// insert sale
        /// </summary>
        /// <param name="Obejto"></param>
        public void AddSale(Sale Obejto)
        {
            SalDAL.AddSale(Obejto);
        }

        /// <summary>
        /// insert sale & customer
        /// </summary>
        /// <param name="Obejto"></param>
        public void AddSaleCustomer(Sale Obejto)
        {
            SalDAL.AddSaleCustomer(Obejto);
        }
    }
}
