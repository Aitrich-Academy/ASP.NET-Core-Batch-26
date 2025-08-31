using class_and_object;

internal class Program
{
    private static void Main(string[] args)
    {
        Pet pet1= new Pet("Fluffy", "Cat", 3, 50.00);
        Pet pet2= new Pet("Buddy", "Dog", 2, 100.00);
        Pet pet3 = new Pet();

        Console.WriteLine("Pet 1 :");
        pet1.Display();
        Console.WriteLine();

        Console.WriteLine("Pet 2 :");
        pet2.Display();
        Console.WriteLine();

        Console.WriteLine("Pet 3 :");
        pet3.Name = "Tomy";
        pet3.Price=pet1.Price;
        Console.WriteLine("Enter the age");
        pet3.Age = Convert.ToInt32(Console.ReadLine());
        pet3.Display();
        Console.WriteLine();
    }
}