using AutoMapper;
using Domain.Models;
using Domain.Service.Admin.Interface;
using Domain.Service.Profile.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Admin
{
    public class AdminService:IAdminService
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IMapper _mapper;
        public AdminService(IAdminRepository adminRepository,IMapper mapper)
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
          return  await _adminRepository.GetJobs();
        }
        public void DeleteById(Guid id)
        {
            _adminRepository.DeleteById(id);
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
       public async Task<List<JobProviderCompany>> SearchCompanies(string name)
        {
            return await _adminRepository.SearchCompanies(name);
        }
        public async Task<List<JobPost>> GetJobs(string jobtitle)
        {
            return await _adminRepository.GetJobs(jobtitle);
        }
       public async Task<bool> AddSkillAsync(SkillDto skill)
        {
            var Skill = _mapper.Map<Skill>(skill);
            var result = await _adminRepository.AddAsync(Skill);

            return result;
        }
       public async Task<bool> RemoveSkillAsync(Guid skillid)
        {
            return await _adminRepository.RemoveAsync(skillid);
        }
       public async Task<Location> addLocation(Location location)
        {
            return await _adminRepository.addLocation(location);
        }
    }
}
