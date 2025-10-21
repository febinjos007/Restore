using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

// This is how inheritance is done in C#
// Also the () in Class name is the constructor 
public class StoreContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
}
