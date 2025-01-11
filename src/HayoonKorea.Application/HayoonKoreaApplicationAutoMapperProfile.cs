using AutoMapper;
using HayoonKorea.Books;

namespace HayoonKorea;

public class HayoonKoreaApplicationAutoMapperProfile : Profile
{
    public HayoonKoreaApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
