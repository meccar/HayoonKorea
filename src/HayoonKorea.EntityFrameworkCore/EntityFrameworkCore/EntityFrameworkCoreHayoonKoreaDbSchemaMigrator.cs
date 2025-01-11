using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HayoonKorea.Data;
using Volo.Abp.DependencyInjection;

namespace HayoonKorea.EntityFrameworkCore;

public class EntityFrameworkCoreHayoonKoreaDbSchemaMigrator
    : IHayoonKoreaDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreHayoonKoreaDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the HayoonKoreaDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<HayoonKoreaDbContext>()
            .Database
            .MigrateAsync();
    }
}
