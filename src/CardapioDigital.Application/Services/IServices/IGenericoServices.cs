namespace CardapioDigital.Application.Services.IServices;

public interface IGenericoServices<T>
{
    Task<IEnumerable<T>> GetAll();
    Task<T> GetById(int id);
    Task<T> Update(T entity);
    Task<T> Create(T entity);
    Task<bool> DeleteById(int id);
}
