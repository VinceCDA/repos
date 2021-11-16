using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestAuthASPCore.Models;

namespace TestAuthASPCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        DbSet<Member> Members { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}