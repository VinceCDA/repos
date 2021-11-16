using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestIdentity.Models;

namespace TestIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext<Member,IdentityRole, string>
    {
        //public DbSet<Member> Members { get; set; }
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
            {

            }
        

    }
}
