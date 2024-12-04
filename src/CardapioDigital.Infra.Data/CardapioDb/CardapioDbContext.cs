using CardapioDigital.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CardapioDigital.Infra.Data.CardapioDb;

internal class CardapioDbContext(DbContextOptions<CardapioDbContext> options) : DbContext(options)
{
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Restaurante> Restaurantes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CardapioDbContext).Assembly);
    }
}
