using APICliente.ConnectAPI;
using APICliente.Context;
using APICliente.Models;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Venda()
        {
            var ListaLimites = VendasFuncoes.GetLista();
            ViewBag.Lista = ListaLimites;
            return View();
        }

        [HttpPost("{id}/{valor}")]
        public ActionResult<LimiteCliente> Venda(int id, float valor)
        {
            var ListaLimites = VendasFuncoes.GetLista();
            var Limite = ListaLimites.FirstOrDefault(x => x.LimiteId == id);

            if (Limite == null)
            {
                return NotFound();
            }

            if (valor > Limite.LimiteCredito)
            {
                TempData["Message"] = "O limite de crédito do cliente é menor do que o valor da venda.";
                return BadRequest();
            }
            var Venda = new VendasCliente();

            Venda.LimiteId = id;
            Venda.Venda = valor;
            Venda.DataVenda = System.DateTime.Now;

            Limite.LimiteCredito -= valor;

            _context.VendasCliente.Add(Venda);
            _context.SaveChanges();

            return View();
        }

        [HttpPatch]
        public ActionResult<VendasCliente> VendaProcesso()
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
