using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SegurosFalabellaEntity;
using SegurosFalabellaBL;

namespace SegurosFalabellaWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SaleWCF" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SaleWCF.svc o SaleWCF.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SaleWCF : ISaleWCF
    {
        private SaleBL SalBL;

        public SaleWCF()
        {
            SalBL = new SaleBL();
        }

        public List<Sale> SelectSale()
        {
            List<Sale> respuesta = new List<Sale>();
            try
            {
                respuesta = SalBL.SelectSale();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            return respuesta;
        }

        public List<Customer> SelectCustomer()
        {
            List<Customer> respuesta = new List<Customer>();
            try
            {
                respuesta = SalBL.SelectCustomer();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            return respuesta;
        }

        public Sale SelectSaleId(int id)
        {
            Sale respuesta = new Sale();
            try
            {
                respuesta = SalBL.SelectSaleId(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            return respuesta;
        }

        public void AddSale(Sale Obejto)
        {
            try
            {
                 SalBL.AddSale(Obejto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public void AddSaleCustomer(Sale Obejto)
        {
            try
            {
                SalBL.AddSaleCustomer(Obejto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
