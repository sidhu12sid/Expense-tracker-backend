using Microsoft.Extensions.Hosting;

namespace Expense_tracker.Models
{
    public class Expense
    {
        public int ID { get; set; } 
        public string? DESCRIPTION { get; set; }
        public decimal AMOUNT { get; set; } 
        public DateTime DATE { get; set; }
        public string? CATEGORY { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
    }


    public class ExpenseCategories
    {
        public int ID { get; set; }
        public string? CATEGORY_NAME { get; set; }
        public DateTime? CREATED_DATE { get; set; }
    }
}
