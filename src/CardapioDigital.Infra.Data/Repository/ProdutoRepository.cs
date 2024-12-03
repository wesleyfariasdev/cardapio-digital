using CardapioDigital.Domain.Interface;
using CardapioDigital.Domain.Models;
using CardapioDigital.Infra.Data.CardapioDb;
using Microsoft.EntityFrameworkCore;

namespace CardapioDigital.Infra.Data.Repository;

internal class ProdutoRepository(CardapioDbContext context) : IGenericoRepositorio<Produto>
{
    public async Task<Produto> Create(Produto entity)
    {
        if (entity != null)
        {
            var produto = await context.Produtos.AddAsync(entity);
            await context.SaveChangesAsync();
            return produto.Entity;
        }

        throw new Exception("Não foi possível atualizar o restaurante.");
    }

    public async Task<bool> DeleteById(int id)
    {
        var produto = await context.Produtos.FindAsync(id);
        if (produto != null)
        {
            try
            {
                context.Produtos.Remove(produto);
                return await context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        return false;

    }

    public async Task<IEnumerable<Produto>> GetAll() =>
           await context.Produtos.ToListAsync();


    public async Task<Produto> GetById(int id)
    {
        var produto = await context.Produtos.SingleOrDefaultAsync(x => x.IdProduto == id);
        if (produto == null)
            throw new Exception($"O {id} não foi encotrado.");

        return produto;
    }

    public async Task<Produto> Update(Produto entity)
    {
        if (entity != null)
        {
            var produto = context.Produtos.Update(entity);
            await context.SaveChangesAsync();
            return produto.Entity;
        }

        throw new Exception("Não foi possível atualizar o restaurante.");

    }
}
