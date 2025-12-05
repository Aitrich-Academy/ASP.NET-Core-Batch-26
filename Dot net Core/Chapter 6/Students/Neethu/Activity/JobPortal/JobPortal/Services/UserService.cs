using JobPortal.Models;
using JobPortal.Repositories;

namespace JobPortal.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _Repo;

        public UserService(IUserRepository repo)
        {
            _Repo = repo;
        }

        public bool RegisterUser(User user)
        {
            var existing=_Repo.GetByEmail(user.Email);
            if (existing != null)
            {
                return false;
            }
            _Repo.AddUser(user);
            return true;
        }
        public User Login(string Email,string password)
        {
            var user=_Repo.GetByEmail(Email);
            return (user!=null&&user.Password==password)?user:null;
        }

        public async Task<List<Job>> GetAllJobsAsync()
        {
            var jobs = await _Repo.GetAllJobsAsync();
            return jobs;
        }
        public async Task<Job> GetJobByIdAsync(int id)
        {
            var job=await _Repo.GetJobByIdAsync(id);
            return job;
        }
        public bool ApplyJob(JobApplication application)
        {
            var success=_Repo.ApplyJob(application);
            return success;
            
        }
        public async Task<List<JobApplication>> GetAllApplicationsAsync(int id)
        {
            var application=await _Repo.GetAllApplicationsAsync(id);
            return application;

        }
    }
}
