using HiriingMgmntSystem.Interface;
using HiriingMgmntSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HiriingMgmntSystem.Manager
{
    internal class PublicManager:ILogin
    {
        public User user=new User();
        AdminManager adminManager=new AdminManager();
        public bool Login(String username, String password)
        {
            Console.WriteLine("Successfully Logged in!!!!!!");
            return true;
        }
        public void Register(User user)
        {
            Console.WriteLine("Registered successfully!!!!!!!");
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
                    DisplayMenuJobSeeker();
                    break;

            }

        }
        public void DisplayMenuAdmin()
        {
            do
            {
                Console.WriteLine("1.Register\n2.Login\n3.View New Registrations\n4.List available jobs 5..Back to main menu\n");
                int AdminInput = Convert.ToInt32(Console.ReadLine());
                switch (AdminInput)
                {
                    case 1:
                        {
                            Console.Write("Enter email: ");
                            user.Email = Console.ReadLine();

                            Console.Write("Enter password: ");
                            user.Password = Console.ReadLine();

                            Register(user);
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter email: ");
                            user.Email = Console.ReadLine();

                            Console.Write("Enter password: ");
                            user.Password = Console.ReadLine();

                            Login(user.Email, user.Password);
                            break;
                        }
                    case 3:
                        {
                            adminManager.ViewNewRegistrations();
                            break;
                        }
                    case 4:
                        {
                            adminManager.ListAvailableJobs();
                            break;
                        }
                    case 5:
                        {
                            ShowmainMenu();
                            break;
                        }
                }
            }while (true);
        }
        public void DisplayMenuJobSeeker()
        {
            Console.WriteLine("1.Register\n2.Login\n3.Back to main menu\n");
            int AdminInput = Convert.ToInt32(Console.ReadLine());
            if (AdminInput == 1)
            {
                Console.Write("Enter email: ");
                user.Email = Console.ReadLine();

                Console.Write("Enter password: ");
                user.Password = Console.ReadLine();

                Register(user);
            }
            if (AdminInput == 2)
            {
                Console.Write("Enter email: ");
                user.Email = Console.ReadLine();

                Console.Write("Enter password: ");
                user.Password = Console.ReadLine();

                Login(user.Email, user.Password);

            }
            if (AdminInput == 3) { ShowmainMenu(); }

        }
    }
}
