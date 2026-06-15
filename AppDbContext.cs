using Microsoft.EntityFrameworkCore;
using ProiectMSOA.Models;

namespace ProiectMSOA
{
    public class AppDbContext : DbContext
    {
        public DbSet<Utilizator> Utilizatori { get; set; }
        public DbSet<Autor> Autori { get; set; }
        public DbSet<Carte> Carti { get; set; }
        public DbSet<Imprumut> Imprumuturi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=biblioteca.db");
        }
    }
}