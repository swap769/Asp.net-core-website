using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using website.Models;

namespace website.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<website.Models.Account.Users> Users { get; set; } = default!;

        public DbSet<website.Models.Course> Courses { get; set; }
        public DbSet<website.Models.Employee> Employees { get; set; } 
        public DbSet<website.Models.Designation> Designation { get; set; } = default!;
        public DbSet<website.Models.Customer> Customer { get; set; } = default!;
        public DbSet<website.Models.Department> Department { get; set; } = default!;
    }
}