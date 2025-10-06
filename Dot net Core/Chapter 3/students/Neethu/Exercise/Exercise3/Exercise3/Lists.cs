using Exercise3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Lists
    {
        public void Print(List<Job> jobs)
        {
            Console.WriteLine("Jobs \n");
            Console.WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}","JobId","Job Title","Job Description","Location","Type","Salary","Company");
            if (jobs != null)
            {
                foreach (Job job in jobs)
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}", job.Id,job.Title,job.Description,job.Location,job.Type,job.Salary,job.Company);
                }
            }
            else
                Console.WriteLine("No jobs to display");
            
        }

    }
}
