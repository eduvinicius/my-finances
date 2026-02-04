using MyFinances.Domain.Entities;

namespace MyFinances.Infrasctructure.Repositories.Interfaces
{
    public interface ITransactionRepository : IRepository<Transaction>
    {
        Task<IEnumerable<Transaction>> GetAllByUserIdAsync(Guid userId);
    }
}
