using Expense_tracker.Dtos;
using Expense_tracker.Interface;
using Expense_tracker.Models;

namespace Expense_tracker.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<ResponseDTO<ExpenseCategory>> CreateExpenseCategory(string categoryName)
        {
            try
            {
                ExpenseCategory category = new ExpenseCategory()
                {
                    CategoryName = categoryName,
                    CreatedDate = DateTime.Now,
                };

                var result = await _categoryRepository.CreateCategoryAsync(category);
                if(result != null)
                {
                    return new ResponseDTO<ExpenseCategory>()
                    {
                        Success = true,
                        Message = "Category created successfully",
                        Data = result
                    };
                }

                return new ResponseDTO<ExpenseCategory>()
                {
                    Success = false,
                    Message = "Some error occured while creating the category",
                    Data = null
                };
            }
            catch(Exception ex)
            {
                return new ResponseDTO<ExpenseCategory>
                {
                    Data = null,
                    Success = false,
                    Message = ex.Message, 
                };
            }
        }

        public async Task<ResponseDTO<IEnumerable<ExpenseCategory>>> GetCategoryList()
        {
            var response = new ResponseDTO<IEnumerable<ExpenseCategory>>();
            try
            {
                var result = await _categoryRepository.ListCategories();
                if(result != null)
                {
                    response.Success = true;
                    response.Data = result;
                    response.Message = "Category List";
                }
                else
                {
                    response.Success = false;
                    response.Data = null;
                    response.Message = "No data found";
                }

            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                response.Data = null;
            }
            return response;
        }

        public async Task<ResponseDTO<Category>> ViewCategory(int categoryId)
        {
            var response = new ResponseDTO<Category>(); 
            try
            {
                var result = await _categoryRepository.ViewCategory(categoryId);
                if(result != null)
                {
                    response.Success= true;
                    response.Data = result;
                    response.Message = "Category view";
                }
                else
                {
                    response.Success = false;
                    response.Data = null;
                    response.Message = "Category not found";
                }
            }
            catch (Exception ex)
            {
                response.Success= false;
                response.Data = null;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ResponseDTO<ExpenseCategory>> EditExpenseCategory(int catId,string categoryName)
        {
            var response = new ResponseDTO<ExpenseCategory>();
            try
            {
                var expenseCategory = new ExpenseCategory()
                {
                    CategoryName = categoryName
                };

                var result = await _categoryRepository.EditCategoryAsync(catId, expenseCategory);
                if(result != null)
                {
                    response.Success= true;
                    response.Data = result;
                    response.Message = "Category edited successfully";
                }
                else
                {
                    response.Success = false;
                    response.Data = null;
                    response.Message = "No category found";
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Data = null;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ResponseDTO<bool>> DeleteCategory(int catId)
        {
            var response = new ResponseDTO<bool>();    
            try
            {
                var result = await _categoryRepository.DeleteCategory(catId);
                if(result )
                {
                    response.Success= true;
                    response.Data = result;
                    response.Message = "Category deleted successfully";
                }
                else
                {
                    response.Success = false;
                    response.Data = result;
                    response.Message = "Category delete failed+";
                }
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Data = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
