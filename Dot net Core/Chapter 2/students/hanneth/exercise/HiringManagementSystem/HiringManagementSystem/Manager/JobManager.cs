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
    internal class JobManager
    {
        public int numJobs = 0;
        public Job[] jobs = new Job[10];
        public void addjob()
        {
            if (numJobs == jobs.Length)
            {
                Console.WriteLine("Maximum number of jobs reached. Please try again later.");
                return;
            }
            Console.Write("Enter job id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter job title: ");
            string title = Console.ReadLine();

            //Console.Write("Enter experience level:1. fresher\n2. mid level\n3. senior");
            Console.Write("Enter company: ");
            string company = Console.ReadLine();
            Console.Write("Enter job location: ");
            string location = Console.ReadLine();
            Console.WriteLine("Enter salary range");
            string salaryRange = Console.ReadLine();
            Console.WriteLine("Enter job type");
            string jobtype = Console.ReadLine();
            Job newJob = new Job();

            jobs[numJobs] = newJob;
            numJobs++;
            Console.WriteLine("Job added successfully.");
        }
        public void ListJob()
        {
            Console.WriteLine("Jobs:");
            for (int i = 0; i < numJobs; i++)
            {
                Console.WriteLine($"Title: {jobs[i].Title}");
                Console.WriteLine($"Description: {jobs[i].ExperienceLevel}");
                Console.WriteLine($"salary: {jobs[i].SalaryRange}");
                Console.WriteLine($"Location: {jobs[i].Location}");
            }
        }
    }
}
