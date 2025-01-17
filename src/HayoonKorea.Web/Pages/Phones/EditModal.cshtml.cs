using System;
using System.Threading.Tasks;
using HayoonKorea.Phones;
using Microsoft.AspNetCore.Mvc;

namespace HayoonKorea.Web.Pages.Phones;

public class EditModalModel : HayoonKoreaPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateUpdatePhoneDto Phone { get; set; }

    private readonly IPhoneAppService _phoneAppService;

    public EditModalModel(IPhoneAppService phoneAppService)
    {
        _phoneAppService = phoneAppService;
    }

    public async Task OnGetAsync()
    {
        var phoneDto = await _phoneAppService.GetAsync(Id);
        Phone = ObjectMapper.Map<PhoneDto, CreateUpdatePhoneDto>(phoneDto);
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _phoneAppService.UpdateAsync(Id, Phone);
        return NoContent();
    }
}