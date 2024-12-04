using CardapioDigital.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CardapioDigital.Infra.Data.EntityConfig;

internal class RestauranteEntityConfig : IEntityTypeConfiguration<Restaurante>
{
    public void Configure(EntityTypeBuilder<Restaurante> builder)
    {
        builder.HasKey(x => x.IdRestaurante);

        builder.Property(x => x.NomeRestaurante).HasMaxLength(150).IsRequired();
        builder.Property(x => x.ImagemRestaturanteUrl).HasMaxLength(150);
    }
}
