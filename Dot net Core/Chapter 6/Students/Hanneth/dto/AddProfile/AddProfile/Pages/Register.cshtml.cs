using AddProfile.Data;
using AddProfile.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AddProfile.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public RegisterModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public string Message { get; set; }
        public User Input { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();
            var exists = _context.users.FirstOrDefault(u => u.Email == Input.Email);
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
