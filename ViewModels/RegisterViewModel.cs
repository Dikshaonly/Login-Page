using System.ComponentModel.DataAnnotations;

namespace loginPage.ViewModels{
    public class RegisterViewModel{
        [Required(ErrorMessage = "Name is Required!")]
        public string Name{get;set;}

        [Required(ErrorMessage = "Email is Required!")]
        [EmailAddress]
        public string Email{get;set;}

        [Required(ErrorMessage = "Password is Required!")]
        [DataType(DataType.Password)]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.")]
        public string Password{get;set;}

    }
}