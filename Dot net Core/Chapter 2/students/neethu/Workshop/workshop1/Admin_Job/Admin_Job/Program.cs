using Admin_Job.Manager;
class Program
{
     static void Main(string[] args)
    {
        Admin admin=new Admin();
        Console.WriteLine("Welcome to the job portal admin module!");

        while(true)
        {
            Console.WriteLine("Please Select an option:");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");

            string input= Console.ReadLine();   
            switch(input)
            {
                case "1":
                    Console.WriteLine("Enter Username");
                    string regUsername= Console.ReadLine();
                    Console.WriteLine("Enter Password");
                    string regPassword= Console.ReadLine();
                    admin.Register(regUsername, regPassword);
                    break;
                case "2":
                    Console.WriteLine("Enter Username");
                    string loginUsername= Console.ReadLine();
                    Console.WriteLine("Enter Password");
                    string loginPassword= Console.ReadLine();
                    admin.Login(loginUsername, loginPassword);
                    break;
                case "3":
                    Console.WriteLine("Good Bye");
                    return;
                default:
                    Console.WriteLine("Invalid Option.Please try again");
                    break;
            }
        }

    }
}