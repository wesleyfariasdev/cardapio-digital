using AutoMapper;
using CardapioDigital.Application.Dto.Request;
using CardapioDigital.Application.Dto.Response;
using CardapioDigital.Domain.Models;

namespace CardapioDigital.Application.Mappings;

internal class MapConfig : Profile
{
    public MapConfig()
    {
        CreateMap<Produto, ProdutoRequestDto>().ReverseMap();
        CreateMap<Produto, ProdutoResponseDto>().ReverseMap();

        CreateMap<Categoria, CategoriaResponseDto>().ReverseMap();
        CreateMap<Categoria, CategoriaResponseDto>().ReverseMap();

        CreateMap<Restaurante, RestauranteResponseDto>().ReverseMap();
        CreateMap<Restaurante, RestauranteResponseDto>().ReverseMap();
    }
}
