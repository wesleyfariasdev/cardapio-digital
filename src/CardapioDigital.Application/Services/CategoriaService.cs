using AutoMapper;
using CardapioDigital.Application.Dto.Request;
using CardapioDigital.Application.Dto.Response;
using CardapioDigital.Application.Services.IServices;
using CardapioDigital.Domain.Interface;
using CardapioDigital.Domain.Models;

namespace CardapioDigital.Application.Services;
internal class CategoriaService(IGenericoRepositorio<Categoria> _categoriaRepository, IMapper _mapper)
               : IGenericoServices<CategoriaRequestDto, CategoriaResponseDto>
{
    public async Task<CategoriaResponseDto> Create(CategoriaRequestDto entity)
    {
        var convertToMapper = _mapper.Map<Categoria>(entity);
        var produto = await _categoriaRepository.Create(convertToMapper);
        return _mapper.Map<CategoriaResponseDto>(produto);
    }

    public async Task<bool> DeleteById(int id) =>
           await _categoriaRepository.DeleteById(id);

    public async Task<IEnumerable<CategoriaResponseDto>> GetAll()
    {
        var categorias = await _categoriaRepository.GetAll();
        return _mapper.Map<IEnumerable<CategoriaResponseDto>>(categorias);
    }

    public async Task<CategoriaResponseDto> GetById(int id)
    {
        var categoria = await _categoriaRepository.GetById(id);
        return _mapper.Map<CategoriaResponseDto>(categoria);
    }

    public async Task<CategoriaResponseDto> Update(CategoriaRequestDto entity)
    {
        var convertToMapper = _mapper.Map<Categoria>(entity);
        var categoria = await _categoriaRepository.Update(convertToMapper);
        return _mapper.Map<CategoriaResponseDto>(categoria);
    }
}
