using Assessment.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assessment.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly AppDbContext _context;
        public RegisterModel(AppDbContext context)
        {
            _context = context;
        }
        public string message { get; set; }
        [BindProperty]
        public UserModel Input { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();
            var exist=_context.Users.FirstOrDefault(u=>u.Email==Input.Email&&u.Password==Input.Password);
            if (exist!=null)
            {
                message = "email already registered";
                return Page();
            }
            _context.Users.Add(Input);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Login");
        }
    }
}
