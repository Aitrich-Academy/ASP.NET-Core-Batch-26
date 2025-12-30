using JobPortal_CompanyRegistration.Dto_s;
using JobPortal_CompanyRegistration.Models;
using JobPortal_CompanyRegistration.Services;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal_CompanyRegistration.Controllers
{
    public class MemberController : Controller
    {
        private readonly IUserService userService;
        public MemberController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult MemberRegistration( Guid CompanyId,bool success = false)
        {
            var model = new UserDto();
            model.CompanyId = CompanyId;
            if (success)
                ViewBag.Message = "Member Registration Successful";

            return View(model);
        }

        [HttpPost]
        public IActionResult MemberRegistration(UserDto userDto)
        {
            if (!ModelState.IsValid)
                return View(userDto);

            var success = userService.RegisterMember(userDto);

            if (success)
            {
                // Redirect to clear the form
                return RedirectToAction("MemberRegistration", new { success = true, CompanyId=userDto.CompanyId });
            }

            ViewBag.Message = "Registration failed. Try again.";
            return View(userDto);
        }

        public IActionResult ListMember(Guid CompanyId)
        {
            var memberlist=userService.GetAllMembers(CompanyId);
            ViewBag.CopanyId = CompanyId;
            return View(memberlist);
        }
        public IActionResult RemoveMember(Guid CompanyId,bool success=false,bool notfound=false)
        {
            if(success)
                ViewBag.Message2 = "Member Removed Successfully";
            if(notfound)
                ViewBag.error = "Member not Found";
            ViewBag.ComapnyId = CompanyId;
            return View();
        }
        [HttpPost]
        public IActionResult RemoveMember(Guid UserId,string FirstName,string Designation)
        {
            var success=userService.DeleteMember(UserId,FirstName,Designation);
            if (success)
            {
                
               return RedirectToAction("RemoveMember",new { success = true });
            }
            
           return RedirectToAction("RemoveMember",new{notfound = true});
        }
        
    }
}
