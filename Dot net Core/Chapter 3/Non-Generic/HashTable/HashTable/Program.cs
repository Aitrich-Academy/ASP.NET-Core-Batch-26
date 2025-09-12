using System;
using System.Collections;

namespace NonGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HashTable
            Hashtable pets = new Hashtable();
            pets.Add("Parrot", "p1");
            pets.Add("Dog", "p2");
            pets.Add("Cat", "p3");
            pets.Add("Pigeon", "p4");
            pets.Add("Rabbit", "p5");
            foreach (DictionaryEntry entry in pets)
            {
                Console.WriteLine($"{entry.Key},{entry.Value}");
            }

            //Removing an item from HashTable
            pets.Remove("Cat");
            Console.WriteLine("Updated HashTable");
            foreach (DictionaryEntry entry in pets)
            {
                Console.WriteLine($"{entry.Key},{entry.Value}");
            }
            //length of HashTable
            Console.WriteLine($"Length is: {pets.Count}");
            //Checking an item in HashTable
            Console.WriteLine("Enter item to be checked");
            string check= Console.ReadLine();
            if(pets.Contains(check))
            {
                Console.WriteLine("Item found");
            }
            else
            {
                Console.WriteLine("Item not found");
            }

        }
    }
}
