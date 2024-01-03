using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository
{
    public class AppDbContext : DbContext
    {
        public DbSet<RegularTableClass> LogData { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                connectionString: "server=localhost;port=3306;database=systemdesign;user=root;password=admin;",
                serverVersion: new MySqlServerVersion("8.0.32"),
                o => o.UseMicrosoftJson()
            );
        }
    }
}
