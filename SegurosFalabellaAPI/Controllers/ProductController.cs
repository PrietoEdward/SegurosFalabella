﻿using SegurosFalabellaBL;
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
    public class ProductController : ApiController
    {
        private ProductBL ProdBL = new ProductBL();
        // GET: api/Product
        public List<Product> Get()
        {
            List<Product> respuesta = new List<Product>();
            try
            {
                respuesta = ProdBL.SelectProduct();
                return respuesta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        // GET: api/Product/5
        public Product Get(int id)
        {
            Product respuesta = new Product();
            try
            {
                respuesta = ProdBL.SelectProductId(id);
                return respuesta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        // POST: api/Product
        public void Post(Product Objeto)
        {
            try
            {
                ProdBL.AddProduct(Objeto);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        // PUT: api/Product/5
        public void Put(int id, Product Objeto)
        {
            try
            {
                ProdBL.UpdateProduct(Objeto);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
            try
            {
                ProdBL.DeleteProduct(id);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
