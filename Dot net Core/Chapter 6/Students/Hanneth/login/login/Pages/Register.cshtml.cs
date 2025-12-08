using login.Data;
using login.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace login.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly AppDbContext _context;
        public RegisterModel (AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public User Input { get; set; }
        public string Message {  get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();
            var exists=_context.users.FirstOrDefault(u=>u.Email == Input.Email);
            if (exists != null)
            {
                Message = "Email already registered";
                return Page();
            }
            _context.users.Add(Input);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Login");
        }
    }
}
