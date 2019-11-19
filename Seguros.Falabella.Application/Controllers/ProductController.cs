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
    public class ProductController : Controller
    {
        // GET: Product
        public async Task<ActionResult> Index()
        {
            List<ProductModels> model = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44371/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("api/Product");
                if (response.IsSuccessStatusCode)
                {
                    model = await response.Content.ReadAsAsync<List<ProductModels>>();
                }
            }
            return View(model);
        }

        // GET: Product/Details/5
        public async Task<ActionResult> Details(int id)
        {
            ProductModels model = new ProductModels();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44371/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var json = await client.GetStringAsync($"api/Product/{id}");
                //convierto los valores de un json en un modelo
                model = JsonConvert.DeserializeObject<ProductModels>(json);
            }
            return View(model);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public async Task<ActionResult> Create(ProductModels Objeto)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44371/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.PostAsJsonAsync("api/Product", Objeto);
                    response.EnsureSuccessStatusCode();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            ProductModels model = new ProductModels();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44371/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var json = await client.GetStringAsync($"api/Product/{id}");
                //convierto los valores de un json en un modelo
                model = JsonConvert.DeserializeObject<ProductModels>(json);

            }
            return View(model);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, ProductModels Objeto)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44371/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.PutAsJsonAsync($"api/Product/{id}", Objeto);
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

        // GET: Product/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            ProductModels model = new ProductModels();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44371/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var json = await client.GetStringAsync($"api/Product/{id}");
                //convierto los valores de un json en un modelo
                model = JsonConvert.DeserializeObject<ProductModels>(json);
            }
            return View(model);
        }

        // POST: Product/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, ProductModels Objeto)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44371/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.DeleteAsync($"api/Product/{id}");
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
