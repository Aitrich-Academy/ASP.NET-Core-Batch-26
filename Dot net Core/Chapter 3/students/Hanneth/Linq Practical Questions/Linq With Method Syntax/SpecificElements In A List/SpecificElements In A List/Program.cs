using System.Collections.Generic;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> names = new List<string> { "Asdf", "Assss", "wjkfhd", "ajhh", "Ayhh" };
        string moreThan5;
        var result= names.Where(n=>n.StartsWith("A")).ToList();
        foreach (var re in result)
        {
            Console.WriteLine(re);
        }
        Console.WriteLine();
        moreThan5 = names.First(n => n.Length > 5);
        
        Console.WriteLine($"the first name that has more than five characters   : {moreThan5}");

    }
}
