using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{

    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

    }

}