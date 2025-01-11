using Xunit;

namespace HayoonKorea.EntityFrameworkCore;

[CollectionDefinition(HayoonKoreaTestConsts.CollectionDefinitionName)]
public class HayoonKoreaEntityFrameworkCoreCollection : ICollectionFixture<HayoonKoreaEntityFrameworkCoreFixture>
{

}
