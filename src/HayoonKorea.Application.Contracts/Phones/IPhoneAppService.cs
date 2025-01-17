using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HayoonKorea.Phones;

public interface IPhoneAppService :
    ICrudAppService< //Defines CRUD methods
        PhoneDto, //Used to show phones
        Guid, //Primary key of the phone entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdatePhoneDto> //Used to create/update a phone
{

}