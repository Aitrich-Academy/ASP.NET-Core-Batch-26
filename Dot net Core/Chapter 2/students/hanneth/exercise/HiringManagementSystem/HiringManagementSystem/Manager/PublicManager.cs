using HiringManagementSystem.Interface;
using HiringManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringManagementSystem.Manager
{
    public class PublicManager: Imenu
    {
        
       User Admin = new User();
        UserManager UManager = new UserManager();
       JobManager JobManager = new JobManager();
        Admin_Manager Admin_Manager = new Admin_Manager();
        UserManager UserManager = new UserManager();
      
        public void DisplayMenuAdmin()
        {
            Console.WriteLine("1.Register");
            Console.WriteLine("2.Login");
            Console.WriteLine("3.view new registrations");
            Console.WriteLine("4.List available jobs");
            Console.WriteLine("5.Back to main menu");
               int AdminInput = Convert.ToInt32(Console.ReadLine());
            if(AdminInput==1)
            {
                UserManager.Register();
            }
            if (AdminInput == 2)
            {
                Console.WriteLine("Enter user email");
                Admin.Email = Console.ReadLine();
                Console.WriteLine("Enter PAssword");
                Admin.Password = Console.ReadLine();
                UserManager.AdminLogin(Admin.Email,Admin.Password);
            }
                if (AdminInput == 3)
                {
                    JobManager.ListJob();
                }
                if (AdminInput == 4)
                {
                  JobManager.ListJob();
                }
            if (AdminInput == 5)
            { 
                ShowmainMenu(); 
            }
        }
        public void DisplayMenuUser()
        {
            Console.WriteLine("Welcome to the job Seeker Part!");

            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. List Job");

                Console.WriteLine("3. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        UManager.Register();
                        break;
                    case "2":
                        Admin_Manager.ListAvailableJobs();
                        break;

                    case "3":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
        public void ShowmainMenu()
        {
            Console.WriteLine("Select an option ");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Job seeker");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    DisplayMenuAdmin();
                    break;
                case "2":
                    Console.WriteLine("1.Register\n2.Login\n3.Back to main menu\n");
                    int AdminInput = Convert.ToInt32(Console.ReadLine());
                    if (AdminInput == 1)
                    {
                        Console.Write("Enter email: ");
                        string regEmail = Console.ReadLine();

                        Console.Write("Enter password: ");
                        string regPassword = Console.ReadLine();

                        UserManager.Register();
                    }
                    if (AdminInput == 2)
                    {
                        Console.Write("Enter email: ");
                        string loginEmail = Console.ReadLine();

                        Console.Write("Enter password: ");
                        string loginPassword = Console.ReadLine();

                       bool loginUser= UserManager.UserLogin(loginEmail, loginPassword);

                    }
                    break;

            }
        }
    }
}
