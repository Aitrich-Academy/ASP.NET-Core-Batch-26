using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Service_Repo_Crud.Models;
using Service_Repo_Crud.Services;

namespace Service_Repo_Crud.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IBookService _service;

        public CreateModel( IBookService service)
        {
            _service = service;
        }
        [BindProperty]
        public Book NewBook { get; set; }

        public string Message { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                var success=_service.AddBook(NewBook);
                if(!success)
                {
                    Message = "Not able to add the book";
                    return Page();
                }
            }
            return RedirectToPage("/Index");

        }
    }
}
