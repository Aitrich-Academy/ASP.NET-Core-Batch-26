using AutoMapper;
using Domain.Models;
using Domain.Services.Admin.DTOs;
using Domain.Services.Admin.Interfaces;
using Domain.Services.Login.Interfaces;
using HiremenowAdmin.API.Admin.RequestObjects;
using HiremenowAdmin.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HiremenowAdmin.API.Admin
{
    //[Route("api/[controller]")]
    [ApiController]
    public class AdminController : BaseApiController<AdminController>
    {
        private readonly IAdminServices _adminService;
        private readonly IMapper _mapper;
        IAdminRepository _adminRepository;
        private IMapper mapper;
        public ILoginRequestService _loginRequestService;
        //IJobService _jobService;

        public AdminController(IMapper mapper, IAdminServices adminService, IAdminRepository adminRepostory, ILoginRequestService loginRequestService)
        {
            _mapper = mapper;
            _adminService = adminService;
            _adminRepository = adminRepostory;
            _loginRequestService = loginRequestService;
          //  _jobService = jobServices;
        }



        [HttpPost]
        [Route("Admin/login")]
        public async Task<ActionResult> Login(AdminLoginRequests logdata)
        {
            
            var user = _loginRequestService.Adminlogin(logdata.Email, logdata.Password);

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
                var jobSeekers = await _adminService.GetJobSeekers();
                return Ok(_mapper.Map<List<JobSeekerDTO>>(jobSeekers));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }


        [HttpPost("skillAdd")]
        public async Task<IActionResult> AddSkill(SkillRequest skill)
        {
        

            var Skill= _mapper.Map<Skill>(skill);

        
            var result = await _adminService.AddSkill(Skill);

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
       
            var result = await _adminService.RemoveSkill(skillId);

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
                var jobProviders = await _adminService.GetCompanies();
                return Ok(_mapper.Map<List<JobProviderDTO>>(jobProviders));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

      

        [HttpGet]
        [Route("admin/SearchCompanies")]
        public async Task<IActionResult> SearchCompanies(string name)
        {

            try
            {

                var companies = await _adminService.SearchCompanies(name);
                return Ok(_mapper.Map<List<JobProviderDTO>>(companies));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        

        [HttpGet]
        [Route("admin/jobsbyName")]
        public async Task<IActionResult> Getalljobs(string Title)
        {

            //try
            //{
                var jobs = await _adminService.GetJobs(Title);
                return Ok(_mapper.Map<List<JobListDTO>>(jobs));
            //}
            //catch (Exception ex)
            //{
                return BadRequest();
            //}

        }
        [HttpGet]
        [Route("alljobs")]
        public async Task<IActionResult> Alljobs()
        {

            try
            {
                var jobs = await _adminService.GetJobs();
                return Ok(_mapper.Map<List<JobListDTO>>(jobs));
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
                _adminService.DeleteCompanyUserById(id);
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
                var count = _adminService.GetJobProviderCount();
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
                var count = _adminService.GetJobCount();
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
            var result = await _adminService.AddLocation(Location);

            return Ok(result);
        }



        [HttpGet("GetLocations")]
        public async Task<IActionResult> GetLocations()
        {

            try
            {
                var locations = await _adminService.GetLocations();
                return Ok(_mapper.Map<List<LocationDTO>>(locations));
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
                _adminService.DeleteByLocationId(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }



        [HttpGet]
        [Route("admin/GetCompanyUsers")]
        public async Task<IActionResult> GetCompanyUsers()
        {

            try
            {
                var companyUsers = await _adminService.GetCompanyUsers();
                return Ok(_mapper.Map<List<CompanyUserDTO>>(companyUsers));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete]
        [Route("admin/RemoveCompanies/{id}")]
        public IActionResult RemoveCompanies(Guid id)
        {
            try
            {
                _adminService.DeleteCompaniesById(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }


        [HttpGet]
        [Route("admin/GetCompanyCount")]
        public IActionResult GetCompanyCount()
        {
            try
            {
                var count = _adminService.GetCompanyCount();
                return Ok(new { Count = count });
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPost("AddIndustry")]
        public async Task<IActionResult> AddIndustry(IndustryRequest Industry)
        {
            var industry = _mapper.Map<Industry>(Industry);
            var result = await _adminService.AddIndustry(industry);

            return Ok(result);
        }

        [HttpPost("AddCategory")]
        public async Task<IActionResult> AddCategory(CategoryRequest category)
        {
            var Category = _mapper.Map<JobCategory>(category);
            var result = await _adminService.AddCategory(Category);

            return Ok(result);
        }

        [HttpGet("GetIndustries")]
        public async Task<IActionResult> GetIndustries()
        {

            try
            {
                var industries = await _adminService.GetIndustries();
                return Ok(_mapper.Map<List<Industry>>(industries));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpGet("GetCategories")]
        public async Task<IActionResult> GetCategories()
        {

            try
            {
                var categories = await _adminService.GetCategories();
                return Ok(_mapper.Map<List<JobCategory>>(categories));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete]
        [Route("RemoveCategory/{id}")]
        public IActionResult RemoveCategory(Guid id)
        {
            try
            {
                _adminService.DeleteByCategoryId(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }


        [HttpDelete]
        [Route("RemoveIndustry/{id}")]
        public IActionResult RemoveIndustry(Guid id)
        {
            try
            {
                _adminService.DeleteByIndustryId(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
    }
}
