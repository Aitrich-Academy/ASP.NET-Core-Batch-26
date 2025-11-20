using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_Crud3.Models;

namespace Razor_Crud3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Razor_Crud3.Models.BookRazorContext _context;

        public IndexModel(Razor_Crud3.Models.BookRazorContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Employee = await _context.Employees.ToListAsync();
        }
    }
}
