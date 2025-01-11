using AutoMapper;
using HayoonKorea.Books;

namespace HayoonKorea.Web;

public class HayoonKoreaWebAutoMapperProfile : Profile
{
    public HayoonKoreaWebAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        //Define your object mappings here, for the Web project
    }
}
