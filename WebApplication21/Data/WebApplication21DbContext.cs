using Microsoft.EntityFrameworkCore;
using WebApplication21.Models;

namespace WebApplication21.Data
{
    public class WebApplication21DbContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }

        public DbSet<Estudiante> Estudiantes { get; set; }

        public WebApplication21DbContext(DbContextOptions<WebApplication21DbContext> options): base(options)
        {

        }
    }
}
