using Volo.Abp.Modularity;

namespace HayoonKorea;

/* Inherit from this class for your domain layer tests. */
public abstract class HayoonKoreaDomainTestBase<TStartupModule> : HayoonKoreaTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
