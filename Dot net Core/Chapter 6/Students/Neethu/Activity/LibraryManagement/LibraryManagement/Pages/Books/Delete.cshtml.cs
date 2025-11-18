using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagement.Pages.Books
{
    public class DeleteModel : PageModel
    {
        private readonly LibraryDbContext _context;

        public DeleteModel(LibraryDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public BookModel Book { get; set; }


        public async Task<IActionResult>  OnGet(int id)
        {
            if(id==null)
            {
                return NotFound();
            }
            var book=await _context.BookTable.FindAsync(id);
            if(book==null)
            {
                return NotFound();
            }
            else
            {
                Book=book;
               
            }
            return Page();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            if(id==null)
            {
                return NotFound();
            }
            else
            {
                var bookdel=_context.BookTable.FirstOrDefault(b=>b.BookId==id);
                if(bookdel!=null)
                {
                    Book=bookdel;
                    _context.BookTable.Remove(Book);
                   await _context.SaveChangesAsync();
                }
                return RedirectToPage("Index");
            }
        }
    }
}
