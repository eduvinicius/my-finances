using MyFinances.Api.DTOs;
using MyFinances.Domain.Entities;
using MyFinances.Domain.Enums;

namespace MyFinances.App.Services.Interfaces
{
    public interface ITransactionService
    {
        Task<Transaction> CreateAsync(TransactionDto dto);

    }
}
