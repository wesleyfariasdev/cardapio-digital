using CardapioDigital.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CardapioDigital.Infra.Data.EntityConfig;

internal class ProdutoEntityConfig : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.HasKey(x => x.IdProduto);

        builder.Property(x => x.NomeProduto).HasMaxLength(150).IsRequired();
        builder.Property(x => x.DescricaoProduto).HasMaxLength(500).IsRequired();
        builder.Property(x => x.ProdutoImagemUrl).HasMaxLength(150);
        builder.Property(x => x.IsPublico).HasDefaultValue(true);
        builder.Property(x => x.Preco);
        builder.Property(x => x.PrecoComDesconto);

        builder.HasOne(p => p.Restaurante)
        .WithMany(r => r.Produtos)
        .HasForeignKey(p => p.RestauranteId)
        .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(p => p.Categoria)
           .WithMany(c => c.Produtos)
           .HasForeignKey(p => p.CategoriaId)
           .OnDelete(DeleteBehavior.Restrict);
    }
}
