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

        public async Task<ExpenseCategories?> CreateCategoryAsync(ExpenseCategories category)
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

        public async Task<IEnumerable<ExpenseCategories>?> ListCategories()
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
                var result = await _dbContext.Categories.Where(c => c.ID == catId).Select(q => new Category
                {
                    Id = q.ID,
                    Name = q.CATEGORY_NAME
                }).FirstOrDefaultAsync();

                return result;
            }
            catch
            {
                throw; 
            }
        }

        public async Task<ExpenseCategories?> EditCategoryAsync(ExpenseCategories categories, int categoryId)
        {
            try
            {
                var result = await _dbContext.Categories.FirstOrDefaultAsync(c => c.ID == categoryId);
                if(result != null)
                {
                    result.CATEGORY_NAME = categories.CATEGORY_NAME;
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
                var result = await _dbContext.Categories.FirstOrDefaultAsync(c => c.ID == categoryId);
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
