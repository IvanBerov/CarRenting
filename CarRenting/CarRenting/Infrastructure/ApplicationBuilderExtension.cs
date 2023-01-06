using CarRenting.Data;
using CarRenting.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace CarRenting.Infrastructure
{
    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<CarRentingDbContext>();

            data.Database.Migrate();

            SeedCategoriesData(data);

            return app;
        }

        private static void SeedCategoriesData(CarRentingDbContext data)
        {
            if (data.Categories.Any())
            {
                return;
            }

            data.Categories.AddRange(new[]
            {
                new Category {Name = "Mini"},
                new Category {Name = "Economy"},
                new Category {Name = "Midsize"},
                new Category {Name = "Large"},
                new Category {Name = "SUV"},
                new Category {Name = "Vans"},
                new Category {Name = "Luxuary"}
            });

            data.SaveChanges();
        }
    }
}
