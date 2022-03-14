using APICliente.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICliente.Context
{
    public class VendaContext : DbContext
    {
        public VendaContext(DbContextOptions<VendaContext> options) : base(options) { }
        public VendaContext() { }
        public DbSet<VendasCliente> VendasCliente { get; set; }
        public DbSet<LimiteCliente> LimiteClientes { get; set; }
    }
}
