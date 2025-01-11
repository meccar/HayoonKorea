using HayoonKorea.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace HayoonKorea.Web.Pages;

public abstract class HayoonKoreaPageModel : AbpPageModel
{
    protected HayoonKoreaPageModel()
    {
        LocalizationResourceType = typeof(HayoonKoreaResource);
    }
}
