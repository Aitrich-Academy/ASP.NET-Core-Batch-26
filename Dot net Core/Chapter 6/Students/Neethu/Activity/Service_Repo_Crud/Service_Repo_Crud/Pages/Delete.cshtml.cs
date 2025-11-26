using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Service_Repo_Crud.Models;
using Service_Repo_Crud.Services;

namespace Service_Repo_Crud.Pages
{
    public class DeleteModel : PageModel
    {

        private readonly IBookService _service;

        public DeleteModel(IBookService service)
        {
            _service = service;
        }

        [BindProperty]
        public Book book { get; set; }
        public IActionResult OnGet(int id)
        {
            var BookToDelete=_service.GetBookById(id);
            if(BookToDelete == null)
            {
                return NotFound();
            }
            else
            {
                book=BookToDelete;
            }
            return Page();

        }
        public IActionResult OnPost( int id)
        {
            var bookdel = _service.GetBookById(id);
            if(bookdel == null)
            {
                return NotFound();
            }
            else
            {
                book=bookdel;
                _service.DeleteBook(book);
            }
            return RedirectToPage("Index");
        }
    }
}
