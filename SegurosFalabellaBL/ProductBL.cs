using SegurosFalabellaDAL;
using SegurosFalabellaEntity;
using System.Collections.Generic;

namespace SegurosFalabellaBL
{
    public class ProductBL
    {
        private ProductDAL ProdDAL = new ProductDAL();

        /// <summary>
        /// select
        /// </summary>
        /// <returns></returns>
        public List<Product> SelectProduct()
        {
            List<Product> resultado = new List<Product>();
            var lista = ProdDAL.SelectProduct();
            resultado = lista;
            return resultado;
        }

        /// <summary>
        /// Select Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product SelectProductId(int id)
        {
            Product resultado = new Product();
            var lista = ProdDAL.SelectProductId(id);
            resultado = lista;
            return resultado;
        }

        /// <summary>
        /// insert
        /// </summary>
        /// <param name="Obejto"></param>
        public void AddProduct(Product Obejto)
        {
            ProdDAL.AddProduct(Obejto);
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="Obejto"></param>
        public void UpdateProduct(Product Obejto)
        {
            ProdDAL.UpdateProduct(Obejto);
        }


        /// <summary>
        /// delete
        /// </summary>
        /// <param name="id"></param>
        public void DeleteProduct(int id)
        {
            ProdDAL.DeleteProduct(id);
        }
    }
}
