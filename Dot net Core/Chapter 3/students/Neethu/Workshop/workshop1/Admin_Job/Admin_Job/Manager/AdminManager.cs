using Admin_Job.Interface;
using Admin_Job.Models;
using Admin_Job.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Job.Manager
{
    public class AdminManager:IMenu
    {
        IJobProvider Jobs = new JobManager();
        public User loggedUser;
        private UserRepository Admins= new UserRepository();
        private Lists display=new Lists();
        public AdminManager(User loggedUser)
        {
            this.loggedUser = loggedUser;
        }
        public void DisplayMenu()
        {
            ShowAdminMenu();
        }
        public void ShowAdminMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. List all Admins");
            Console.WriteLine("2. My Profile");
            Console.WriteLine("3. Post Job");
            Console.WriteLine("4. List All Jobs");
            Console.WriteLine("5. Logout");

            string choice=Console.ReadLine();
            switch(choice)
            {
                case "1":
                    var users=Admins.getAll();
                    display.Print(users);
                    ShowAdminMenu();
                    break;
                case "2":
                    ViewProfile();
                    ShowAdminMenu();
                    break;
                case "3":
                    Console.WriteLine("Enter Job Title");
                    string title=Console.ReadLine();
                    Console.WriteLine("Enter Job Description");
                    string description=Console.ReadLine();
                    Console.WriteLine("Enter Job Location");
                    string location=Console.ReadLine();
                    Console.WriteLine("Enter Job Type: ");
                    string type=Console.ReadLine();
                    Console.WriteLine("Enter salary range");
                    string salary=Console.ReadLine();
                    Console.WriteLine("Enter Job Company");
                    string company=Console.ReadLine();
                    Job job=new Job(title,description,location,type,salary,company);
                    Jobs.PostJob(job);
                    Console.WriteLine("Job Posted Successfully");
                    ShowAdminMenu() ;
                    break;
                case "4":
                    List<Job> jobs=Jobs.GetJobs();
                    display.Print(jobs);
                    ShowAdminMenu();
                    break;
                case "5":
                    Logout();
                    break;
                default:
                    Console.WriteLine("Invalid choice .Please try again");
                    ShowAdminMenu();
                    break;


            }
        }
        public void ViewProfile()
        {
            User loggedUser = Admins.getLoggedUser();
            Console.WriteLine("-------------------------------MY PROFILE-------------------------------------\n");
            Console.WriteLine($"FirstName: {loggedUser.FirstName}");
            Console.WriteLine($"LastName: {loggedUser.LastName}");
            Console.WriteLine($"Email: {loggedUser.Email}");
            Console.WriteLine($"Phone: {loggedUser.Phone}");
            Console.WriteLine("\n");


        }
        public void Logout()
        {
            loggedUser = new User();
            Console.WriteLine("Logged out successfully");
        }
    }
}
