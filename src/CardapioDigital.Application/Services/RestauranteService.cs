using AutoMapper;
using CardapioDigital.Application.Dto.Request;
using CardapioDigital.Application.Dto.Response;
using CardapioDigital.Application.Services.IServices;
using CardapioDigital.Domain.Interface;
using CardapioDigital.Domain.Models;

namespace CardapioDigital.Application.Services;

internal class RestauranteService(IGenericoRepositorio<Restaurante> _restauranteRepository, IMapper _mapper)
             : IGenericoServices<RestauranteRequestDto, RestauranteResponseDto>
{
    public async Task<RestauranteResponseDto> Create(RestauranteRequestDto entity)
    {
        var convertToMapper = _mapper.Map<Restaurante>(entity);
        var restaurante = await _restauranteRepository.Create(convertToMapper);
        return _mapper.Map<RestauranteResponseDto>(restaurante);
    }

    public async Task<bool> DeleteById(int id) =>
           await _restauranteRepository.DeleteById(id);

    public async Task<IEnumerable<RestauranteResponseDto>> GetAll()
    {
        var restaurantes = await _restauranteRepository.GetAll();
        return _mapper.Map<IEnumerable<RestauranteResponseDto>>(restaurantes);
    }

    public async Task<RestauranteResponseDto> GetById(int id)
    {
        var restaurante = await _restauranteRepository.GetById(id);
        return _mapper.Map<RestauranteResponseDto>(restaurante);
    }

    public async Task<RestauranteResponseDto> Update(RestauranteRequestDto entity)
    {
        var convertToMapper = _mapper.Map<Restaurante>(entity);
        var restaurante = await _restauranteRepository.Update(convertToMapper);
        return _mapper.Map<RestauranteResponseDto>(restaurante);
    }
}
