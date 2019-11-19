using Seguros.Falabella.Application.Models;
using Seguros.Falabella.Application.ServiceSale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seguros.Falabella.Application.Controllers
{
    public class SaleController : Controller
    {
        private readonly SaleWCFClient SalClient = new SaleWCFClient();

        // GET: Sale
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectCustomer()
        {
            List<Customer> model;
            try
            {
                model = SalClient.SelectCustomer().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            return View(model);
        }

        public ActionResult SelectSale()
        {
            List<Sale> model;
            try
            {
                model = SalClient.SelectSale().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            return View(model);
        }

        public ActionResult SelectSaleId(int id)
        {
            Sale model = new Sale();
            try
            {
                model = SalClient.SelectSaleId(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            return View(model);
        }

        public ActionResult CreateSale()
        {
            return View();
        }

        public ActionResult AddSale(Sale Obejto)
        {
            try
            {
                SalClient.AddSale(Obejto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            return RedirectToAction("Index");
        }

        public ActionResult CreateSaleCustomer()
        {
            return View();
        }

        public ActionResult AddSaleCustomer(Sale Obejto)
        {
            try
            {
                SalClient.AddSaleCustomer(Obejto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            return RedirectToAction("Index");
        }


    }
}
