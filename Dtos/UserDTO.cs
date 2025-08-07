namespace Expense_tracker.Dtos
{
    using System.ComponentModel.DataAnnotations;

    public class UserCreateDTO
    {
        [Required(ErrorMessage = "First name is required")]
        [MaxLength(50, ErrorMessage = "First name can't exceed 50 characters")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [MaxLength(50, ErrorMessage = "Last name can't exceed 50 characters")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [MaxLength(30, ErrorMessage = "Username can't exceed 30 characters")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address format")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }

}
