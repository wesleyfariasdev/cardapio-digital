namespace CardapioDigital.Domain.Interface;

public interface IGenericoRepositorio<T>
{
    Task<IEnumerable<T>> GetAll();
    Task<T> GetById(int id);
    Task<T> Update(T entity);
    Task<T> Create(T entity);
    Task<bool> DeleteById(int id);
}
