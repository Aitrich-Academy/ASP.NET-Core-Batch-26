class People
{
   public string Name;
   public string City;
}
internal class Program
{
    private static void Main(string[] args)
    {
        List<People> peoplelist = new List<People>
        {
            new People{Name="Hanna",City="Bathery"},
             new People{Name="Asad",City="Alappy"},
              new People{Name="Aboo",City="Bathery"},
               new People{Name="Pathu",City="Alappy"},
                new People{Name="Affan",City="Bathery"},
        }; 
        var people=from p in peoplelist orderby p.City select p;
        foreach( People p in people )
        {
            Console.WriteLine($"{p.Name}  :  {p.City}");
        }
    }
}