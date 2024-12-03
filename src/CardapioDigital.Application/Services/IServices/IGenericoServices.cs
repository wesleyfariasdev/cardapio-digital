namespace CardapioDigital.Application.Services.IServices;

public interface IGenericoServices<TResquest, TResponse>
{
    Task<IEnumerable<TResponse>> GetAll();
    Task<TResponse> GetById(int id);
    Task<TResponse> Update(TResquest entity);
    Task<TResponse> Create(TResquest entity);
    Task<bool> DeleteById(int id);
}
