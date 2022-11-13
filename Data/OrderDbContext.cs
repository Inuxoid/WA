using Microsoft.EntityFrameworkCore;
using WA.Models;

namespace WA.Data;

public class OrderDbContext : DbContext
{
    public OrderDbContext(DbContextOptions<OrderDbContext> options)
        : base(options)
    {
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
    public DbSet<OrderModel> Orders { get; set; }
}