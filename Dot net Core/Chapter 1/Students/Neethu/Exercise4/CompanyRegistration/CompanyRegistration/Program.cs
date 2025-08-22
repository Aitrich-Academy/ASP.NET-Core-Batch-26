using System;
using System.Data;
namespace CompanyRegistraion
{
    internal class Program
    {
        struct Company
        {
            public string CompanyName;
            public string Email;
            public string Website;
            public long Phonenumber;
            public string Location;
            public string Password;

        }
        struct JobPost
        {
            public string JobName;
            public DateTime Date;
            public string Time;
            public string Location2;
        }
        private static void Main(string[] args)
        {
            Company[] comp = new Company[1];
            JobPost[] jobPosts = new JobPost[10];
            int jobcount = 0;
            string ch;
            string command;
            do
            {
                Console.WriteLine("Welcome to the Jobseeker portal!");
                Console.WriteLine("Welcome to the Job Portal!");
                Console.WriteLine("1. Register Company");
                Console.WriteLine("2. Login Company");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Select an option from the list\n");
                command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        {
                            Console.WriteLine("Please enter Company name\n");
                            comp[0].CompanyName = Console.ReadLine();
                            Console.WriteLine("Please enter Company Email\n");
                            comp[0].Email = Console.ReadLine();
                            Console.WriteLine("Please enter Company Website\n");
                            comp[0].Website = Console.ReadLine();
                            Console.WriteLine("Please enter Company Phone Number\n");
                            comp[0].Phonenumber = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Please enter Location\n");
                            comp[0].Location = Console.ReadLine();
                            Console.WriteLine("Please enter Password\n");
                            comp[0].Password = Console.ReadLine();
                            Console.WriteLine("Registration Successfull");
                            break;


                        }
                    case "2":
                        {
                            Console.WriteLine("Please enter Company Email\n");
                            if (Console.ReadLine() == comp[0].Email)
                            {
                                Console.WriteLine("Please enter Company Password\n");
                                if (Console.ReadLine() == comp[0].Password)
                                {
                                    string command2;
                                    do
                                    {
                                        Console.WriteLine("Login Successful");
                                        Console.WriteLine("Welcome Aitrich!");
                                        Console.WriteLine("1. Schedule Interview");
                                        Console.WriteLine("2. Scheduled Interview list");
                                        Console.WriteLine("3. Logout");
                                        Console.WriteLine("Select an option from the list\n");
                                        command2 = Console.ReadLine();
                                        switch (command2)
                                        {
                                            case "1":
                                                {
                                                    Console.WriteLine("How many no of interviews are scheduling");
                                                    int n = Convert.ToInt32(Console.ReadLine());
                                                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
                                                    Console.WriteLine("----------------------------------------------------------Schedule an Interview for Job seekers---------------------------------------------------");
                                                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------\n\n");
                                                    for (int i = 0; i < n&&jobcount<jobPosts.Length; i++,jobcount++)
                                                    {
                                                        Console.WriteLine("Enter the Name of Job Post {0}: ", i + 1);
                                                        jobPosts[i].JobName = Console.ReadLine();
                                                        Console.WriteLine("Enter the Date for Interview(dd-mm-yyyy)");
                                                        jobPosts[i].Date = Convert.ToDateTime(Console.ReadLine());
                                                        Console.WriteLine("Enter the Time of a Interview(h-m)");
                                                        jobPosts[i].Time = Console.ReadLine();
                                                        Console.Write("Location of sheduled InterView {0}: ", i + 1);
                                                        jobPosts[i].Location2 = Console.ReadLine();



                                                    }
                                                    break;

                                                }
                                            case "2":
                                                {
                                                    Console.WriteLine("Company Name Aitrich");
                                                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------\n\n");
                                                    for(int i = 0;i<jobcount;i++)
                                                    {
                                                        Console.WriteLine("Name: {0} ", jobPosts[i].JobName);
                                                        Console.WriteLine("Date: {0}",jobPosts[i].Date);
                                                        Console.WriteLine("Time: {0}", jobPosts[i].Time);
                                                        Console.WriteLine("Location: {0} ", jobPosts[i].Location2);
                                                        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------\n\n");
                                                        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------\n\n");

                                                    }
                                                    break;

                                                }
                                            case "3":
                                                {
                                                    Console.WriteLine("Logging Out......");
                                                    break;
                                                }
                                        }
                                    } while (command2 != "3");
                                    

                                }
                                else
                                {
                                    Console.WriteLine("Incorrect Password");
                                }
                                   

                            }
                            else
                            {
                                Console.WriteLine("Incorrect Email");
                            }
                            break;
                        }
                        case "3":
                        {
                            Console.WriteLine("Exiting program");
                            break;
                        }
                }
            } while (command != "3");
        }
    }

}
