using JobProvider.Interface;
using JobProvider.Manager;

class Program
{
    static void Main(string[] args)
    {
        IMenu menu = new PublicManager();
        menu.DisplayMenu();
    }
}