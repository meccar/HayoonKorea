using System.Threading.Tasks;
using HayoonKorea.Phones;
using Microsoft.AspNetCore.Mvc;

namespace HayoonKorea.Web.Pages.Phones
{
    public class CreateModalModel : HayoonKoreaPageModel
    {
        [BindProperty]
        public CreateUpdatePhoneDto Phone { get; set; }

        private readonly IPhoneAppService _phoneAppService;

        public CreateModalModel(IPhoneAppService phoneAppService)
        {
            _phoneAppService = phoneAppService;
        }

        public void OnGet()
        {
            Phone = new CreateUpdatePhoneDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _phoneAppService.CreateAsync(Phone);
            return NoContent();
        }
    }
}