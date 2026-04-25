using Domain.Models;
using Domain.Service.Admin.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Admin
{
    public class AdminRepository:IAdminRepository
    {
        private readonly DbHireMeNowWebApiContext _context;
        public AdminRepository(DbHireMeNowWebApiContext context)
        {
            _context = context;
        }
        public async Task<List<JobSeeker>> GetJobSeekers()
        {
            return await _context.JobSeekers.ToListAsync();
        }
        public async Task<List<JobProviderCompany>> GetCompanies()
        {
            return await _context.JobProviderCompanies.ToListAsync();
        }
        public async Task<List<Location>> GetLocations()
        {
            return await _context.Locations.ToListAsync();
        }
        public async Task<List<JobPost>> GetJobs()
        {
            return await _context.JobPosts
                .Include(j => j.JobLocation)
                .Include(j => j.Industry)
                .Include(j => j.Category)
                .Include(j => j.PostedByNavigation)
                .ToListAsync();

        }
        public void DeleteById(Guid id)
        {
            var item=_context.CompanyUsers.Where(e=>e.Id==id).FirstOrDefault();
            if(item!=null)
            {
                _context.CompanyUsers.Remove(item);
                _context.SaveChanges();
            }
        }
        public void DeleteCompanyById(Guid id)
        {
            var item = _context.JobProviderCompanies.Where(e => e.Id == id).FirstOrDefault();
            if (item != null)
            {
                _context.JobProviderCompanies.Remove(item);
                _context.SaveChanges();
            }
        }
        public void DeleteByLocationId(Guid id)
        {
            var item = _context.Locations.Where(e => e.Id == id).FirstOrDefault();
            if (item != null)
            {
                _context.Locations.Remove(item);
                _context.SaveChanges();
            }
        }
        public void DeleteByCategoryId(Guid id)
        {
            var item = _context.JobCategories.Where(e => e.Id == id).FirstOrDefault();
            if (item != null)
            {
                _context.JobCategories.Remove(item); _context.SaveChanges();
            }
        }
        public void DeleteByIndustryId(Guid id)
        {
            var item=_context.Industries.Where(e=>e.Id == id).FirstOrDefault();
            if(item != null)
            {
                _context.Industries.Remove(item);
                _context.SaveChanges();
            }
        }
        public int GetCompanyCount()
        {
            return _context.JobProviderCompanies.Count();
        }
        public int GetJobProviderCount()
        {
            return _context.CompanyUsers.Count();
        }
        public async Task<List<JobPost>> GetJobs(string jobtitle)
        {
            return _context.JobPosts.Where(e=>e.JobTitle.Contains(jobtitle)).ToList();
        }
        public int GetJobCount()
        {
            return _context.JobPosts.Count();
        }
       public async Task<bool> AddAsync(Skill skill)
        {
            if(skill == null)
                throw new ArgumentNullException(nameof(skill));
            if(_context.Skills.Any(s=>s.Name==skill.Name))
            {
                return false;
            }
            skill.Id = Guid.NewGuid();
            _context.Skills.Add(skill);
            _context.SaveChangesAsync();
            return true;
        }
       public async Task<bool> RemoveAsync(Guid skillid)
        {
            var skillToRemove=await _context.Skills.FindAsync(skillid);
            if(skillToRemove==null)
            {
                return false;
            }
            _context.Skills.Remove(skillToRemove);
            _context.SaveChangesAsync();
            return true;
        }
       public async Task<Location> addLocation(Location location)
        {
            location.Id = Guid.NewGuid();
            await _context.Locations.AddAsync(location);
            _context.SaveChangesAsync();
            return location;
        }
       public async Task<List<JobProviderCompany>> SearchCompanies(string name)
        {
           var filteredCompanies = await _context.JobProviderCompanies
          .Where(company => company.LegalName.Contains(name))
          .ToListAsync();

            return filteredCompanies;
        }
    }
}
