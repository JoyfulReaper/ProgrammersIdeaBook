using ChangeReturnRazorPages.Data;
using ChangeReturnRazorPages.Models;
using Microsoft.EntityFrameworkCore;

namespace ChangeReturnRazorPages
{
    public static class SeedData
    {
        public static void EnsurePopulated(WebApplication app)
        {
            ChangeReturnDbContext context = app.Services
                .CreateScope().ServiceProvider.GetRequiredService<ChangeReturnDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Soda",
                        Price = 1.50m
                    });

                context.SaveChanges();
            }
        }
    }
}
