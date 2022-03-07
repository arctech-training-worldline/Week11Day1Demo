using Microsoft.EntityFrameworkCore;
using Week11Day1Demo.Models;

namespace Week11Day1Demo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
