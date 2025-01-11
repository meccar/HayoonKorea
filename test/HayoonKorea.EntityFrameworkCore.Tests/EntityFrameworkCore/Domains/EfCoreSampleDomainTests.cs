using HayoonKorea.Samples;
using Xunit;

namespace HayoonKorea.EntityFrameworkCore.Domains;

[Collection(HayoonKoreaTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<HayoonKoreaEntityFrameworkCoreTestModule>
{

}
