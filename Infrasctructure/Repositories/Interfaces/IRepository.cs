namespace MyFinances.Infrasctructure.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task AddAsync(T entity);

        Task<IEnumerable<T>> GetAllByUserIdAsync(Guid userId);
        Task<T?> GetByIdAsync(Guid id);
        void Update(T entity);
        void Delete(T entity);
        Task SaveChangesAsync();
    }
}
