using AutoMapper;
using Domain.Models;
using Domain.Services.Admin.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Admin
{
    public class AdminRepository:IAdminRepository
    {
       

        private readonly HireMeNowDbContext _context;

        private readonly IMapper _mapper;

        public AdminRepository(HireMeNowDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<JobSeeker>> GetJobSeekers()
        {
            return await _context.JobSeekers.ToListAsync();
        }

        public async Task<List<JobProviderCompany>> GetCompanies()
        {
            return await _context.JobProviderCompanies.ToListAsync();
        }


        public void DeleteCompanyUserById(Guid id)
        {
            var item = _context.CompanyUsers.Where(e => e.CompanyUserId == id).FirstOrDefault();
            if (item != null)
            {
                _context.CompanyUsers.Remove(item);
                _context.SaveChanges();
            }
        }

        public void DeleteByLocationId(Guid id)
        {
            var item = _context.Locations.Where(e => e.LocationId == id).FirstOrDefault();
            if (item != null)
            {
                _context.Locations.Remove(item);
                _context.SaveChanges();
            }
        }

        public void DeleteCompaniesById(Guid id)
        {
            var item = _context.JobProviderCompanies.Where(e => e.JobProviderCompanyId == id).FirstOrDefault();
            if (item != null)
            {
                _context.JobProviderCompanies.Remove(item);
                _context.SaveChanges();
            }
        }
        public void DeleteByCategoryId(Guid id)
        {
            var item = _context.JobCategories.Where(e => e.JobCategoryId == id).FirstOrDefault();
            if (item != null)
            {
                _context.JobCategories.Remove(item);
                _context.SaveChanges();
            }
        }

        public void DeleteByIndustryId(Guid id)
        {
            var item = _context.Industries.Where(e => e.IndustryId == id).FirstOrDefault();
            if (item != null)
            {
                _context.Industries.Remove(item);
                _context.SaveChanges();
            }
        }
        public int GetCompanyCount()
        {
            int count = _context.JobProviderCompanies.Count();
            return count;
        }

        public int GetJobProviderCount()
        {
            int count = _context.CompanyUsers.Count();
            return count;
        }

        public int GetJobCount()
        {
            int count = _context.JobPosts.Count();
            return count;
        }
        public async Task<List<JobPost>> GetJobs(string JobLitle)
        {
            return _context.JobPosts.Where(e => e.JobTitle.Contains(JobLitle)).ToList();

        }

        public async Task<List<JobPost>> GetJobs()
        {

            
            return await _context.JobPosts
                    .Include(j => j.Location)
                    .Include(j => j.Industry)
                    .Include(j => j.JobCategory)
                    .Include(j => j.PostedByNavigation)
                    .ToListAsync();
        }

        public async Task<List<JobProviderCompany>> SearchCompanies(string name)

        {
            var filteredCompanies = await _context.JobProviderCompanies
                                  .Where(company => company.LegalName.Contains(name))
                                  .ToListAsync();

            return filteredCompanies;
        }

        public async Task<bool> AddSkill(Skill skill)
        {
            if (skill == null)
                throw new ArgumentNullException(nameof(skill));

            if (_context.Skills.Any(s => s.Name == skill.Name))
            {
                return false; 

            }
            skill.SkillId = Guid.NewGuid();
            _context.Skills.Add(skill);
            await _context.SaveChangesAsync();
            return true; 

        }

        public async Task<bool> RemoveSkill(Guid skillId)
        {
            var skillToRemove = await _context.Skills.FindAsync(skillId);

            if (skillToRemove == null)
            {
                return false; 
            }

            _context.Skills.Remove(skillToRemove);
            await _context.SaveChangesAsync();

            return true; 
        }

        public async Task<Location> AddLocation(Location location)
        {
            location.LocationId = Guid.NewGuid();
            await _context.Locations.AddAsync(location);
            await _context.SaveChangesAsync();
            return location;
        }


        public async Task<List<Location>> GetLocations()
        {
            return await _context.Locations.ToListAsync();
        }

        public async Task<List<CompanyUser>> GetCompanyUsers()
        {
            return await _context.CompanyUsers.ToListAsync();

           

            //return await _context.CompanyUsers
            //    .Include(c=>c.FirstName)
            //    .Include(c=>c.LastName)
            //    .Include(c=>c.Email)
            //    .Include(c=>c.Phone)
            //    .Include(c=>c.UserName)
            //    .Include(c=>c.Company)
            //    .ToListAsync();
        }

        public async Task<Industry> AddIndustry(Industry industry)
        {
            await _context.Industries.AddAsync(industry);
            await _context.SaveChangesAsync();
            return industry;
        }

        public async Task<JobCategory> AddCategory(JobCategory category)
        {
            await _context.JobCategories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<List<Industry>> GetIndustries()
        {
            return await _context.Industries.ToListAsync();
        }
        public async Task<List<JobCategory>> GetCategories()
        {
            return await _context.JobCategories.ToListAsync();
        }

    }
}
















