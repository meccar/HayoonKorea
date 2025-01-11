using HayoonKorea.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace HayoonKorea.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(HayoonKoreaEntityFrameworkCoreModule),
    typeof(HayoonKoreaApplicationContractsModule)
)]
public class HayoonKoreaDbMigratorModule : AbpModule
{
}
