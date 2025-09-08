using Job_Application.Enums;
using Job_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Application.Managers
{
    public class JobSeekerManager
    {
        public JobSeekerManager() { }

        private JobSeeker[] jobSeekers=new JobSeeker[10];
        int jobSeekerCount=0;
        public JobSeeker loggedInJobSeeker=new JobSeeker();

        public void ShowMainMenu()
        {
            Console.WriteLine("Welcome to the job portal!");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");

            string Choice=Console.ReadLine();

            switch(Choice)
            {
                case "1":
                    RegisterJobSeeker();
                    break;
                case "2":
                    bool loginRes = LoginJobSeeker();
                    if (loginRes)
                    {
                        Console.WriteLine("Welcome " + loggedInJobSeeker.FirstName + " !");
                        ShowJobSeekerMenu();
                    }
                    else
                    {
                        Console.WriteLine("Login Failed.....");
                        ShowMainMenu();
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Choice.Please try again");
                    ShowMainMenu();
                    break;

            }

        }

        public void RegisterJobSeeker()
        {
            JobSeeker newJobSeeker= new JobSeeker();


            Console.WriteLine("Please Enter Your First Name");
            newJobSeeker.FirstName = Console.ReadLine();
            Console.WriteLine("Please Enter Your Last Name");
            newJobSeeker.LastName = Console.ReadLine();
            Console.WriteLine("Please Enter Your Email Address");
            newJobSeeker.Email = Console.ReadLine();
            Console.WriteLine("Please Enter Your Phone Number");
            newJobSeeker.Phone = Console.ReadLine();
            Console.WriteLine("Please Enter Your Location");
            newJobSeeker.Location = Console.ReadLine();
            Console.WriteLine("Please Enter About You");
            newJobSeeker.AboutMe = Console.ReadLine();
            Console.WriteLine("Please Enter Your Qualification");
            newJobSeeker.Qualification = Console.ReadLine();
            Console.WriteLine("Please Enter Your Experience Level(Fresher,MidLevel,Senior)");
            string input= Console.ReadLine();
            ExperienceLevels experience;
            if(Enum.TryParse(input, out experience))
            { }
            else { Console.WriteLine("Invalid Input"); }
            Console.WriteLine("Please Enter Your Password");
            newJobSeeker.Password = Console.ReadLine();

            jobSeekers[jobSeekerCount] = newJobSeeker;
            jobSeekerCount++;
            Console.WriteLine("Registration Successful");

        }
        public void ShowJobSeekerMenu()
        {
            Console.WriteLine("1. My Profile");
            Console.WriteLine("2. Logout");

            string choice= Console.ReadLine();

            switch(choice)
            {
                case "1":
                    ViewProfile();
                    ShowJobSeekerMenu();
                    break;
                case "2":
                    Logout();
                    break;
                default:
                    Console.WriteLine("Invalid Choice.Please Try Again");
                    ShowJobSeekerMenu();
                    break;

            }
        }
        public void ViewProfile()
        {
            Console.WriteLine("-------------------------------MY PROFILE-------------------------------------\n");
            Console.WriteLine($"First Name: {loggedInJobSeeker.FirstName}");
            Console.WriteLine($"Last Name: {loggedInJobSeeker.LastName}");
            Console.WriteLine($"Email: {loggedInJobSeeker.Email}");
            Console.WriteLine($"Phone: {loggedInJobSeeker.Phone}");
            Console.WriteLine($"Location: {loggedInJobSeeker.Location}");
            Console.WriteLine($"AboutMe: {loggedInJobSeeker.AboutMe}");
            Console.WriteLine($"ExperienceLevel: {loggedInJobSeeker.ExperienceLevel}");
            Console.WriteLine("\n");
        }
        public void Logout()
        {
            loggedInJobSeeker = new JobSeeker();
            Console.WriteLine("Logged out successfully");
            ShowMainMenu();
        }
        public bool LoginJobSeeker()
        {
            Console.WriteLine("Please enter your email");
            string email= Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string password= Console.ReadLine();
            bool loginSuccessful=false;
            foreach(JobSeeker seeker in jobSeekers)
            {
                if(seeker!=null&&seeker.Email==email&&seeker.Password==password)
                {
                    loggedInJobSeeker=seeker;
                    loginSuccessful=true;
                    break;

                }
            }
            return loginSuccessful;

        }
    }
}
