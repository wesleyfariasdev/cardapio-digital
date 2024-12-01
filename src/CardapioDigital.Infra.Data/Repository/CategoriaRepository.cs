using CardapioDigital.Domain.Interface;
using CardapioDigital.Domain.Models;
using CardapioDigital.Infra.Data.CardapioDb;

namespace CardapioDigital.Infra.Data.Repository;

internal class CategoriaRepository(CardapioDbContext context) : IGenericoRepositorio<Categoria>
{
    public Task<Categoria> Create(Categoria entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Categoria>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Categoria> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Categoria> Update(Categoria entity)
    {
        throw new NotImplementedException();
    }
}
