using Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        Dog myDog = new Dog();

        // Call method from parent class
        myDog.MakeSound();

        // Call method from child class
        myDog.Bark();

    }
}