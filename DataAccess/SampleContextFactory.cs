using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public class SampleContextFactory : IDesignTimeDbContextFactory<MakeupDbContext>
    {
        public MakeupDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MakeupDbContext>();

            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfigurationRoot config = builder.Build();

            string? connectionString = config.GetConnectionString("LocalDb");
            optionsBuilder.UseSqlServer(connectionString);
            return new MakeupDbContext(optionsBuilder.Options);
        }
    }
}
