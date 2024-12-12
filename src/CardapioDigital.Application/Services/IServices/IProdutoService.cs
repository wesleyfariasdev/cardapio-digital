using CardapioDigital.Application.Dto.Response;

namespace CardapioDigital.Application.Services.IServices;

internal interface IProdutoService
{
    Task<IEnumerable<ProdutoResponseDto>> GetProdutosById(int idRestaurante);
}