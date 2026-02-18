using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Admin.Interfaces
{
    public interface IAdminRepository
    {
        public Task<List<JobSeeker>> GetJobSeekers();
        public Task<List<JobProviderCompany>> GetCompanies();
        public Task<List<Location>> GetLocations();
        public Task<List<JobPost>> GetJobs();
        public void DeleteCompanyUserById(Guid id);
        public void DeleteByLocationId(Guid id);
        public void DeleteCompaniesById(Guid id);
        public void DeleteByCategoryId(Guid id);
        public void DeleteByIndustryId(Guid id);
        public int GetCompanyCount();
        public int GetJobProviderCount();
        public Task<List<JobPost>> GetJobs(string JobLitle);
        public int GetJobCount();
        Task<bool> AddSkill(Skill skill);
        Task<bool> RemoveSkill(Guid skillId);
        Task<Location> AddLocation(Location location);
        Task<List<JobProviderCompany>> SearchCompanies(string name);


        public Task<List<CompanyUser>> GetCompanyUsers();


        public Task<List<Industry>> GetIndustries();
        Task<Industry> AddIndustry(Industry industry);

        Task<JobCategory> AddCategory(JobCategory category);

        public Task<List<JobCategory>> GetCategories();
    }
}























