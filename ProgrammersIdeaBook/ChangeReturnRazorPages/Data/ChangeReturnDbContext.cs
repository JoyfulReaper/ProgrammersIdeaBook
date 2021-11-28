using ChangeReturnRazorPages.Models;
using Microsoft.EntityFrameworkCore;

namespace ChangeReturnRazorPages.Data
{
    public class ChangeReturnDbContext : DbContext
    {
        public ChangeReturnDbContext(DbContextOptions<ChangeReturnDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
