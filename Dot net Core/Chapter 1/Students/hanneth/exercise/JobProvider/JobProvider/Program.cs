using System.Runtime.InteropServices;

namespace JobProvider
{
    internal class Program
    {
        struct user
        {
            public string UserId;
            public string Name;
            public string Designation;
            public string Email;
            public long Phone;
        }
        struct admin
        {
            public string email;
            public string password;
        }
        private static void Main(string[] args)
        {
            user[] users = new user[10];
            admin[] admins = new admin[3];
            string ch;
            Console.WriteLine("Welcome to the Hire Me Now Job Portal");
            Console.WriteLine("    1.Login");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("Please enter your email");
                admins[0].email = Console.ReadLine();
                Console.WriteLine("Please enter your Password");
                admins[0].password = Console.ReadLine();
                Console.WriteLine("Login successful");
            }
            Console.ReadKey();
           

            
            do
            {
                Console.WriteLine("     1.List all Company members");
                Console.WriteLine("     2.Add company members");
                Console.WriteLine("     3.Logout");
                Console.WriteLine("Enter an option.....1...2...or 3");
                string Option = Console.ReadLine();
                switch (Option)
                {
                    case "1":
                        {
                            Console.WriteLine("Company members");
                            Console.WriteLine("UserId                       |Name                   |Designation                  |Email                     |Phone");
                            for (int i = 0; i < users.Length; i++)
                            {
                                if (users[i].UserId != null)
                                {
                                    Console.Write("\t"+users[i].UserId);
                                    Console.Write("\t\t\t " + users[i].Name);
                                    Console.Write("\t \t\t" + users[i].Designation);
                                    Console.Write("\t\t \t" + users[i].Email);
                                    Console.Write("\t\t\t" + users[i].Phone);
                                }
                            }
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("How many members u want to add?");
                            int count = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine("Enter the details of member{0}", i + 1);
                                Console.WriteLine("---------------------------------------------------");
                                Console.WriteLine("Please enter company member name:");
                                users[i].UserId = Console.ReadLine();
                                Console.WriteLine("Please enter email:");
                                users[i].Name = Console.ReadLine();
                                Console.WriteLine("Please enter designation");
                                users[i].Email = Console.ReadLine();
                                Console.WriteLine("Please enter your phone number");
                                users[i].Phone = Convert.ToInt64(Console.ReadLine());
                                Console.WriteLine("Registration successful");
                            }
                            break;

                        }
                    case "3":
                        {
                            Console.WriteLine("Logged out successfully");
                            break;
                        }

                }
                Console.WriteLine("Do you want to continue");
                ch = Console.ReadLine();

            } while (ch == "y" || ch == "Y");
        }
    }
}

