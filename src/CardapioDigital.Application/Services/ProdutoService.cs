using AutoMapper;
using CardapioDigital.Application.Dto.Request;
using CardapioDigital.Application.Dto.Response;
using CardapioDigital.Application.Services.IServices;
using CardapioDigital.Domain.Interface;
using CardapioDigital.Domain.Models;

namespace CardapioDigital.Application.Services;

internal class ProdutoService(IGenericoRepositorio<Produto> _produtoRepository, IMapper _mapper)
               : IGenericoServices<ProdutoRequestDto, ProdutoResponseDto>
{
    public async Task<ProdutoResponseDto> Create(ProdutoRequestDto entity)
    {
        var convertToMapper = _mapper.Map<Produto>(entity);
        var produto = await _produtoRepository.Create(convertToMapper);
        return _mapper.Map<ProdutoResponseDto>(produto);
    }

    public async Task<bool> DeleteById(int id) =>
           await _produtoRepository.DeleteById(id);


    public async Task<IEnumerable<ProdutoResponseDto>> GetAll()
    {
        var produtos = await _produtoRepository.GetAll();
        return _mapper.Map<IEnumerable<ProdutoResponseDto>>(produtos);
    }

    public async Task<ProdutoResponseDto> GetById(int id)
    {
        var produto = await _produtoRepository.GetById(id);
        return _mapper.Map<ProdutoResponseDto>(produto);
    }

    public async Task<ProdutoResponseDto> Update(ProdutoRequestDto entity)
    {
        var convertToMapper = _mapper.Map<Produto>(entity);
        var produto = await _produtoRepository.Update(convertToMapper);
        return _mapper.Map<ProdutoResponseDto>(produto);
    }
}
