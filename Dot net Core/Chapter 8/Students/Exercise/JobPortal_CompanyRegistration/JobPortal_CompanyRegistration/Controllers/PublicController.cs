using JobPortal_CompanyRegistration.Dto_s;
using JobPortal_CompanyRegistration.Models;
using JobPortal_CompanyRegistration.Services;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal_CompanyRegistration.Controllers
{
    public class PublicController : Controller
    {
        private readonly ICompanyService companyService;
        public PublicController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }
          
        

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(CompanyDto companyDto)
        {
            var success = companyService.RegisterCompany(companyDto);
            if (success)
            {
                ViewBag.Result="Registered successfully";
                return RedirectToAction("CompanyProfile");
            }
            else
                return View();
            
        }
       public IActionResult CompanyProfile()
        {
            return View();
        }
        
       
    }
}
