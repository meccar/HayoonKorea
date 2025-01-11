using HayoonKorea.Samples;
using Xunit;

namespace HayoonKorea.EntityFrameworkCore.Applications;

[Collection(HayoonKoreaTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<HayoonKoreaEntityFrameworkCoreTestModule>
{

}
