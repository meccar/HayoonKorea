using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using HayoonKorea.Localization;

namespace HayoonKorea.Web;

[Dependency(ReplaceServices = true)]
public class HayoonKoreaBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<HayoonKoreaResource> _localizer;

    public HayoonKoreaBrandingProvider(IStringLocalizer<HayoonKoreaResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
