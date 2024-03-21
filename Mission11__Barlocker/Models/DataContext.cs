using Microsoft.EntityFrameworkCore;

namespace Mission11__Barlocker.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base (options)
    { 
    }

    public DbSet<Book> Books { get; set; }
    
}