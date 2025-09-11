using Job_Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Application.Models
{
    public class JobSeeker
    {
        int AppliedJobCount = 0;
        int SavedJobCount = 0;

        private Job[] AppliedJobs=new Job[10];
        private Job[] SavedJobs=new Job[10];

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string AboutMe { get; set; }
        public string Qualification {  get; set; }
        public ExperienceLevels ExperienceLevel { get; set; }
        public string Password { get; set; }


    }
}
