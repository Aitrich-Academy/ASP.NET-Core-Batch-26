using Group_by_a_Property;

internal class Program
{
    private static void Main(string[] args)
    {
       List<People> population= new List<People>
       {
           new People{Name="John",City="Delhi"},
           new People{Name="Alice",City="Kochi"},
           new People{Name="Jane",City="Thrissur"},
           new People{Name="Done",City="Delhi"},
           new People{Name="Miya",City="Kochi"},
           new People{Name="Yuva",City="Thrissur"}
       };
        var group=from people in population group people by people.City into citygroup select citygroup;
        foreach(var person in group)
        {
            Console.WriteLine($"\nCity:{person.Key}");
            foreach(var details in person)
            {
                Console.WriteLine($"Name:{details.Name}");
            }

        }

    }
}