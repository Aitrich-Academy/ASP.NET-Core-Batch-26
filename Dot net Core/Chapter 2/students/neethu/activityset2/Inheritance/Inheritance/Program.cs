using Inheritance;   
class Program
{
     static void Main(string[] args)
    {
        Dog dog = new Dog("Buddy", 5, "Labrador", "Ball");
        Cat cat = new Cat("Fluffy", 3, "Persian", true);

        Console.WriteLine("Dog Details:");
        dog.DisplayDogDetails();
        Console.WriteLine("\nCat Details:");
        cat.DisplayCatDetails();
    }
}