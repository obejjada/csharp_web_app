using Microsoft.EntityFrameworkCore;

namespace csharp_web_app.Models;

public class CoffeeBeansDbContext : DbContext
{
    public DbSet<CoffeeBeans> CoffeeBeans { get; set; }

    public CoffeeBeansDbContext(DbContextOptions<CoffeeBeansDbContext> options) : base(options)
    {
        
    }
        
}