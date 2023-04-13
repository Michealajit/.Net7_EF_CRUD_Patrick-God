global using Microsoft.EntityFrameworkCore;

namespace FormulaApi.Data;
using FormulaApi.Models;

public class DataContext: DbContext
{

public DataContext(DbContextOptions<DataContext> options): base(options)
{
    
}


protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    base.OnConfiguring(optionsBuilder);
    optionsBuilder.UseNpgsql("Host=localhost; Database=Testing; Username=micheal; Password=micheal");
}

        public DbSet<Driver> Drivers { get; set;}

}