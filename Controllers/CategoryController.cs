using Expense_tracker.Interface;
using Microsoft.AspNetCore.Mvc;


namespace Expense_tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost("add-category")]
        public async Task<IActionResult> CreateCategory(string? categoryName)
        {
            try
            {
                var result = await _categoryService.CreateExpenseCategory(categoryName ?? "");
                if(result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            catch(Exception ex)
            {
                return StatusCode(417, ex.Message);
            }
        }

        [HttpGet("list-categories")]
        public async Task<IActionResult> ListCategories()
        {
            try
            {
                var result = await _categoryService.GetCategoryList();
                if(result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            catch(Exception ex)
            {
                return StatusCode(417, ex.Message);
            }
        }

        [HttpGet("view-category")]
        public async Task<IActionResult> ViewCategory(int categoryId)
        {
            try
            {
                var result = await _categoryService.ViewCategory(categoryId);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            catch (Exception ex)
            {
                return StatusCode(417, ex.Message);
            }
        }

        [HttpPut("edit-category")]
        public async Task<IActionResult> EditCategory(int categoryId, string? categoryName)
        {
            try
            {
                var result = await _categoryService.EditExpenseCategory(categoryId, categoryName ?? "");
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound(result);
                }
            }
            catch(Exception ex)
            {
                return StatusCode(417, ex.Message);
            }
        }

        [HttpDelete("delete-category")]
        public async Task<IActionResult> DeleteCategory(int categoryId)
        {
            try
            {
                var result = await _categoryService.DeleteCategory(categoryId);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(result);
                }
            }
            catch(Exception ex)
            {
                return StatusCode(417, ex.Message);
            }
        }
    }
}
