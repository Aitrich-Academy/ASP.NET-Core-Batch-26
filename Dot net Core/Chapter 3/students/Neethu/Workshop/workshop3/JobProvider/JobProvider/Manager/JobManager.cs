using JobProvider.Interface;
using JobProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobProvider.Manager
{
    internal class JobManager:IMenu
    {
        IJobProvider Jobs = new JobPortal();
        private User loggedUser;
        private Lists display=new Lists();
        public JobManager(User loggedUser)
        {
            this.loggedUser = loggedUser;
        }
        public void DisplayMenu()
        {
            ShowAdminMenu();
        }
        private void ShowAdminMenu()
        {
            Console.WriteLine("1. Post a job");
            Console.WriteLine("2. List all jobs");
            Console.WriteLine("3. Logout");
            string choice=Console.ReadLine();
            switch(choice)
            {
                case "1":
                    
                    Console.WriteLine("Enter the job Title");
                    string title=Console.ReadLine();
                    Console.WriteLine("Enter the job Description");
                    string description=Console.ReadLine();
                    Console.WriteLine("Enter the job Location");
                    string location=Console.ReadLine();
                    Console.WriteLine("Enter the job Salary");
                    string salary=Console.ReadLine();
                    Console.WriteLine("Enter the job Type");
                   string type=Console.ReadLine();
                    Console.WriteLine("Enter the company");
                   string company=Console.ReadLine();
                    Job job=new Job(title, description, location, salary, type,company);
                    Jobs.PostJob(job);
                    Console.WriteLine("Job posted successfully");
                    ShowAdminMenu();
                    break;
                case "2":
                    List<Job> jobs=Jobs.GetJobs();
                    display.Print(jobs);
                    ShowAdminMenu();
                    break;  
                case "3":
                    Logout();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    ShowAdminMenu();
                    break;



            }
        }
        public void Logout()
        {
            loggedUser=new User();
            Console.WriteLine("Logged out successfully");

        }

    }
}
