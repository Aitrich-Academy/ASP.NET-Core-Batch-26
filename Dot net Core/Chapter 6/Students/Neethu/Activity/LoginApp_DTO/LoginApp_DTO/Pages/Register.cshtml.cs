using LoginApp_DTO.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AutoMapper;
using LoginApp_DTO.Models;
using LoginApp_DTO.DTOs;

namespace LoginApp_DTO.Pages
{
    public class RegisterModel : PageModel
    {

        private readonly LoginAppDbContext _context;
        private readonly IMapper mapper;

        public RegisterModel(LoginAppDbContext context, IMapper mapper)
        {
            _context = context;
           this. mapper=mapper;
        }

        [BindProperty]
        public RegisterDto Input { get; set; }

        public string Message { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();
            var exists = _context.Users.FirstOrDefault(u => u.Email == Input.Email);

            if(exists != null)
            {
                Message = "Email already Registered";
                return Page();
            }
            User user=mapper.Map<User>(Input);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Login");
        }
    }
}
