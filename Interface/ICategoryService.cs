using Expense_tracker.Dtos;
using Expense_tracker.Models;

namespace Expense_tracker.Interface
{
    public interface ICategoryService
    {
        Task<ResponseDTO<ExpenseCategory>> CreateExpenseCategory(string categoryName);
        Task<ResponseDTO<IEnumerable<ExpenseCategory>>> GetCategoryList();
        Task<ResponseDTO<Category>> ViewCategory(int categoryId);
        Task<ResponseDTO<ExpenseCategory>> EditExpenseCategory(int catId, string categoryName);
        Task<ResponseDTO<bool>> DeleteCategory(int catId);
    }
}
