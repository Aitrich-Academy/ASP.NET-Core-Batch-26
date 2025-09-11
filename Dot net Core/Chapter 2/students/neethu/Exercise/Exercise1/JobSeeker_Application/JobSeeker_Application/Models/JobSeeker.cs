using JobSeeker_Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker_Application.Models
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
        public string Qualification { get; set; }
        public ExperienceLevels ExperienceLevel { get; set; }
        public string Password { get; set; }
        
        public void addAppliedJob(Job job)
        {
            if(AppliedJobCount<10)
            {
                AppliedJobs[AppliedJobCount]=job;
                AppliedJobCount++;
                Console.WriteLine("Job Applied Successfully");
            }
            else
            {
                Console.WriteLine("Job Applied Limit Exeeds");
            }
        }
        public void GetAppliedJobs()
        {
            Console.WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", "JobId", "Title", "Experience Level", "Company", "Location", "SalaryRange", "JobType");
            for (int i = 0;i<AppliedJobCount;i++)
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", AppliedJobs[i].Id, AppliedJobs[i].Title, AppliedJobs[i].ExperienceLevel, AppliedJobs[i].Company, AppliedJobs[i].Location, AppliedJobs[i].SalaryRange, AppliedJobs[i].JobType);
            }
        }
        public void addSavedJob(Job job)
        {
            if(SavedJobCount<10)
            {
                AppliedJobs[SavedJobCount]=job;
                SavedJobCount++;
            }
            else
            {
                Console.WriteLine("Saved Job limit exeeds");
            }
        }
        public void GetSavedJobs()
        {
            Console.WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", "JobId", "Title", "Experience Level", "Company", "Location", "SalaryRange", "JobType");
            for (int i = 0; i <SavedJobCount; i++)
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", SavedJobs[i].Id, SavedJobs[i].Title, SavedJobs[i].ExperienceLevel, SavedJobs[i].Company, SavedJobs[i].Location, SavedJobs[i].SalaryRange, SavedJobs[i].JobType);
            }
        }

    }
}
