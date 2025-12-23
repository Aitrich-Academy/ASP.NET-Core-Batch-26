using AutoMapper;
using Login_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Login_MVC.Controllers
{
    public class AccountController : Controller
    {

        private readonly AppDbContext context;
        private readonly IMapper mapper;
        public AccountController(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserDto userDto)
        {
            if(ModelState.IsValid)
            {
                var user=mapper.Map<User>(userDto);
                context.Users.Add(user);
                context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(userDto);
        }   

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserDto userDto)
        {
            var user=context.Users.FirstOrDefault(u=>u.Email == userDto.Email&&u.Password==userDto.Password);
            if(user!=null)
            {
                HttpContext.Session.SetString("Username", user.Username);
                return RedirectToAction("DashBoard");
            }
            //ModelState.AddModelError("", "Invalid Login Attempt");
            ViewBag.Error = "Invalid Login Attempt";
            return View(userDto);
        }
        public IActionResult DashBoard()
        {
            var username = HttpContext.Session.GetString("Username");
            if(username==null)
            {
                return RedirectToAction("Login");
            }
            ViewBag.Username=username;
            return View();
        }
    }
}
