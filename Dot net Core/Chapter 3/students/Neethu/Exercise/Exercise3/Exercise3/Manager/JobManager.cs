using Exercise3.Interface;
using Exercise3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Manager
{
    public class JobManager:IMenu
    {
        private User loggedUser;
        bool exitprogram=false;
        bool exitprogram2 =false;
        bool exitprogram3=false;
        IJobProvider Jobs = new JobPortal();
        ApplicationManager application=new ApplicationManager();
        InterviewManager interview=new InterviewManager();
        Lists display=new Lists();
        public JobManager() { }
        public JobManager(User loggedUser)
        {
            this.loggedUser = loggedUser;
        }
        public void DisplayMenu()
        {
            ShowUserMenu();
        }
        public void ShowUserMenu()
        {
            while(!exitprogram)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1. Jobs");
                Console.WriteLine("2. Applications");
                Console.WriteLine("3. Interviews");
                Console.WriteLine("4. Exit");
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        while (!exitprogram2)
                        {
                            Console.WriteLine("Choose an option");
                            Console.WriteLine("1. List Jobs");
                            Console.WriteLine("2. Post Job");
                            Console.WriteLine("3. Back to main menu");
                            string option = Console.ReadLine();
                            switch (option)
                            {
                                case "1":
                                    List<Job> jobs = Jobs.GetJobs();
                                    display.Print(jobs);

                                    break;
                                case "2":
                                    Console.WriteLine("Enter Job Title:");
                                    string title = Console.ReadLine();
                                    Console.WriteLine("Enter Job Description");
                                    string description = Console.ReadLine();
                                    Console.WriteLine("Enter Job Location");
                                    string location = Console.ReadLine();
                                    Console.WriteLine("Enter Job Type");
                                    string type = Console.ReadLine();
                                    Console.WriteLine("Enter Job Salary");
                                    string salary = Console.ReadLine();
                                    Console.WriteLine("Enter Job company");
                                    string company = Console.ReadLine();
                                    Job job = new Job(title, description, location, type, salary, company);
                                    Jobs.PostJob(job);
                                    Console.WriteLine("Job posted successfully");
                                    break;
                                case "3":
                                    exitprogram2 = true;
                                    break;
                                default:
                                    Console.WriteLine("Invalid option");
                                    break;







                            }
                        }
                        break;
                    case "2":
                         application.PrintApplications();
                         break;
                    case "3":
                        while (!exitprogram3)
                        {

                            Console.WriteLine("Choose an option");
                            Console.WriteLine("1. List Interviews");
                            Console.WriteLine("2. Schedule Interview");
                            Console.WriteLine("3. Back to main menu");
                            string choice3= Console.ReadLine();
                            switch(choice3)
                            {
                                case "1":
                                    interview.ListInterviews();
                                    break;
                                case "2":
                                    Console.WriteLine("Enter Job Id");
                                    int jobId = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter company Name");
                                    string company= Console.ReadLine();
                                    Console.WriteLine("Enter Job post");
                                    string title= Console.ReadLine();
                                    Console.WriteLine("Enter Interview Date");
                                    DateTime date= Convert.ToDateTime(Console.ReadLine());
                                    Console.WriteLine("Enter Online/Location");
                                    string location= Console.ReadLine();
                                    Console.WriteLine("Enter Interview time");
                                    string time= Console.ReadLine();
                                    Interview jobinterviews = new Interview(jobId, title, company, location, date, time);
                                    interview.ScheduleInterview(jobinterviews);
                                    Console.WriteLine("Interview scheduled successfully");
                                    break ;
                                case "3":
                                    exitprogram3 = true;
                                    break;
                                default:
                                    Console.WriteLine("Invalid option");
                                    break;


                            }

                        }
                        break;
                    case "4":
                        exitprogram = true;
                        Console.WriteLine("exiting job portal.Good bye!!");
                        break;
                    default :
                        Console.WriteLine("Invalid option");
                        break;

                        

                }
            }
        }
    }
}
