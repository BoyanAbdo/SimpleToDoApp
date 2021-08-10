using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vidly.Models;


namespace Vidly.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        /**
         * Data Sets
         */
        public DbSet<Task> Tasks { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
