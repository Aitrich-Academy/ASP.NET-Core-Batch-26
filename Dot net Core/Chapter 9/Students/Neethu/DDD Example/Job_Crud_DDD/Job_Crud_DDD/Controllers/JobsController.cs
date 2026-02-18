using Domain.Dto_s;
using Domain.Interfaces;
using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Job_Crud_DDD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IJobService jobService;
        public JobsController(IJobService jobService)
        {
            this.jobService = jobService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllJobs()
        {
            var jobs=await jobService.GetAllJobsAsync();
            return Ok(jobs);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetJob(int id)
        {
            var job=await jobService.GetJobByIdAsync(id);
            if (job == null)
                return NotFound();
            return Ok(job);
        }
        [HttpPost]
        public async Task<IActionResult> CreateJob(JobDto jobDto)
        {
            var job=await jobService.AddJobAsync(jobDto);
            return CreatedAtAction(nameof(GetJob),new {id=job.Id},job);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateJob(int id,JobDto jobDto)
        {
            if (id != jobDto.Id) return BadRequest();
            var updatedJob = await jobService.UpdateJobAsync(jobDto);
            return Ok(updatedJob);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJob(int id)
        {
            var deleted = await jobService.DeleteJobAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
