using System;
using System.Threading.Tasks;
using HayoonKorea.Brands;
using HayoonKorea.Phones;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;
using Volo.Abp.Users;

namespace HayoonKorea
{
    public class HayoonKoreaDataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Phone, Guid> _phoneRepository;
        private readonly IRepository<Brand, Guid> _brandRepository;
        private readonly IRepository<IdentityUser, Guid> _userRepository;
        
        public HayoonKoreaDataSeederContributor(
            IRepository<Phone, Guid> phoneRepository,
            IRepository<Brand, Guid> brandRepository,
            IRepository<IdentityUser, Guid> userRepository
        )
        {
            _phoneRepository = phoneRepository;
            _brandRepository = brandRepository;
            _userRepository = userRepository;
        }

public async Task SeedAsync(DataSeedContext context)
{
    if (await _brandRepository.GetCountAsync() > 0 || await _phoneRepository.GetCountAsync() > 0)
    {
        return;
    }

    var user = await _userRepository.FirstOrDefaultAsync(u => u.UserName == "admin");

    var apple = await _brandRepository.InsertAsync(
        new Brand
        {
            Name = "Apple",
            Logo = "Apple",
            CreatorId = user!.Id
        },
        autoSave: true
    );

    var samsung = await _brandRepository.InsertAsync(
        new Brand
        {
            Name = "Samsung",
            Logo = "Samsung",
            CreatorId = user!.Id
        },
        autoSave: true
    );

    // Add 50 phones
    for (int i = 1; i <= 25; i++)
    {
        await _phoneRepository.InsertAsync(
            new Phone
            {
                CreatorId = user!.Id,
                Name = $"iPhone {16 + i}",
                Model = $"IP{16 + i}-2025",
                Price = 999.99f + i * 10, // Incremental pricing
                Description = $"The latest iPhone {16 + i} with cutting-edge technology.",
                BrandId = apple.Id,
                ReleaseDate = new DateTime(2025, 1, i),
                OS = $"iOS {17 + i}",
                Processor = $"A{19 + i} Bionic",
                Ram = 8 + i % 4, // Alternating RAM
                BatteryCapacity = 4300 + i * 10,
                Width = 71.5f,
                Height = 146.7f,
                Depth = 7.8f,
                WarrantyPeriod = 2,
                Size = "6.1 inches",
                Resolution = "1170x2532",
                DisplayType = "Super Retina XDR OLED",
                Rear = "12 MP + 12 MP",
                Front = "12 MP",
                Waterproof = true,
                WirelessCharging = true,
                FaceUnlock = true,
                Network = "5G",
                Wifi = "Wi-Fi 6E",
                Bluetooth = "Bluetooth 5.3",
                Nfc = true
            },
            autoSave: true
        );

        await _phoneRepository.InsertAsync(
            new Phone
            {
                CreatorId = user!.Id,
                Name = $"Samsung Galaxy S{25 + i}",
                Model = $"SGS{25 + i}-2025",
                Price = 899.99f + i * 10, // Incremental pricing
                Description = $"The newest Galaxy S{25 + i} with exceptional performance and features.",
                BrandId = samsung.Id,
                ReleaseDate = new DateTime(2025, 2, i),
                OS = $"Android {14 + i}",
                Processor = $"Exynos {2200 + i}",
                Ram = 12 + i % 4, // Alternating RAM
                BatteryCapacity = 5000 + i * 10,
                Width = 75.6f,
                Height = 161.5f,
                Depth = 7.9f,
                WarrantyPeriod = 2,
                Size = "6.8 inches",
                Resolution = "1440x3200",
                DisplayType = "Dynamic AMOLED 2X",
                Rear = "108 MP + 12 MP + 12 MP",
                Front = "40 MP",
                Waterproof = true,
                WirelessCharging = true,
                FaceUnlock = true,
                Network = "5G",
                Wifi = "Wi-Fi 6E",
                Bluetooth = "Bluetooth 5.3",
                Nfc = true
            },
            autoSave: true
        );
    }
}

    }
}