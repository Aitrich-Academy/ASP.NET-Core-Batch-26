using AutoMapper;
using Domain.Models;
using Domain.Services.Admin.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Admin
{
    public class AdminServices:IAdminServices
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IMapper _mapper;

        public AdminServices(IAdminRepository adminRepository, IMapper mapper)
        {
            _adminRepository = adminRepository;
            _mapper = mapper;
        }

        public async Task<List<JobSeeker>> GetJobSeekers()
        {
            return await _adminRepository.GetJobSeekers();
        }

        public async Task<List<JobProviderCompany>> GetCompanies()
        {
            return await _adminRepository.GetCompanies();
        }

        public async Task<List<Location>> GetLocations()
        {
            return await _adminRepository.GetLocations();
        }

        public async Task<List<JobPost>> GetJobs()
        {
            return await _adminRepository.GetJobs();
        }
        public void DeleteCompanyUserById(Guid id)
        {
            _adminRepository.DeleteCompanyUserById(id);
        }

        public void DeleteByLocationId(Guid id)
        {
            _adminRepository.DeleteByLocationId(id);
        }

        public int GetJobProviderCount()
        {
            return _adminRepository.GetJobProviderCount();
        }

        public int GetJobCount()
        {
            return _adminRepository.GetJobCount();
        }
        public async Task<List<JobPost>> GetJobs(string JobLitle)
        {

            var jobs = await _adminRepository.GetJobs(JobLitle);

            return jobs;


        }

        public Task<List<JobProviderCompany>> SearchCompanies(string name)
        {
            return _adminRepository.SearchCompanies(name);
        }

        public async Task<bool> AddSkill(Skill skill)
        {
            var Skill = _mapper.Map<Skill>(skill);
            var result = await _adminRepository.AddSkill(Skill);

            return result;
        }

        public async Task<bool> RemoveSkill(Guid skillId)
        {
            var result = await _adminRepository.RemoveSkill(skillId);

            return result;
        }


        public Task<Location> AddLocation(Location location)
        {
            return _adminRepository.AddLocation(location);
        }



        public async Task<List<CompanyUser>> GetCompanyUsers()
        {
            return await _adminRepository.GetCompanyUsers();
        }

        public void DeleteByCategoryId(Guid id)
        {
            _adminRepository.DeleteByCategoryId(id);
        }
        public void DeleteCompaniesById(Guid id)
        {
            _adminRepository.DeleteCompaniesById(id);
        }
        public void DeleteByIndustryId(Guid id)
        {
            _adminRepository.DeleteByIndustryId(id);
        }

        public Task<Industry> AddIndustry(Industry industry)
        {
            return _adminRepository.AddIndustry(industry);
        }

        public Task<JobCategory> AddCategory(JobCategory category)
        {
            return _adminRepository.AddCategory(category);
        }
        public async Task<List<Industry>> GetIndustries()
        {
            return await _adminRepository.GetIndustries();
        }
        public async Task<List<JobCategory>> GetCategories()
        {
            return await _adminRepository.GetCategories();
        }
        public int GetCompanyCount()
        {
            return _adminRepository.GetCompanyCount();
        }


    }
}
















