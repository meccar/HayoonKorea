using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace HayoonKorea.Pages;

[Collection(HayoonKoreaTestConsts.CollectionDefinitionName)]
public class Index_Tests : HayoonKoreaWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
