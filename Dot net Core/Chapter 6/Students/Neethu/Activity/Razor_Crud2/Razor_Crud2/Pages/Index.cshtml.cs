using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_Crud2.Models;

namespace Razor_Crud2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Razor_Crud2.Models.StudentDbContext _context;

        public IndexModel(Razor_Crud2.Models.StudentDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
