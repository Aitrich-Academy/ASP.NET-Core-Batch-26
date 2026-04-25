using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Admin.Interface
{
    public interface IAdminRepository
    {
        public Task<List<JobSeeker>> GetJobSeekers();
        public Task<List<JobProviderCompany>> GetCompanies();
        public Task<List<Location>> GetLocations();
        public Task<List<JobPost>> GetJobs();
        public void DeleteById(Guid id);
        public void DeleteCompanyById(Guid id);
        public void DeleteByLocationId(Guid id);
        public void DeleteByCategoryId(Guid id);
        public void DeleteByIndustryId(Guid id);
        public int GetCompanyCount();
        public int GetJobProviderCount();
        public Task<List<JobPost>> GetJobs(string jobtitle);
        public int GetJobCount();
        Task<bool> AddAsync(Skill skill);
        Task<bool> RemoveAsync(Guid skillid);
        Task<Location> addLocation(Location location);
        Task<List<JobProviderCompany>> SearchCompanies(string name);
    }
}
