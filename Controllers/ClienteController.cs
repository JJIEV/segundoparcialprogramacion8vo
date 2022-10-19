using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace front.examensegundoparcial.Controllers
{
    public class ClienteController : Controller
    {
        // GET: ClienteController

        public async Task<ActionResult> Index()
        {
            
            List<Models.clienteModel> clientes = new List<Models.clienteModel>();
            
            
            var api = new HttpClient();
            var json = await api.GetStringAsync("https://localhost:7064/cliente/1");


            Models.clienteModel cliente = JsonConvert.DeserializeObject<Models.clienteModel>(json);
            clientes.Add(cliente);
            return View(clientes);
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.clienteModel cliente)
        {
            try
            {
                var json = JsonConvert.SerializeObject(cliente);
                var api = new HttpClient();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
