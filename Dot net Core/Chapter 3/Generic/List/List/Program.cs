using System.Collections.Generic;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List
            List<string> petList = new List<string>();
            //Adding items to List
            petList.Add("Parrot");
            petList.Add("Pigeon");
            petList.Add("Rabbit");
            petList.Add("Cat");
            petList.Add("Dog");
            //Removing item
            petList.Remove("Rabbit");
            //Displaying items
            Console.WriteLine("Pet List:-");
            int c = 0;
            foreach (string pet in petList)
            {
                Console.Write("At Position {0} ",c);
                Console.WriteLine(pet);
                c++;
            }

            Console.WriteLine($"Length is :{ petList.Count}");//Length of List
            petList.RemoveAt(1);//Removing item from index 1
            int p = 0;
            foreach (string pet in petList)
            {
                Console.Write("At Position {0} ",p);
                Console.WriteLine(pet);
                p++;
            }

        }
    }
}
