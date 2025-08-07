using Expense_tracker.Dtos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Expense_tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost("register-user")]
        public async Task<IActionResult> CreateUser(UserCreateDTO createUser)
        {
            try
            {
                return Ok(createUser);
            }
            catch(Exception ex)
            {
                return StatusCode(417, ex.Message);
            }
        }
    }
}
