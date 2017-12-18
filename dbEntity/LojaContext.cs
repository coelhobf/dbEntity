using Microsoft.EntityFrameworkCore;
using System;

namespace dbEntity
{
    internal class LojaContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=LojaDB; Trusted_Connection=true;");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<PromocaoProduto>()
                .HasKey(pp => new { pp.IdProduto, pp.IdPromocao });
            base.OnModelCreating(modelBuilder);
        }
    }
}