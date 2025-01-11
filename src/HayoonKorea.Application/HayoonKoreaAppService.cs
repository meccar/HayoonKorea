using HayoonKorea.Localization;
using Volo.Abp.Application.Services;

namespace HayoonKorea;

/* Inherit your application services from this class.
 */
public abstract class HayoonKoreaAppService : ApplicationService
{
    protected HayoonKoreaAppService()
    {
        LocalizationResource = typeof(HayoonKoreaResource);
    }
}
