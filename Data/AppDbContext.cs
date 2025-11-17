using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using loginPage.Models;

namespace loginPage.Data
{
    public class AppDbContext :IdentityDbContext<Users>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
    }
}