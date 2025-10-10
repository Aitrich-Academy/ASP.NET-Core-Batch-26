using JobProvider.Interface;
using JobProvider.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobProvider.Models;
using System.Text.RegularExpressions;
using JobProvider.Exceptions;
using JobProvider.Enums;

namespace JobProvider.Manager
{
    public class PublicManager:IMenu
    {
        UserRepository userRepository=new UserRepository();
        public User loggedUser=new User();
        bool isLoggedIn = false;
        IMenu menu;
        public void DisplayMenu()
        {
            showUserMenu();
        }
        private void showUserMenu()
            
        {
            bool exitProgram = false;
            while (!exitProgram)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        RegisterProvider();
                        break;
                    case "2":
                        LoginJobProvider();
                        if(isLoggedIn)
                            menu.DisplayMenu();
                        break;
                    case "3":
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;


                }
            }
        }
        public void RegisterProvider()
        {
            try
            {
                User newJobProvider = new User();
                Console.WriteLine("Please enter your First name");
                newJobProvider.FirstName = Console.ReadLine();
                Console.WriteLine("Please enter your Last Name");
                newJobProvider.LastName = Console.ReadLine();
                
                newJobProvider.Email = GetEmail();

                newJobProvider.Phone = GetPhoneNumber();
                Console.WriteLine("Please enter your Password");
                newJobProvider.Password = Console.ReadLine();
                userRepository.register(newJobProvider);
                Console.WriteLine("Registration successful");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public string GetEmail()
        {
            try
            {
                Console.WriteLine("Please Enter your Email address ");
                string email = Console.ReadLine();
                Regex regex = new Regex("^\\S+@\\S+\\.\\S+$");
                if (!regex.IsMatch(email))
                    throw new InvalidFormatException("Enter a valid email address");
                return email;

            }
            catch(InvalidFormatException ex)
            {
                Console.WriteLine(ex.Message + "\n");
                Console.WriteLine("try again...."); 
                    return GetEmail();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return GetEmail();
            }
        }
        public long GetPhoneNumber()
        {
            try
            {
                Console.WriteLine("Please enter your Phone number");
                long phone = Convert.ToInt64(Console.ReadLine());
                return phone;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return GetPhoneNumber();
            }
            


        }
        public void LoginJobProvider()
        {
            try
            {
                string email = GetEmail();
                Console.WriteLine("Please enter your password");
                string password = Console.ReadLine();
                loggedUser = userRepository.login(email, password);
                if(loggedUser!=null)
                {
                    isLoggedIn = true;
                    Console.WriteLine("Login Successful");
                    Console.WriteLine("Welcome ", loggedUser.FirstName);
                    if(loggedUser.Role==Roles.JobProvider)
                    {
                        menu = new JobManager(loggedUser);
                    }

                }
                else
                {
                    Console.WriteLine("Login failed");
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message+"\n");

            }
        }

    }
}
