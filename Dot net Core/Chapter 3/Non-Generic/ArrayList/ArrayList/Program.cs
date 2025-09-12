
using System;
using System.Collections;
using System.Transactions;

namespace NonGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList
            ArrayList pet=new ArrayList();
            pet.Add("Dog");
            pet.Add("Parrot");
            pet.Add("Cat");
            pet.Add("Rabbit");
            pet.Add("Pigeon");
            //Displaying ArrayList using foreach
            Console.WriteLine("ArrayList");
            foreach(string p in pet)
            {
                Console.WriteLine(p);
            }
            //Length of ArrayList
            Console.WriteLine($"Length:{pet.Count}");
            //Removing an item from ArrayList
            pet.Remove("Dog");
            pet.RemoveAt(0);
            pet[1] = "Dog";//Update item at index 1
            //Displaying updated ArrayList
            Console.WriteLine("Updated ArrayList");
            foreach(string p in pet)
            {
                Console.WriteLine(p);
            }
            //checking an item in ArrayList
            Console.WriteLine("Enter name of pet that you want to check:");
            string check = Console.ReadLine();
            if (pet.Contains(check))
            {
                Console.WriteLine("Pet Found");
            }
            else
            {
                Console.WriteLine("Pet not found");
            }
            //Sorted ArrayList
            pet.Sort();
            Console.WriteLine("Sorted ArrayList");
            foreach (string p in pet)
            {
                Console.WriteLine(p);
            }
            //Insert an item into ArrayList
            pet.Insert(3, "Dog");
            Console.WriteLine("Updated ArrayList");
            foreach (string p in pet)
            {
                Console.WriteLine(p);
            }
        }
    }
}

