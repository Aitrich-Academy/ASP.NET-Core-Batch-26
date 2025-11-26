using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Service_Repo_Crud.Models;
using Service_Repo_Crud.Services;

namespace Service_Repo_Crud.Pages
{
    public class DetailsModel : PageModel
    {

        private readonly IBookService _service;

        public DetailsModel(IBookService service)
        {
            _service = service;
        }
        [BindProperty]
        public Book book { get; set; }
        public IActionResult OnGet(int id)
        {
           var books=_service.GetBookById(id);
            if (books == null)
            {
                return NotFound();
            }
            else
            {
                book = books;
            }
            return Page();
        }
    }
}
