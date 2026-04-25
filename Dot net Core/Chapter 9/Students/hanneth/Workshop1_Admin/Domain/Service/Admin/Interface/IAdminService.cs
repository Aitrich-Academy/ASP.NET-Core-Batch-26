using Domain.Models;
using Domain.Service.Profile.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Admin.Interface
{
    public interface IAdminService
    {
        public Task<List<JobSeeker>> GetJobSeekers();
        public Task<List<JobProviderCompany>> GetCompanies();
        public Task<List<Location>> GetLocations();
        public Task<List<JobPost>> GetJobs();
        public void DeleteById(Guid id);
        public void DeleteByLocationId(Guid id);
        public int GetJobProviderCount();
        public int GetJobCount();
        Task<List<JobProviderCompany>> SearchCompanies(string name);
        public Task<List<JobPost>> GetJobs(string jobtitle);
        Task<bool> AddSkillAsync(SkillDto skill);
        Task<bool> RemoveSkillAsync(Guid skillid);
        Task<Location> addLocation(Location location);
    }
}
