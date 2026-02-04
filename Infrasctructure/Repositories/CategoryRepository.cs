using Microsoft.EntityFrameworkCore;
using MyFinances.Domain.Entities;
using MyFinances.Infrasctructure.Data;
using MyFinances.Infrasctructure.Repositories.Interfaces;

namespace MyFinances.Infrasctructure.Repositories
{
    public class CategoryRepository(FinanceDbContext context) : Repository<Category>(context), ICategoryRepository
    {
    }
}
