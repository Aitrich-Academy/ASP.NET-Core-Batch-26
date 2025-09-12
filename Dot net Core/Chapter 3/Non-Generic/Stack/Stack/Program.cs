using System.Collections;

namespace NonGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack
            Stack pets=new Stack();
            //Adding items
            pets.Push("Parrot");
            pets.Push("Pigeon");
            pets.Push("Cat");
            pets.Push("Dog");
            pets.Push("Rabbit");
            //Removing item
            pets.Pop();
            //Displaying items in Stack
            foreach (var item in pets) 
            { 
                Console.WriteLine(item);
            }
            Console.WriteLine($"Length : {pets.Count}");
            //Checking an item
            Console.WriteLine("Enter item that you want to check");
            string check=Console.ReadLine();
            if(pets.Contains(check))
            {
                Console.WriteLine($"{check}  found");
            }
            else
            {
                Console.WriteLine($"{check} not found");
            }
        }
    }
}
