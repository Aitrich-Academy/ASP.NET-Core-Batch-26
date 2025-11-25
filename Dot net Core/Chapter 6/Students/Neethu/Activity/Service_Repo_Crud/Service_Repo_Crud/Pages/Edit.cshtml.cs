using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Service_Repo_Crud.Models;
using Service_Repo_Crud.Services;

namespace Service_Repo_Crud.Pages
{
    public class EditModel : PageModel
    {
        private readonly IBookService _service;

        public EditModel(IBookService service)
        {
            _service = service;
        }

        [BindProperty]
        public Book book { get; set; }
        public IActionResult OnGet(int id)
        {
            book=_service.GetBookById(id);
            if (book == null)
            {
                return NotFound();
                
            }
            return Page();
        }
        public IActionResult OnPost(int id)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                var BooktoUpdate = _service.GetBookById(id);
                if (BooktoUpdate == null)
                {
                    return NotFound();
                }
                else
                {
                    BooktoUpdate.Title = book.Title;
                    BooktoUpdate.Genre = book.Genre;
                    BooktoUpdate.Author = book.Author;
                    BooktoUpdate.PublishDate = book.PublishDate;
                    _service.UpdateBook(BooktoUpdate);

                    return RedirectToPage("Index");
                }
            }
        }
    } 
}
