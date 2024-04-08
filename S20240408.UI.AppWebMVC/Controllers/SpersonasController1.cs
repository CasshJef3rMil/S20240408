using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using S20240408.EntidadesDeNegocio;
using S20240408.LogicaDeNegocio;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace S20240408.UI.AppWebMVC.Controllers
{
    public class ClienteController : Controller
    {
        readonly SpersonaBL _spersonaBL;
        public ClienteController(SpersonaBL spersonaBL)
        {
            _spersonaBL = spersonaBL;
        }
        // GET: ClienteController
        public async Task<ActionResult> Index(SPersona sPersona)
        {
            var clientes = await _spersonaBL.Buscar(sPersona);
            return View(clientes);
        }

        // GET: ClienteController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var cliente = await _spersonaBL.ObtenerPorId(new SPersona { Id = id });
            return View(cliente);
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(SPersona sPersona)
        {
            try
            {
                await _spersonaBL.Crear(sPersona);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var cliente = await _spersonaBL.ObtenerPorId(new SPersona { Id = id });
            return View(cliente);
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(SPersona sPersona)
        {
            try
            {
                await _spersonaBL.Modificar(sPersona);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var cliente = await _spersonaBL.ObtenerPorId(new SPersona { Id = id });
            return View(cliente);
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, SPersona sPersona)
        {
            try
            {
                await _spersonaBL.Eliminar(sPersona);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}