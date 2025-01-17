using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace HayoonKorea.Brands;

public class BrandManager : DomainService
{
    private readonly IBrandRepository _brandRepository;

    public BrandManager(
        IBrandRepository brandRepository
    )
    {
        _brandRepository = brandRepository;
    }

    // public async Task<Brand> CreateAsync(
    //     string name,
    //     string logo)
    // {
    //     Check.NotNullOrWhiteSpace(name, nameof(name));
    //
    //     var existingBrand = await _brandRepository.FindByNameAsync(name);
    //     
    //     if (existingBrand != null)
    //     {
    //         throw new BrandAlreadyExistsException(name);
    //     }
    //
    //     return new Brand(GuidGenerator.Create(), name, logo);
    // }

    // public async Task ChangeNameAsync(
    //     Brand brand,
    //     string newName
    // )
    // {
    //     Check.NotNull(brand, nameof(brand));
    //     Check.NotNullOrWhiteSpace(newName, nameof(newName));
    //     
    //     var existingBrand = await _brandRepository.FindByNameAsync(newName);
    //     
    //     if (existingBrand != null && existingBrand.Id != brand.Id)
    //     {
    //         throw new BrandAlreadyExistsException(newName);
    //     }
    //
    //     brand.ChangeName(newName);
    // }
}