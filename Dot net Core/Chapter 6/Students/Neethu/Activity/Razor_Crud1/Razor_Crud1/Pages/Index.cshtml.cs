using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_Crud1.Models;

namespace Razor_Crud1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Razor_Crud1.Models.RazorDbContext _context;

        public IndexModel(Razor_Crud1.Models.RazorDbContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Books.ToListAsync();
        }
    }
}
