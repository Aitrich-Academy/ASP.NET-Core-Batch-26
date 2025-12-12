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
    public class DetailsModel : PageModel
    {
        private readonly RazorDFA.Models.RazorfirstContext _context;

        public DetailsModel(RazorDFA.Models.RazorfirstContext context)
        {
            _context = context;
        }

        public Library Library { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var library = await _context.Libraries.FirstOrDefaultAsync(m => m.Lid == id);
            if (library == null)
            {
                return NotFound();
            }
            else
            {
                Library = library;
            }
            return Page();
        }
    }
}
