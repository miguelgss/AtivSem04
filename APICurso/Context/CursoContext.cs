using APICurso.Models;
using Microsoft.EntityFrameworkCore;

namespace APICurso.Context
{
    public class CursoContext : DbContext
    {
        public CursoContext(DbContextOptions<CursoContext> options) : base(options) { }

        public CursoContext() { }
        public DbSet<LimiteCliente> LimiteClientes { get; set; }
    }
}
