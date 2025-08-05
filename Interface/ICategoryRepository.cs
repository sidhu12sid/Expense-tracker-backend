using Expense_tracker.Dtos;
using Expense_tracker.Models;

namespace Expense_tracker.Interface
{
    public interface ICategoryRepository
    {
        Task<ExpenseCategories?> CreateCategoryAsync(ExpenseCategories category);

        Task<IEnumerable<ExpenseCategories>?> ListCategories();

        Task<Category?> ViewCategory(int catId);

        Task<ExpenseCategories?> EditCategoryAsync(ExpenseCategories categories, int categoryId);

        Task<bool> DeleteCategory(int categoryId);
    }
}
