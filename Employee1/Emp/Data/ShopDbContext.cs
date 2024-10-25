
using Microsoft.EntityFrameworkCore;

namespace Emp.Data;

public class ShopDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=iitdac.met.edu;Database=Shop4;User Id=dac4;Password=Dac4@1234;Encrypt=False");
    }
}