using HireMeNow_MVC_Application.Interfaces;
using HireMeNow_MVC_Application.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HireMeNow_MVC_Application.Controllers
{
    public class PublicController : Controller
    {
        private readonly IPublicService publicService;

        public PublicController(IPublicService publicService)
        {
            this.publicService = publicService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult JobProviderRegistration()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult JobProviderRegistration(User user)
        {
            try
            {
                publicService.Register(user);
                return RedirectToAction("Login");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string email,string password)
        {
            try
            {
                var result = publicService.LoginJobProvider(email, password);
                if (result != null)
                {
                    HttpContext.Session.SetString("UserId", result.UseId.ToString());
                    HttpContext.Session.SetString("ComapanyId", result.CompanyId.ToString());
                    return RedirectToAction("PostJob", "JobProvider");
                }
                else
                {
                    ViewBag.Error = "Invalid Login Attempt";
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
