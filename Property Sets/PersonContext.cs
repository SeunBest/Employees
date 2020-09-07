using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace Property_Sets
{
    public class PersonContext : DbContext
    {
        public static readonly LoggerFactory MyLogger
            = new LoggerFactory(new[]
            {
                new ConsoleLoggerProvider((category, level)
                    => category == DbLoggerCategory.Database.Command.Name
                && level == LogLevel.Information, true)
            });
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(MyLogger)
                .UseSqlServer(@"Server=.\MSSQLSERVER07;Database=DecagonDB;Trusted_Connection=True;");
        }
    }
}
