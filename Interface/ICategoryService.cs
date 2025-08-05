using Expense_tracker.Dtos;
using Expense_tracker.Models;

namespace Expense_tracker.Interface
{
    public interface ICategoryService
    {
        Task<ResponseDTO<ExpenseCategories>> CreateExpenseCategory(string categoryName);
        Task<ResponseDTO<IEnumerable<ExpenseCategories>>> GetCategoryList();
        Task<ResponseDTO<Category>> ViewCategory(int categoryId);
        Task<ResponseDTO<ExpenseCategories>> EditExpenseCategory(int catId, string categoryName);
        Task<ResponseDTO<bool>> DeleteCategory(int catId);
    }
}
