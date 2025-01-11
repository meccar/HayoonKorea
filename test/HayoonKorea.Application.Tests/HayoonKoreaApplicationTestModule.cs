using Volo.Abp.Modularity;

namespace HayoonKorea;

[DependsOn(
    typeof(HayoonKoreaApplicationModule),
    typeof(HayoonKoreaDomainTestModule)
)]
public class HayoonKoreaApplicationTestModule : AbpModule
{

}
