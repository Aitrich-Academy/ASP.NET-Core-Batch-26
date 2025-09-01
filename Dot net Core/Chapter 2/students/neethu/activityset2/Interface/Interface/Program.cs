using Interface;

internal class Program
{
    private static void Main(string[] args)
    {
        Dog myDog = new Dog("Buddy", 3, "Labrador", "Golden");
        Console.WriteLine($"My dog's name is {myDog.Name}, it's a {myDog.Breed}, and it's {myDog.Age} years old.");

        Cat myCat = new Cat("Whiskers", 2, "Persian", "White");
        Console.WriteLine($"My cat's name is {myCat.Name}, it's a {myCat.Breed}, and it's {myCat.Age} years old.");
    }
}