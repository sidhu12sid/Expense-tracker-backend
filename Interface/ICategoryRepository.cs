using Expense_tracker.Dtos;
using Expense_tracker.Models;

namespace Expense_tracker.Interface
{
    public interface ICategoryRepository
    {
        Task<ExpenseCategory?> CreateCategoryAsync(ExpenseCategory category);

        Task<IEnumerable<ExpenseCategory>?> ListCategories();

        Task<Category?> ViewCategory(int catId);

        Task<ExpenseCategory?> EditCategoryAsync(int categoryId, ExpenseCategory categories);

        Task<bool> DeleteCategory(int categoryId);
    }
}
