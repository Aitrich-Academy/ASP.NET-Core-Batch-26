using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagement.Pages.Books
{
    public class EditModel : PageModel
    {
        private readonly LibraryDbContext _context;

        public EditModel(LibraryDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BookModel Book { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            Book = await _context.BookTable.FindAsync(id);

            if(Book== null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var BookToUpdate = await _context.BookTable.FindAsync(id);
            if (BookToUpdate==null)
            {
                return NotFound();
            }
            else

            {
                BookToUpdate.Title=Book.Title;
                BookToUpdate.Genre=Book.Genre;
                BookToUpdate.Author=Book.Author;
                BookToUpdate.PublishDate=Book.PublishDate;

                
               await _context.SaveChangesAsync();

                return RedirectToPage("Index");
            }


        }
    }
}
