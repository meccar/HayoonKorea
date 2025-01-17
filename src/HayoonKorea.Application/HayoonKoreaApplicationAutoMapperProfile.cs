using AutoMapper;
using HayoonKorea.Phones;

namespace HayoonKorea;

public class HayoonKoreaApplicationAutoMapperProfile : Profile
{
    public HayoonKoreaApplicationAutoMapperProfile()
    {
        CreateMap<Phone, PhoneDto>();
        CreateMap<CreateUpdatePhoneDto, Phone>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
