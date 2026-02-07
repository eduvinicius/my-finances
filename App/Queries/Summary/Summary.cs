using Microsoft.EntityFrameworkCore;
using MyFinances.Api.DTOs;
using MyFinances.App.Queries.Summary.Interfaces;
using MyFinances.App.Services.Interfaces;
using MyFinances.Domain.Enums;
using MyFinances.Infrasctructure.Data;

namespace MyFinances.App.Queries.Summary
{
    public class SummaryQuery(
        FinanceDbContext context,
        ICurrentUserService currentUserService
        ) : ISummaryQuery
    {
        private readonly FinanceDbContext _context = context;
        private readonly ICurrentUserService _currentUserService = currentUserService;

        public async Task<SummaryDto> GetAllSummariesAsync()
        {
            var userId = _currentUserService.UserId;

            var accountBalances = await _context.Accounts
                .Where(t => t.UserId == userId)
                .Select(a => new AccountSummaryDto
                {
                    AccountId = a.Id,
                    Name = a.Name,
                    Type = (TransactionType)a.Type,
                    Balance = a.Balance
                })
                .ToListAsync();

            return new SummaryDto
            {
                TotalBalance = accountBalances.Sum(a => a.Balance),
                Accounts = accountBalances
            };
        }
    }
}
