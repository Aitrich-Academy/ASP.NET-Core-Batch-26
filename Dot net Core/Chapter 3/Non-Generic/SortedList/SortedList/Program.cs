using System.Collections;

namespace NonGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedList
            SortedList pets = new SortedList();
            //Adding items
            pets.Add("Parrot", "P1");
            pets.Add("Pigeon", "P2");
            pets.Add("Cat", "P3");
            pets.Add("Dog", "P4");
            pets.Add("Rabbit", "P5");
            //Removing item
            pets.Remove("Pigeon");
            //Displaying items
            foreach (var item in pets) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Parrot is found at index {pets.IndexOfKey("Parrot")}");//IndexOfKey
            Console.WriteLine($"Value P5 is at index {pets.IndexOfValue("P5")}");//IndexOfValue
            Console.WriteLine($"Length is:{pets.Count}");
        }
    }
}
