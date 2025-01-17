using System;
using HayoonKorea.Permissions;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HayoonKorea.Phones;

[Authorize(HayoonKoreaPermissions.Phones.Default)]
public class PhoneAppService :
    CrudAppService<
        Phone, //The Phone entity
        PhoneDto, //Used to show phones
        Guid, //Primary key of the phone entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdatePhoneDto>, //Used to create/update a phone
        IPhoneAppService //implement the IPhoneAppService
{
    public PhoneAppService(IRepository<Phone, Guid> repository) : base(repository)
    {
        
        GetPolicyName = HayoonKoreaPermissions.Phones.Default;
        GetListPolicyName = HayoonKoreaPermissions.Phones.Default;
        CreatePolicyName = HayoonKoreaPermissions.Phones.Create;
        UpdatePolicyName = HayoonKoreaPermissions.Phones.Edit;
        DeletePolicyName = HayoonKoreaPermissions.Phones.Delete;
    }
}