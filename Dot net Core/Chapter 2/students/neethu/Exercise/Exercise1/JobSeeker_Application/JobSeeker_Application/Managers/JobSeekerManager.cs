using JobSeeker_Application.Enums;
using JobSeeker_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JobSeeker_Application.Managers
{
    public class JobSeekerManager
    {
        private JobSeeker[] jobSeekers=new JobSeeker[10];
        public JobSeeker loggedInJobSeeker=new JobSeeker();
        int jobSeekersCount=0;
        public JobManager jobManager=new JobManager();
         

        public void ShowMainMenu()
        {
            Console.WriteLine("Welcome to the job portal!");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Please select an option\n");
            string command=Console.ReadLine();
            switch(command)
            {
                case "1":
                    RegisterJobSeeker();
                    ShowMainMenu();
                    break;
                case "2":
                    LoginJobSeeker();
                    ShowJobSeekerMenu();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Option.Please try again ");
                    ShowMainMenu();
                    break;
            }
        }
        public void RegisterJobSeeker()
        {
            JobSeeker newJobSeeker = new JobSeeker();

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
            string input = Console.ReadLine();
            ExperienceLevels Experience;
            if(Enum.TryParse(input, true, out Experience))
            {

            }
            else
            {

            }
            Console.WriteLine("Please Enter Your Password");
            newJobSeeker.Password = Console.ReadLine();

            jobSeekers[jobSeekersCount] = newJobSeeker;
            jobSeekersCount++;

            Console.WriteLine("Registration Successful");
        }
        public bool LoginJobSeeker()
        {
            Console.WriteLine("Please Enter your Email Id ");
            string email= Console.ReadLine();
            Console.WriteLine("Please Enter your Password");
            string password= Console.ReadLine();
            bool loginSuccessful = false;
            foreach(JobSeeker seeker in jobSeekers)
            {
                if (seeker != null && seeker.Email == email && seeker.Password == password)
                { 
                    loggedInJobSeeker = seeker;
                    loginSuccessful = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                    loginSuccessful = false;
                }
            }
            return loginSuccessful;

        }
        public void ShowJobSeekerMenu()
        {
            Console.WriteLine("Welcome " + loggedInJobSeeker.FirstName + " !");
            Console.WriteLine("1. Apply Job");
            Console.WriteLine("2. Save Job");
            Console.WriteLine("3. View Profile");
            Console.WriteLine("4. View Applied Job");
            Console.WriteLine("5. View Saved Job");
            Console.WriteLine("6. Logout");

            Console.WriteLine("Please Select an option\n");
            string choice= Console.ReadLine();
            switch(choice)
            {
                case "1":
                    jobManager.ListJobs();
                    Console.WriteLine("Enter the JobId for which you wish to apply");
                    int jobid=Convert.ToInt32(Console.ReadLine());
                    foreach(var job in jobManager.jobs)
                    {
                        if(job.Id == jobid)
                        {
                            loggedInJobSeeker.addAppliedJob(job);
                            ShowJobSeekerMenu();
                        }
                    }
                    break;
                case "2":
                    jobManager.ListJobs();
                    Console.WriteLine("Enter the JobId for which you wish to Save");
                    int jobid1 = Convert.ToInt32(Console.ReadLine());
                    foreach( var job in jobManager.jobs)
                    {
                        if(job.Id == jobid1)
                        {
                            loggedInJobSeeker.addSavedJob(job);
                            ShowJobSeekerMenu();
                        }
                    }
                    break;
                case "3":
                    ViewProfile();
                    ShowJobSeekerMenu();
                    break;
                case "4":
                    loggedInJobSeeker.GetAppliedJobs();
                    ShowJobSeekerMenu();
                    break;
                case "5":
                    loggedInJobSeeker.GetSavedJobs();
                    ShowJobSeekerMenu();
                    break;
                case "6":
                    Logout();
                    break;



                default:
                    Console.WriteLine("Invalid Option Selected. Please try again ");
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
            Console.WriteLine($"Qualification: {loggedInJobSeeker.Qualification}");
            Console.WriteLine($"ExperienceLevel: {loggedInJobSeeker.ExperienceLevel}");
            Console.WriteLine("\n");
        }
        public void Logout()
        {
            loggedInJobSeeker = new JobSeeker();
            Console.WriteLine("Logged out Successfully");
            ShowMainMenu();
        }
        




    }
}
