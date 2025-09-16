using System;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary
            Dictionary<int,string> pet = new Dictionary<int,string>();
            //Adding items
            pet.Add(1, "Parrot");
            pet.Add(2, "Pigeon");
            pet.Add(3, "Rabbit");
            pet.Add(4, "Cat");
            pet.Add(5, "Dog");
            //Displaying items
            foreach(KeyValuePair<int,string> item in pet)
            {
                Console.WriteLine($"Key is {item.Key} and Value is {item.Value} ");
            }
            //Remove an item
            pet.Remove(3);
            //Updated Dictionary
            Console.WriteLine("Updated Dictionary");
            foreach (KeyValuePair<int, string> item in pet)
            {
                Console.WriteLine($"Key is {item.Key} and Value is {item.Value} ");
            }
        }
    }
}