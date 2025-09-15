using HiringManagementSystem.Interface;
using HiringManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HiringManagementSystem.enums.ExperienceLevelandRoles;

namespace HiringManagementSystem.Manager
{
    public class Admin_Manager
    {
        int AppliedJobCount = 0;
        int SavedJobCount = 0;
        private Job[] AppliedJobs = new Job[2];
        private Job[] SavedJobs = new Job[2];
        private Job[] jobs = new Job[2];
       public void ViewNewRegistrations()
        {
        }
        public void ListAvailableJobs()
        {
            Console.WriteLine("Jobs available: \n");
            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |  {5,-20}    ", "JobId", "Title", "Discription", "Salary", "Location", "IsAvailable");

            foreach (Job job in jobs)
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |  {5,-20}    ", job.Id, job.Title,job.ExperienceLevel, job.Company, job.Location, job.SalaryRange);
            }
            Console.WriteLine("\n");
        }
    }
}
