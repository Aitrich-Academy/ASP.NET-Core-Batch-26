using AutoMapper;
using Login_DTO.Data;
using Login_DTO.DTO;
using Login_DTO.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Login_dto.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly AppDbContextcs _db;
        private readonly IMapper _mapper;

        public RegisterModel(AppDbContextcs db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [BindProperty]
        public Register_DTO Input { get; set; }

        public string Message { get; set; }

        //public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            var exists = _db.Users.FirstOrDefault(u => u.Email == Input.Email);
            if (exists != null)
            {
                Message = "Email already registered.";
                return Page();
            }

            // Map DTO -> Entity
            User user = _mapper.Map<User>(Input);

            _db.Users.Add(user);
            await _db.SaveChangesAsync();

            return RedirectToPage("/Login");
        }
    }
}
