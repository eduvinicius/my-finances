using Microsoft.EntityFrameworkCore;
using MyFinances.Domain.Entities;
using MyFinances.Infrasctructure.Data;
using MyFinances.Infrasctructure.Repositories.Interfaces;

namespace MyFinances.Infrasctructure.Repositories
{
    public class AccountRepository(FinanceDbContext context) : Repository<Account>(context), IAccountRepository
    {
    }
}
