using Volo.Abp.Modularity;

namespace HayoonKorea;

public abstract class HayoonKoreaApplicationTestBase<TStartupModule> : HayoonKoreaTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
