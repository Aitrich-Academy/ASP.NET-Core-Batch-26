using System.Collections;

namespace NonGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Queue
            Queue pets = new Queue();
            //Adding items to Queue
            pets.Enqueue("Parrot");
            pets.Enqueue("Cat");
            pets.Enqueue("Pigeon");
            pets.Enqueue("Dog");
            pets.Enqueue("Rabbit");
            //Removing item from Queue
            pets.Dequeue();
            //Displaying items 
            foreach (var item in pets) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(pets.Peek());//Displays first element 
            Console.WriteLine($"Length is :{pets.Count}");
        }
    }
}
