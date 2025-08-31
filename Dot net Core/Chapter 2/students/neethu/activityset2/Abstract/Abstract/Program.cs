using Abstract;

internal class Program
{
    private static void Main(string[] args)
    {
        Dog dog = new Dog("Buddy", 3, "Labrador");
        Cat cat = new Cat("Whiskers", 2, "Siamese");

        Console.WriteLine("Dog:");
        Console.WriteLine($"Name:{dog.Name},Age: {dog.Age}, Breed: {dog.Breed} ");
        dog.MakeSound();

        Console.WriteLine("Cat:");
        Console.WriteLine($"Name:{cat.Name},Age: {cat.Age}, Breed: {cat.Breed} ");
        cat.MakeSound();
    }
}