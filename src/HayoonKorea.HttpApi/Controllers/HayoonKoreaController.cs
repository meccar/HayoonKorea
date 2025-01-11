using HayoonKorea.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HayoonKorea.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class HayoonKoreaController : AbpControllerBase
{
    protected HayoonKoreaController()
    {
        LocalizationResource = typeof(HayoonKoreaResource);
    }
}
