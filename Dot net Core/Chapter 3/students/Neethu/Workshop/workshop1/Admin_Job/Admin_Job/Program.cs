using Admin_Job.Interface;
using Admin_Job.Manager;

internal class Program
{
     static void Main(string[] args)
    {
        IMenu menu = new PublicManager();
        menu.DisplayMenu();
    }
}