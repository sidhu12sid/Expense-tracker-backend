using Expense_tracker.Data;
using Expense_tracker.Dtos;
using Expense_tracker.Interface;
using Expense_tracker.Models;
using System.Runtime.CompilerServices;

namespace Expense_tracker.Repositories
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly ExpenseDbContext _dbContext;


        public AuthenticationRepository(ExpenseDbContext dbContext)
        {
            _dbContext = dbContext;
        }



    }
}
