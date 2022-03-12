using APICliente.Context;
using APICliente.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace APICliente.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly VendaContext _context;

        public HomeController(VendaContext contexto)
        {
            _context = contexto;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Vendas = _context.VendasCliente.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Venda()
        {
            var ListaLimites = VendasFuncoes.GetLista();
            ViewBag.Lista = ListaLimites;
            return View();
        }

        [HttpPatch]
        public ActionResult<VendasCliente> Venda(int id, int valor)
        {

            return Ok();
        }

        public IActionResult VendaConcluida()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
