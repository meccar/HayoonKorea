using Volo.Abp.Modularity;

namespace HayoonKorea;

[DependsOn(
    typeof(HayoonKoreaDomainModule),
    typeof(HayoonKoreaTestBaseModule)
)]
public class HayoonKoreaDomainTestModule : AbpModule
{

}
