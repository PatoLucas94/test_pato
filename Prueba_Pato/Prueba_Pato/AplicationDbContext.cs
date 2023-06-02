using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Prueba_Pato.Models;

namespace Prueba_Pato
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().Property(b => b.Id).IsRequired();
        }

        public DbSet<Person> Person { get; set; }

    }
}
