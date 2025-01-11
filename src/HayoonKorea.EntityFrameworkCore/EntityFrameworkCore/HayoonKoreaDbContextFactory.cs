using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HayoonKorea.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class HayoonKoreaDbContextFactory : IDesignTimeDbContextFactory<HayoonKoreaDbContext>
{
    public HayoonKoreaDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        HayoonKoreaEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<HayoonKoreaDbContext>()
            .UseMySql(configuration.GetConnectionString("Default"), MySqlServerVersion.LatestSupportedServerVersion);
        
        return new HayoonKoreaDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../HayoonKorea.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
