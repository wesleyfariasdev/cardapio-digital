using CardapioDigital.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CardapioDigital.Infra.Data.EntityConfig;

internal class CategoriaEntityConfig : IEntityTypeConfiguration<Categoria>
{
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        builder.HasKey(x => x.IdCategoria);

        builder.Property(x => x.NomeCategoria).HasMaxLength(150).IsRequired();
        builder.Property(x => x.CategoriaImagemUrl).HasMaxLength(150);
        builder.Property(x => x.IsPublico).HasDefaultValue(true);

        builder.HasOne(x => x.Restaurante)
               .WithMany(x => x.Categorias)
               .HasForeignKey(x => x.RestauranteId);
    }
}
