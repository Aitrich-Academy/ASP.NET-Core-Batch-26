using System.Collections.Generic;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedList
            SortedList<string,string> pet= new SortedList<string,string>();
            //Adding items
            pet.Add("Parrot","Green");
            pet.Add("Pigeon","White");
            pet.Add("Rabbit","Grey");
            pet.Add("Cat","White");
            pet.Add("Dog","Black");
            //Displaying items
            Console.WriteLine("Sorted PetList");
            foreach(KeyValuePair<string,string> item in pet)
            {
                Console.WriteLine($"Pet {item.Key} is {item.Value}");
            }
            //Remove item
            pet.Remove("Rabbit");
            //Updated SortedList
            Console.WriteLine("Updated Sorted PetList");
            foreach (KeyValuePair<string, string> item in pet)
            {
                Console.WriteLine($"Pet {item.Key} is {item.Value}");
            }
            //Checking an item
            Console.WriteLine("Enter Pet that you want to check");
            string check= Console.ReadLine();
            if(pet.ContainsKey(check))
            {
                Console.WriteLine($"{check} found");
            }
            else
            {
                Console.WriteLine($"{check} not found");
            }

        }
    }
}
