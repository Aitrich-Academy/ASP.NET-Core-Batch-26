using Exercise3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Exercise3.Exceptions;
using System.ComponentModel.Design;
using Exercise3.Models;
using Exercise3.Repository;
using Exercise3.Enums;

namespace Exercise3.Manager
{
    public class PublicManager:IMenu
    {
        UserRepository users=new UserRepository();
        public User loggedUser = new User();
        bool isLogged = false;
        IMenu menu;
        public void DisplayMenu()
        {
            ShowUserMenu();
        }
        public void ShowUserMenu()
        {
            bool exitProgram=false;
            while(!exitProgram)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("3. Exit");
                string choice=Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        LoginProvider();
                        break;
                    case "2":
                        Console.WriteLine("Enter your FirstName");
                        string fname=Console.ReadLine();
                        Console.WriteLine("Enter your LasttName");
                        string lname=Console.ReadLine();
                        string email=GetEmail();
                        Console.WriteLine("Enter your Phonenumber");
                        long phone=Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter your password");
                        string password=Console.ReadLine();
                        Roles roles=Roles.JobProvider;
                        User newuser= new User(fname,lname,email,password,phone,roles);
                        bool successful=users.Register(newuser);
                        if (successful == true)
                            Console.WriteLine("User registered successfully");
                        break;
                    case "3":
                        exitProgram=true;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;





                }
            }
        }
        public void LoginProvider()
        {
            try
            {
                string email = GetEmail();
                Console.WriteLine("Please enter your password");
                string password = Console.ReadLine();
                loggedUser = users.Login(email, password);
                if(loggedUser!=null)
                {
                    isLogged=true;
                    Console.WriteLine("Login Successfull");
                    Console.WriteLine("Welcome Jobprovider");
                    if(loggedUser.Role==Roles.JobProvider)
                    {
                        menu = new JobManager(loggedUser);
                        menu.DisplayMenu();
                    }


                }
                else
                {
                    Console.WriteLine("Login failed");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
        public string GetEmail()
        {
            try
            {
                Console.WriteLine("Please enter your email address");
                string email = Console.ReadLine();
                Regex regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

                if (!regex.IsMatch(email))
                    throw new InvalidFormatException("Email was not in correct format" + email);
                return email;
                

            }
            catch(InvalidFormatException ex)
            {
                Console.WriteLine(ex.Message);
                return GetEmail();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
                return GetEmail();
            }
            
        }

    }
}
