using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Admin.Interfaces
{
    public interface IAdminServices
    {
        public Task<List<JobSeeker>> GetJobSeekers();
        public Task<List<JobProviderCompany>> GetCompanies();
        public void DeleteCompanyUserById(Guid id);
        public void DeleteByLocationId(Guid id);
        public int GetJobProviderCount();
        public int GetJobCount();
        public Task<List<JobPost>> GetJobs(string JobLitle);
        public Task<List<JobProviderCompany>> SearchCompanies(string name);
        Task<bool> AddSkill(Skill skill);
        Task<bool> RemoveSkill(Guid skillId);
        Task<Location> AddLocation(Location location);
        public Task<List<Location>> GetLocations();
        public Task<List<JobPost>> GetJobs();


        public Task<List<CompanyUser>> GetCompanyUsers();
        public void DeleteCompaniesById(Guid id);
        public void DeleteByCategoryId(Guid id);
        public void DeleteByIndustryId(Guid id);
        Task<Industry> AddIndustry(Industry industry);

        Task<JobCategory> AddCategory(JobCategory category);
        public Task<List<Industry>> GetIndustries();
        public Task<List<JobCategory>> GetCategories();

        public int GetCompanyCount();


    }
}




























