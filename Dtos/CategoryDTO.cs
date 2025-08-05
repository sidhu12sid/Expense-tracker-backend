using System.Text.Json.Serialization;

namespace Expense_tracker.Dtos
{
    public class Category
    {
        [JsonPropertyName("ID")]
        public int Id { get; set; }

        [JsonPropertyName("CATEGORY_NAME")]
        public string? Name { get; set; }
    }
}
