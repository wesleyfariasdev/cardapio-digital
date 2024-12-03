using CardapioDigital.Domain.Interface;
using CardapioDigital.Domain.Models;
using CardapioDigital.Infra.Data.CardapioDb;
using Microsoft.EntityFrameworkCore;

namespace CardapioDigital.Infra.Data.Repository;

internal class RestauranteRepository(CardapioDbContext context) : IGenericoRepositorio<Restaurante>
{
    public async Task<Restaurante> Create(Restaurante entity)
    {
        if (entity != null)
        {
            var restaurante = await context.Restaurantes.AddAsync(entity);
            await context.SaveChangesAsync();
            return restaurante.Entity;
        }

        throw new Exception("Não foi possível atualizar o restaurante.");
    }

    public async Task<bool> DeleteById(int id)
    {
        var restaurante = await context.Restaurantes.FindAsync(id);
        if (restaurante != null)
        {
            try
            {
                context.Restaurantes.Remove(restaurante);
                return await context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        return false;

    }

    public async Task<IEnumerable<Restaurante>> GetAll() =>
           await context.Restaurantes.ToListAsync();

    public async Task<Restaurante> GetById(int id)
    {
        var restaurante = await context.Restaurantes.SingleOrDefaultAsync(x => x.IdRestaurante == id);
        if (restaurante == null)
            throw new Exception($"O {id} não foi encotrado.");

        return restaurante;
    }

    public async Task<Restaurante> Update(Restaurante entity)
    {
        if (entity != null)
        {
            var restaurante = context.Restaurantes.Update(entity);
            await context.SaveChangesAsync();
            return restaurante.Entity;
        }

        throw new Exception("Não foi possível atualizar o restaurante.");

    }
}
