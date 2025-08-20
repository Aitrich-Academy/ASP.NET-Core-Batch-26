using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Adminprofile
{
    internal class Program
    {
        struct adminprofile
        {
            public string fullname;
            public string username;
            public string Email;
            public long Phonenumber;
        }
        private static void Main(string[] args)
        {
            adminprofile[] admin = new adminprofile[1];
            string ch;
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("---------------------------------------------------------------- Welcome to Admin Part----------------------------------------------------------------------------------\n");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");

            do
            {
                Console.WriteLine("A - Register as Admin");
                Console.WriteLine("D - Display Admin Details");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                Console.WriteLine("Select an option from the list\n");
                string command=Console.ReadLine();
                switch(command)
                {
                    case "A":
                        {
                            Console.WriteLine("----------------------------------------------------------------Admin Registration-------------------------------------------------------------------------------------\n");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                            Console.Write("Enter name of Admin:  \n ");
                            admin[0].fullname = Console.ReadLine();
                            Console.Write("Enter the username of admin : \n ");
                            admin[0].username = Console.ReadLine();
                            Console.Write("Enter the Email of admin : \n");
                            admin[0].Email = Console.ReadLine();
                            Console.Write("Enter the Phone no of Admin : \n");
                            admin[0].Phonenumber=Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");

                            break;

                        }
                    case "D":
                        {
                            Console.WriteLine("----------------------------------------------------------------List of Admin-------------------------------------------------------------------------------------\n");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                            Console.WriteLine("Name of Admin :  {0}", admin[0].fullname, "\n");

                            Console.WriteLine("Username of admin :{0} ", admin[0].username, "\n");
                            Console.WriteLine("Email of Admin :{0} ", admin[0].Email, "\n");
                            Console.WriteLine("Phone no of Admin : {0}", admin[0].Phonenumber, "\n");

                            break;
                        }
                }
                Console.WriteLine("Do you want to continue (Y/N)");
                ch = Console.ReadLine();

            } while (ch == "Y" || ch == "y"); 
        }
    }
}
