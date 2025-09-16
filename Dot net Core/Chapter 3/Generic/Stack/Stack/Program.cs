using System;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack
            Stack<string> pet = new Stack<string>();
            //Adding items
            pet.Push("Parrot");
            pet.Push("Pigeon");
            pet.Push("Cat");
            pet.Push("Rabbit");
            pet.Push("Dog");
            //Displaying items
            Console.WriteLine("Pet List");
            foreach (var item in pet) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Length is :{pet.Count}");
            //First item
            Console.WriteLine($"First item in the Stack is {pet.Peek()}");
            //Remove item
            pet.Pop();
            Console.WriteLine($"First item in the Stack is {pet.Peek()}");
            //checking an item 
            Console.WriteLine("Enter pet name that you want to check ");
            string check= Console.ReadLine();
            if(pet.Contains(check))
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
