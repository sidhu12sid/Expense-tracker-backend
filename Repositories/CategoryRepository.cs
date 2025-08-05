using Expense_tracker.Data;
using Expense_tracker.Dtos;
using Expense_tracker.Interface;
using Expense_tracker.Models;
using Microsoft.EntityFrameworkCore;

namespace Expense_tracker.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ExpenseDbContext _dbContext;
        public CategoryRepository(ExpenseDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ExpenseCategory?> CreateCategoryAsync(ExpenseCategory category)
        {
            try
            {
                _dbContext.Categories.Add(category);
                var result = await _dbContext.SaveChangesAsync();

                return result > 0 ? category : null;
            }
            catch
            {
                throw;
            }
        }

        public async Task<IEnumerable<ExpenseCategory>?> ListCategories()
        {
            try
            {
                var result = await _dbContext.Categories.ToListAsync();
                return result;
            }
            catch
            {
                throw;
            }
        }

        public async Task<Category?> ViewCategory(int catId)
        {
            try
            {
                var result = await _dbContext.Categories.Where(c => c.Id == catId).Select(q => new Category
                {
                    Id = q.Id,
                    Name = q.CategoryName
                }).FirstOrDefaultAsync();

                return result;
            }
            catch
            {
                throw; 
            }
        }

        public async Task<ExpenseCategory?> EditCategoryAsync(int categoryId,ExpenseCategory categories )
        {
            try
            {
                var result = await _dbContext.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);
                if(result != null)
                {
                    result.CategoryName = categories.CategoryName;
                    await _dbContext.SaveChangesAsync();
                    return result;
                }
                else
                {
                    return null;
                }
               
            }
            catch
            {
                throw;
            }
        }
        

        public async Task<bool> DeleteCategory(int categoryId)
        {
            try
            {
                var result = await _dbContext.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);
                if(result != null)
                {
                    _dbContext.Categories.Remove(result);
                    return await _dbContext.SaveChangesAsync() > 0 ? true : false;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
