using HiringManagementSystem.Manager;
using HiringManagementSystem.Models;

internal class Program
{
   
    private static void Main(string[] args)
    {
        PublicManager manager = new PublicManager();
        Console.WriteLine("*************************Welcome to the Hiring Management System******************");
        while (true)
        {
           manager.ShowmainMenu(); 
        }
    }
}