using System.ComponentModel.DataAnnotations;
namespace loginPage.ViewModels
{
    public class EditViewModel{
        [Required]
        public string Name{get; set;}
        [Required]
        public string Address{get; set;}
        [EmailAddress]
        public string Email{get; set;}

    }
}