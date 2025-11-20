using System.ComponentModel.DataAnnotations;
namespace loginPage.Models
{
    public class employee{
        [Key]
        public int eid{get;set;}
        public string name{get;set;}
        public string address{get;set;}
        public string email{get;set;}
    }
}