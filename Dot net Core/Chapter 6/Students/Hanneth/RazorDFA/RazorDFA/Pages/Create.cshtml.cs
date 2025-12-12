using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorDFA.Models;

namespace RazorDFA.Pages
{
    public class CreateModel : PageModel
    {
        private readonly RazorDFA.Models.RazorfirstContext _context;

        public CreateModel(RazorDFA.Models.RazorfirstContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Library Library { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Libraries.Add(Library);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
