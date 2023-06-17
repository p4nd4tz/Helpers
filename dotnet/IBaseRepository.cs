public interface IRepository<T> where T : class
{
    // Task<T> GetByIdAsync(int id);
    // Task<IEnumerable<T>> GetAllAsync();
    Task AddAsync(T entity);
    Task AddRangeAsync(IEnumerable<T> entities);
    Task UpdateAsync(T entity);
    Task UpdateRangeAsync(IEnumerable<T> entities);
    Task DeleteAsync(T entity);
    Task DeleteRangeAsync(IEnumerable<T> entities);
}
