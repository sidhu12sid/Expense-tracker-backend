using Expense_tracker.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Expense_tracker.Data
{
    public class ExpenseDbContext : DbContext
    {
        public DbSet<Expense> Expense { get; set; }
        public DbSet<ExpenseCategories> Categories { get; set; }

        public ExpenseDbContext(DbContextOptions<ExpenseDbContext> options) : base(options)
        {

        }
    }
}
    

