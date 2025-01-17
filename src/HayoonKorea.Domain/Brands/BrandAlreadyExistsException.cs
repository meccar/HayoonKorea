using Volo.Abp;

namespace HayoonKorea.Brands;

public class BrandAlreadyExistsException : BusinessException
{
    public BrandAlreadyExistsException(string name)
        : base(HayoonKoreaDomainErrorCodes.BrandAlreadyExists)
    {
        WithData("name", name);
    }
}