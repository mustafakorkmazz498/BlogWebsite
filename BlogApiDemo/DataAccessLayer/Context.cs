using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MUSTAFA\\MSSQLSERVER01; database=CoreBlogApiDb; TrustServerCertificate=True;" +
                " integrated security=true;");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
