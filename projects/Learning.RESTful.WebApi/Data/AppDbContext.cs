using Learning.RESTful.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Text.Json;

namespace Learning.RESTful.WebApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TouristRoute> TouristRoutes { get; set; }
        public DbSet<TouristRoutePicture> TouristRoutePictures { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var jsonTouristRoute = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Data/MockData/TouristRoutesMockData.json");
            var touristRoutes = JsonSerializer.Deserialize<List<TouristRoute>>(jsonTouristRoute, jsonSerializerOptions);
            modelBuilder.Entity<TouristRoute>().HasData(touristRoutes);

            var jsonTouristRoutePicture = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Data/MockData/TouristRoutePicturesMockData.json");
            var touristRoutePictures = JsonSerializer.Deserialize<List<TouristRoutePicture>>(jsonTouristRoutePicture, jsonSerializerOptions);
            modelBuilder.Entity<TouristRoutePicture>().HasData(touristRoutePictures);

            base.OnModelCreating(modelBuilder);
        }
    }
}
