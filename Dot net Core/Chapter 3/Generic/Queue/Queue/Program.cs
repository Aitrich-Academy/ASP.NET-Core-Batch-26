using System.Collections.Generic;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Queue
            Queue<string> pet = new Queue<string>();
            //Adding items
            pet.Enqueue("Parrot");
            pet.Enqueue("Pigeon");
            pet.Enqueue("Rabbit");
            pet.Enqueue("Cat");
            pet.Enqueue("Cow");
            //Displaying queue items
            Console.WriteLine("Pet List:-");
            foreach (var item in pet)
            {
                Console.WriteLine(item);
            }
            //first item in queue
            Console.WriteLine("First item in the Queue is {0}", pet.Peek());
            pet.Dequeue();
            Console.WriteLine("First item in the Queue is {0}", pet.Peek());
            Console.WriteLine("Length is {0}", pet.Count);
        }
    }
}