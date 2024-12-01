using CardapioDigital.Domain.Interface;
using CardapioDigital.Domain.Models;
using CardapioDigital.Infra.Data.CardapioDb;

namespace CardapioDigital.Infra.Data.Repository;

internal class ProdutoRepository(CardapioDbContext context) : IGenericoRepositorio<Produto>
{
    public Task<Produto> Create(Produto entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Produto>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Produto> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Produto> Update(Produto entity)
    {
        throw new NotImplementedException();
    }
}
