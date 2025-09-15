using HiringManagementSystem.Interface;
using HiringManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringManagementSystem.Manager
{
    internal class UserManager : Ilogin
    {
        private User[] users = new User[2];
        private int num_users = 0;
        private bool _isLogged;
        //public JobManager job = new JobManager();
        public User[] JobSeeker = new User[10];
      //  public User loggedInJobSeeker=new User();
        public void Register()
        {
            if (num_users == users.Length)
            {
                Console.WriteLine("Maximum number of users reached. Please try again later.");
                return;
            }
            User newUser = new User();
            users[num_users] = newUser;
            num_users++;

            Console.WriteLine("Registration successful.");
        }
       
        public bool AdminLogin(string email, string password)
        {
            for (int i = 0; i < num_users; i++)
            {
                if (users[i].Email == email && users[i].Password == password)
                {
                    Console.WriteLine("Login successful!");
                    _isLogged = true;
                    string ch = "0";
                    if (_isLogged)

                        while (ch != "3")
                        {
                            Console.WriteLine("1 .post job\n");
                            Console.WriteLine("2.List job\n");
                            Console.WriteLine("3.Back to main menu\n");
                            ch = Console.ReadLine();

                            if (ch == "1")
                            {
                               // job.addjob();

                            }
                            if (ch == "2")
                            {
                               //ob.ListJob();
                            }
                            if (ch == "3")
                            {
                                Console.Write("exit");
                            }
                        }
                }
                else
                {
                    Console.WriteLine("Invalid username or password.");
                    return false;
                }
            }
            return true;
        }
        public bool UserLogin(string Email,string Password)
        {

            Console.WriteLine("Please enter your email:");
            string email = Console.ReadLine();

            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();

            bool loginSuccessful = false;
            foreach (User seeker in JobSeeker)
            {
                if (seeker != null && seeker.Email == email && seeker.Password == password)
                {
                    loggedInJobSeeker = seeker;
                    loginSuccessful = true;
                    break;
                }
            }

            return loginSuccessful;

        }
    }
}
