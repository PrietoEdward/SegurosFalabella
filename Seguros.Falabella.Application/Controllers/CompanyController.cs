using Newtonsoft.Json;
using Seguros.Falabella.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Seguros.Falabella.Application.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public async Task<ActionResult> Index()
        {
            List<CompanyModels> model = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53659/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("api/Company");
                if (response.IsSuccessStatusCode)
                {
                    model = await response.Content.ReadAsAsync<List<CompanyModels>>();
                }
            }
            return View(model);
        }

        // GET: Company/Details/5
        public async Task<ActionResult> Details(int id)
        {
            CompanyModels model = new CompanyModels();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53659/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var json = await client.GetStringAsync($"api/Company/{id}");
                //convierto los valores de un json en un modelo
                model = JsonConvert.DeserializeObject<CompanyModels>(json);
            }
            return View(model);
        }

        // GET: Company/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Company/Create
        [HttpPost]
        public async Task<ActionResult> Create(CompanyModels Objeto)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:53659/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.PostAsJsonAsync("api/Company", Objeto);
                    response.EnsureSuccessStatusCode();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Company/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            CompanyModels model = new CompanyModels();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53659/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var json = await client.GetStringAsync($"api/Company/{id}");
                //convierto los valores de un json en un modelo
                model = JsonConvert.DeserializeObject<CompanyModels>(json);

            }
            return View(model);
        }

        // POST: Company/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, CompanyModels Objeto)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:53659/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.PutAsJsonAsync($"api/Company/{id}", Objeto);
                    response.EnsureSuccessStatusCode();
                    // Deserialize the updated product from the response body.
                    //model = await response.Content.ReadAsAsync<AnimalModels>();                    
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Company/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            CompanyModels model = new CompanyModels();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53659/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var json = await client.GetStringAsync($"api/Company/{id}");
                //convierto los valores de un json en un modelo
                model = JsonConvert.DeserializeObject<CompanyModels>(json);
            }
            return View(model);
        }

        // POST: Company/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, CompanyModels Objeto)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:53659/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.DeleteAsync($"api/Company/{id}");
                    response.EnsureSuccessStatusCode();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
