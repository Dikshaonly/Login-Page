using System.ComponentModel.DataAnnotations;

namespace loginPage.ViewModels{
    public class RegisterViewModel{
        [Required(ErrorMessage = "Name is Required!")]
        public string Name{get;set;}

        [Required()]
        public string Email{get;set;}
        public string Password{get;set;}
        public string ConfirmedPassword{get;set;}
    }
}