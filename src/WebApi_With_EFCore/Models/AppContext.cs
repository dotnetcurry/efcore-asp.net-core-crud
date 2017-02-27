using Microsoft.EntityFrameworkCore;
namespace WebApi_With_EFCore.Models
{
    //Install-Package Microsoft.EntityFrameworkCore.Tools –Pre
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions opts):base(opts)
        {
        }
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
