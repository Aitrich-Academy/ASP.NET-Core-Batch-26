using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly LibraryDbContext _context;

        public int TotalCount { get; set; }

        [BindProperty(SupportsGet =true)]
        public string Search {  get; set; }

        public IndexModel(LibraryDbContext context)
        {
            _context = context;
        }

        public List<BookModel> BookList { get; set; }
        public async Task OnGetAsync()
        {
            if(string.IsNullOrEmpty(Search))
            {
                BookList = await _context.BookTable.ToListAsync();

            }
            else
            {
                BookList= await _context.BookTable.Where(b=>b.Title.Contains(Search)).ToListAsync();


            }
            TotalCount= BookList.Count();
        }
    }
}
