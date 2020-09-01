using System;
using System.Collections.Generic;
using System.Text;
using EFoodIdentity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EFoodIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
              
        }

        public DbSet<Estabelecimento> Estabelecimentos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Estabelecimento>()
                .ToTable("Estabelecimento");

            modelBuilder.Entity<Produto>()
                .ToTable("Produto");

            modelBuilder.Entity<Categoria>()
                .ToTable("Categoria");

            modelBuilder.Entity<ProdutoCategoria>()
                .ToTable("ProdutoCategoria");

            modelBuilder.Entity<ProdutoCategoria>()
                .HasKey(pc => new { pc.ProdutoId, pc.CategoriaId });

            modelBuilder.Entity<ProdutoCategoria>()
                .HasOne(pc => pc.Produto)
                .WithMany(p => p.ProdutoCategorias)
                .HasForeignKey(pc => pc.ProdutoId);

            modelBuilder.Entity<ProdutoCategoria>()
                .HasOne(pc => pc.Categoria)
                .WithMany(c => c.ProdutoCategorias)
                .HasForeignKey(pc => pc.CategoriaId);
        }
    }
}