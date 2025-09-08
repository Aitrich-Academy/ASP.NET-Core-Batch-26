using Admin_Job.Interface;
using Admin_Job.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Job.Manager
{
    public class JobManager:IJob
    {
        private int numJobs = 0;
        private Job[] jobs=new Job[100];
        public void addjob()
        {
            if(numJobs==jobs.Length)
            {
                Console.WriteLine("Maximum number of jobs reached. Try again later");
                return;
            }
            Console.WriteLine("Enter Job Id");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Job Title: ");
            string title=Console.ReadLine();
            Console.WriteLine("Enter Description: ");
            string description=Console.ReadLine();
            Console.WriteLine("Enter Salary: ");
            string salary=Console.ReadLine();
            Console.WriteLine("Enter Job Location");
            string location=Console.ReadLine();
            Job newJob=new Job(id,title,description,salary,location);
            jobs[numJobs]=newJob;
            numJobs++;
            Console.WriteLine("Job Added successfully");
        }
        public void ListJob()
        {
            Console.WriteLine("Jobs:");
            for(int i=0;i<numJobs;i++)
            {
                Console.WriteLine($"Title: {jobs[i].Title} ");
                Console.WriteLine($"Description: {jobs[i].Description}");
                Console.WriteLine($"Salary: {jobs[i].Salary}");
                Console.WriteLine($"Location: {jobs[i].Location}");
            }
        }

    }
}
