using CardapioDigital.Domain.Interface;
using CardapioDigital.Domain.Models;
using CardapioDigital.Infra.Data.CardapioDb;

namespace CardapioDigital.Infra.Data.Repository;

internal class RestauranteRepository(CardapioDbContext context) : IGenericoRepositorio<Restaurante>
{
    public Task<Restaurante> Create(Restaurante entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Restaurante>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Restaurante> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Restaurante> Update(Restaurante entity)
    {
        throw new NotImplementedException();
    }
}
