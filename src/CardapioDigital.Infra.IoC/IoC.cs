using CardapioDigital.Application.Dto.Request;
using CardapioDigital.Application.Dto.Response;
using CardapioDigital.Application.Mappings;
using CardapioDigital.Application.Services;
using CardapioDigital.Application.Services.IServices;
using CardapioDigital.Domain.Interface;
using CardapioDigital.Domain.Models;
using CardapioDigital.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CardapioDigital.Infra.IoC;

internal static class IoC
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IGenericoServices<CategoriaRequestDto, CategoriaResponseDto>, CategoriaService>();
        services.AddScoped<IGenericoServices<ProdutoRequestDto, ProdutoResponseDto>, ProdutoService>();
        services.AddScoped<IGenericoServices<RestauranteRequestDto, RestauranteResponseDto>, RestauranteService>();
        services.AddScoped<IProdutoService, ProdutoService>();

        services.AddScoped<IGenericoRepositorio<Categoria>, CategoriaRepository>();
        services.AddScoped<IGenericoRepositorio<Produto>, ProdutoRepository>();
        services.AddScoped<IGenericoRepositorio<Restaurante>, RestauranteRepository>();
        services.AddScoped<IProdutoRepository, ProdutoRepository>();

        services.AddAutoMapper(typeof(MapConfig));

        return services;
    }
}
