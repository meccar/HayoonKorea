using HayoonKorea.Books;
using Xunit;

namespace HayoonKorea.EntityFrameworkCore.Applications.Books;

[Collection(HayoonKoreaTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<HayoonKoreaEntityFrameworkCoreTestModule>
{

}