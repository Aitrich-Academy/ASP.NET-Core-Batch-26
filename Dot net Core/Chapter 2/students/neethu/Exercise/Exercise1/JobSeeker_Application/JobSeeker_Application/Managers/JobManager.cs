using JobSeeker_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobSeeker_Application.Enums;

namespace JobSeeker_Application.Managers
{
    public class JobManager
    {
        public Job[] jobs = new Job[5]
        {
            new Job{Id=1,Title="Python Developer",ExperienceLevel=Enums.ExperienceLevels.Fresher,Company="UST",Location="TVM",SalaryRange="25000-30000",JobType="Offline"},
            new Job{Id=2,Title=".Net Developer",ExperienceLevel=Enums.ExperienceLevels.MidLevel,Company="CTS",Location="Delhi",SalaryRange="40000-50000",JobType="Offline"},
            new Job{Id=3,Title="Java Developer",ExperienceLevel=Enums.ExperienceLevels.Fresher,Company="WIPRO",Location="Banglore",SalaryRange="25000-30000",JobType="Online"},
            new Job{Id=4,Title="Automation Tester",ExperienceLevel=Enums.ExperienceLevels.Fresher,Company="UST",Location="TVM",SalaryRange="20000-25000",JobType="Offline"},
            new Job{Id=5,Title="Java Developer",ExperienceLevel=Enums.ExperienceLevels.Senior,Company="Infosys",Location="TVM",SalaryRange="55000-65000",JobType="Offline"}
        };
        public void ListJobs()
        {
            Console.WriteLine("Jobs Available are\n");
            Console.WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|","JobId","Title","Experience Level","Company","Location","SalaryRange","JobType");
            foreach(Job job in jobs)
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", job.Id, job.Title, job.ExperienceLevel, job.Company, job.Location, job.SalaryRange,job.JobType);
            }
        }
        public void GetJobById(int jobId)
        {
            foreach(Job job in jobs)
            {
                if(job.Id == jobId)
                {
                    Console.WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", "JobId", "Title", "Experience Level", "Company", "Location", "SalaryRange", "JobType");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", job.Id, job.Title, job.ExperienceLevel, job.Company, job.Location, job.SalaryRange, job.JobType);
                }
            }
        }
    }
}
