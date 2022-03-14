using APICurso.Context;
using APICurso.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet("Cliente/{id}")]
        public ActionResult<LimiteCliente> GetCliente(int id)
        {
            return _context.LimiteClientes.FirstOrDefault(x => x.LimiteId == id);
        }

        // Retorna o Limite de crédito de um cliente específico de acordo com o Id
        [HttpGet("Limite/{id}")]
        public ActionResult<float> Get(int id)
        {

            var cliente = _context.LimiteClientes.FirstOrDefault(x => x.LimiteId == id);
            if (cliente == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Erro ao tentar obter os dados. Tente outro Id que seja válido.");
            }

            return cliente.LimiteCredito;
        }

        // Decrementa o Limite de crédito do cliente com um valor especificado
        [HttpPatch("Limite/{id}/Decrementa/{valor}")]
        public ActionResult<LimiteCliente> DecrementaCredito(int id,float valor)
        {
            var cliente = _context.LimiteClientes.FirstOrDefault(x => x.LimiteId == id);

            if (cliente == null)
            {
                return NotFound();
            }

            if (cliente.LimiteCredito < valor)
            {
                return BadRequest();
            }
            cliente.LimiteCredito -= valor;

            _context.Entry(cliente).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok();
        }
    }
}
