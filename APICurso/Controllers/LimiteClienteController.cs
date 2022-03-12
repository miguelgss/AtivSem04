using APICurso.Context;
using APICurso.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICurso.Controllers
{
    [Route("api/[controller]")]
    public class LimiteClienteController : ControllerBase
    {
        private readonly CursoContext _context;

        public LimiteClienteController(CursoContext contexto)
        {
            _context = contexto;
        }

        // Retorna todos os LimiteClientes do banco
        [HttpGet]
        public ActionResult<IEnumerable<LimiteCliente>> Get()
        {
            return _context.LimiteClientes.ToList();
        }

        // Retorna o Limite de crédito de um cliente específico de acordo com o Id
        [HttpGet("{id}")]
        public ActionResult<float> Get(int id)
        {
            var cliente = _context.LimiteClientes.FirstOrDefault(x => x.LimiteId == id);
            return cliente.LimiteCredito;
        }

    }
}
