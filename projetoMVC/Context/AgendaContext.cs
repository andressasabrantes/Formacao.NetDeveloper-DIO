using projetoMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace projetoMVC.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }
        
        public DbSet<Contato> Contatos { get; set; }
    }
}