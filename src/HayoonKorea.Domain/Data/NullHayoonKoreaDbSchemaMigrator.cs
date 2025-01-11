using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HayoonKorea.Data;

/* This is used if database provider does't define
 * IHayoonKoreaDbSchemaMigrator implementation.
 */
public class NullHayoonKoreaDbSchemaMigrator : IHayoonKoreaDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
