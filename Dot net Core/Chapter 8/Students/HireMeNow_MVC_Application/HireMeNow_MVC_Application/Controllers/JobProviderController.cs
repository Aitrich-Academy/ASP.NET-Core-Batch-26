using AutoMapper;
using HireMeNow_MVC_Application.Interfaces;
using HireMeNow_MVC_Application.Models.DTOs;
using HireMeNow_MVC_Application.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HireMeNow_MVC_Application.Controllers
{
    public class JobProviderController : Controller
    {
        private readonly IMapper mapper;
        private readonly IJobService jobService;
        private readonly IJobRepository jobRepository;
        private readonly IUserRepository userRepository;

        public JobProviderController(IMapper mapper, IJobService jobService, IJobRepository jobRepository, IUserRepository userRepository)
        {
            this.mapper = mapper;
            this.jobService = jobService;
            this.jobRepository = jobRepository;
            this.userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PostJob()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PostJob(JobDTO jobDTO)
        {
            var uid = HttpContext.Session.GetString("UserId");
            User user = userRepository.GetById(new Guid(uid));
            jobDTO.CompanyId = user.CompanyId;

            var job=mapper.Map<Job>(jobDTO);
            bool result=jobRepository.Create(job);

            TempData["Message"] = "Successfully posted job";
            return RedirectToAction("AllJobs");

        }

        public IActionResult AllJobs()
        {
            var uid=HttpContext.Session.GetString("UserId");

            User user = userRepository.GetById(new Guid(uid));
            Guid cmpId=(Guid)user.CompanyId;

            List<Job> jobs=jobService.GetJobsPosted(cmpId);
            return View(jobs);

        }
    }
}
