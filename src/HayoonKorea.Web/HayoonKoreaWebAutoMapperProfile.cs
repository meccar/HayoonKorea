using AutoMapper;
using HayoonKorea.Phones;

namespace HayoonKorea.Web;

public class HayoonKoreaWebAutoMapperProfile : Profile
{
    public HayoonKoreaWebAutoMapperProfile()
    {
        CreateMap<PhoneDto, CreateUpdatePhoneDto>();
        
        //Define your object mappings here, for the Web project
    }
}
