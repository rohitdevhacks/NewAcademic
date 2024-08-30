using AcademicsWebsiteProject.Models;
using Microsoft.EntityFrameworkCore;

namespace AcademicsWebsiteProject.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> UserInfo { get; set; }
        public DbSet<AddCourse> addCourse { get; set; }
    }
}
