using CardapioDigital.Domain.Models;

namespace CardapioDigital.Domain.Interface;

internal interface IProdutoRepository
{
    Task<IEnumerable<Produto>> GetProdutosById(int idRestaurante);
}
