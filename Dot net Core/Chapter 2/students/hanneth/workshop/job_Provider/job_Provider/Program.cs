using job_Provider.Interface;
using job_Provider.Manager;

internal class Program
{
    private static void Main(string[] args)
    {

        IjobRepository ijob = new Job_Provider_Manager();
        Console.WriteLine("Welcome to the job provider module!");

        while (true)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ijob.Register();
                    break;
                case "2":
                    ijob.Login();
                    break;

                case "3":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}