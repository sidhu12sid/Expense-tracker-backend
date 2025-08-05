using Expense_tracker.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Expense_tracker.Data
{
    public class ExpenseDbContext : DbContext
    {
        public DbSet<Expense> Expense { get; set; }
        public DbSet<ExpenseCategory> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        public ExpenseDbContext(DbContextOptions<ExpenseDbContext> options) : base(options)
        {

        }
    }
}
    

