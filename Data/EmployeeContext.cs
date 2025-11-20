using Microsoft.EntityFrameworkCore;
using loginPage.Models;
namespace loginPage.Data{
    public class EmployeeContext :DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options){}
                public DbSet<employee> employee{get;set;}
    }
}