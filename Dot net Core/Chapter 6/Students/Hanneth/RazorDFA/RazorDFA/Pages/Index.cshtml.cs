using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorDFA.Models;

namespace RazorDFA.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RazorDFA.Models.RazorfirstContext _context;

        public IndexModel(RazorDFA.Models.RazorfirstContext context)
        {
            _context = context;
        }

        public IList<Library> Library { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Library = await _context.Libraries.ToListAsync();
        }
    }
}
