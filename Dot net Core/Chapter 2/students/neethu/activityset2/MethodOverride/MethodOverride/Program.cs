using MethodOverride;

internal class Program
{
    private static void Main(string[] args)
    {
        PetSeller pet1 = new PetSeller("Buddy", 3, "Labrador", 500);
        PetSeller pet2 = new PetSeller("Whiskers", 2, "Persian Cat", 300);

        Console.WriteLine("Pet 1 Details:");
        pet1.Display();

        Console.WriteLine("\nPet 2 Details:");
        pet2.Display();
    }
}