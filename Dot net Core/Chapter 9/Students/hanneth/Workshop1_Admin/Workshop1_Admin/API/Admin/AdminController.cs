using AutoMapper;
using Domain.Models;
using Domain.Service.Admin;
using Domain.Service.Admin.Dto;
using Domain.Service.Admin.Interface;
using Domain.Service.Login.Interface;
using Domain.Service.Profile.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Workshop1_Admin.API.Admin.RequestObjects;

namespace Workshop1_Admin.API.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminservice;
        private readonly IMapper _mapper;
        private readonly ILoginRequestService _loginRequestService;
       

        public AdminController(IAdminService adminservice,IMapper mapper,ILoginRequestService loginRequestService)
        {
            _adminservice = adminservice; 
            _mapper = mapper;
            _loginRequestService = loginRequestService;
        }
        [HttpPost]
        [Route("Admin/login")]
        public async Task<ActionResult> Login(AdminLoginRequest logdata)
        {
          //  var user = _mapper.Map<User>(userDto);
            var user = _loginRequestService.AdminLogin(logdata.Email, logdata.Password);

            if (user == null)
            {
                return BadRequest("Login Failed");
            }
            return Ok(user);
        }

        [HttpGet]
        [Route("admin/GetJobSeekers")]
        public async Task<IActionResult> GetJobSeekers()
        {

            try
            {
                var jobSeekers = await _adminservice.GetJobSeekers();
                return Ok(_mapper.Map<List<JobSeekerDto>>(jobSeekers));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }


        [HttpPost("skillAdd")]
        public async Task<IActionResult> AddSkill(SkillRequest skill)
        {
            // Map the request to DTO

            var Skill = _mapper.Map<SkillDto>(skill);

            // Call the service
            var result = await _adminservice.AddSkillAsync(Skill);

            if (result)
            {
                return Ok("Skill added successfully");
            }
            else
            {
                return BadRequest("Skill already exists");
            }
        }

        [HttpDelete("skillRemove/{skillId}")]
        public async Task<IActionResult> RemoveSkill(Guid skillId)
        {
            // Call the service
            var result = await _adminservice.RemoveSkillAsync(skillId);

            if (result)
            {
                return Ok("Skill deleted successfully");
            }
            else
            {
                return NotFound("Skill not found or failed to delete");
            }
        }

        [HttpGet]
        [Route("admin/GetCompanies")]
        public async Task<IActionResult> GetCompanies()
        {

            try
            {
                var jobProviders = await _adminservice.GetCompanies();
                return Ok(_mapper.Map<List<JobProviderDto>>(jobProviders));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        //New-Code

        [HttpGet]
        [Route("admin/SearchCompanies")]
        public async Task<IActionResult> SearchCompanies(string name)
        {

            try
            {

                var companies = await _adminservice.SearchCompanies(name);
                return Ok(_mapper.Map<List<JobProviderDto>>(companies));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        

        [HttpGet]
        [Route("admin/jobsbyName")]
        public async Task<IActionResult> getalljobs(string Title)
        {

            try
            {
                var jobs = await _adminservice.GetJobs(Title);
                return Ok(_mapper.Map<List<JobListDto>>(jobs));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
        [HttpGet]
        [Route("alljobs")]
        public async Task<IActionResult> alljobs()
        {

            try
            {
                var jobs = await _adminservice.GetJobs();
                return Ok(_mapper.Map<List<JobListDto>>(jobs));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }




        [HttpDelete]
        [Route("admin/RemoveCompanyUsers/{id}")]
        public IActionResult Remove(Guid id)
        {
            try
            {
                _adminservice.DeleteById(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }



        [HttpGet]
        [Route("admin/GetJobProviderCount")]
        public IActionResult GetJobProviderCount()
        {
            try
            {
                var count = _adminservice.GetJobProviderCount();
                return Ok(new { Count = count });
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("admin/GetJobCount")]
        public IActionResult GetJobCount()
        {
            try
            {
                var count = _adminservice.GetJobCount();
                return Ok(new { Count = count });
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }






        [HttpPost("AddLocation")]
        public async Task<IActionResult> AddLocation(LocationRequest location)
        {
            var Location = _mapper.Map<Location>(location);
            var result = await _adminservice.addLocation(Location);

            return Ok(result);
        }



        [HttpGet("GetLocations")]
        public async Task<IActionResult> GetLocations()
        {

            try
            {
                var locations = await _adminservice.GetLocations();
                return Ok(_mapper.Map<List<LocationDto>>(locations));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }


        [HttpDelete]
        [Route("RemoveLocations/{id}")]
        public IActionResult RemoveLocation(Guid id)
        {
            try
            {
                _adminservice.DeleteByLocationId(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }




    }
}
