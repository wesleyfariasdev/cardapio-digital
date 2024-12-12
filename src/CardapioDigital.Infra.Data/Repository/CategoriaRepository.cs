using CardapioDigital.Domain.Interface;
using CardapioDigital.Domain.Models;
using CardapioDigital.Infra.Data.CardapioDb;
using Microsoft.EntityFrameworkCore;

namespace CardapioDigital.Infra.Data.Repository;

internal class CategoriaRepository(CardapioDbContext context) : IGenericoRepositorio<Categoria>
{
    public async Task<Categoria> Create(Categoria entity)
    {
        if (entity != null)
        {
            var categoaria = await context.Categorias.AddAsync(entity);
            await context.SaveChangesAsync();
            return categoaria.Entity;
        }

        throw new Exception("Não foi possível atualizar o restaurante.");
    }

    public async Task<bool> DeleteById(int id)
    {
        var categoaria = await context.Categorias.FindAsync(id);
        if (categoaria != null)
            try
            {
                context.Categorias.Remove(categoaria);
                return await context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        return false;
    }

    public async Task<IEnumerable<Categoria>> GetAll()
    {
        return await context.Categorias.ToListAsync();
    }


    public async Task<Categoria> GetById(int id)
    {
        var categoaria = await context.Categorias.SingleOrDefaultAsync(x => x.IdCategoria == id);
        if (categoaria == null)
            throw new Exception($"O {id} não foi encotrado.");

        return categoaria;
    }

    public async Task<Categoria> Update(Categoria entity)
    {
        if (entity != null)
        {
            var categoaria = context.Categorias.Update(entity);
            await context.SaveChangesAsync();
            return categoaria.Entity;
        }

        throw new Exception("Não foi possível atualizar o restaurante.");
    }
}