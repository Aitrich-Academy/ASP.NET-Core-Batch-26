using Exercise3.Interface;
using Exercise3.Manager;

internal class Program
{
     static void Main(string[] args)
    {
        IMenu menu = new PublicManager();
        menu.DisplayMenu();
        
    }
}