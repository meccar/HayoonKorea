using System.Threading.Tasks;
using HayoonKorea.Books;
using Microsoft.AspNetCore.Mvc;

namespace HayoonKorea.Web.Pages.Books
{
    public class CreateModalModel : HayoonKoreaPageModel
    {
        [BindProperty]
        public CreateUpdateBookDto Book { get; set; }

        private readonly IBookAppService _bookAppService;

        public CreateModalModel(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        public void OnGet()
        {
            Book = new CreateUpdateBookDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.CreateAsync(Book);
            return NoContent();
        }
    }
}