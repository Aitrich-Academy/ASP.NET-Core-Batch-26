using Admin_job.Interface;
using Admin_job.Manager;

internal class Program
{
    private static void Main(string[] args)
    {
        IMenu menu = new PublicManager();
        menu.DisplayMenu();
    }
}