using Microsoft.AspNetCore.Builder;
using HayoonKorea;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("HayoonKorea.Web.csproj"); 
await builder.RunAbpModuleAsync<HayoonKoreaWebTestModule>(applicationName: "HayoonKorea.Web");

public partial class Program
{
}
