using MethodOverload;

internal class Program
{
    private static void Main(string[] args)
    {
        Pet myPet = new Pet("Fluffy", 3);
        Dog myDog = new Dog("Buddy", 5, "Golden Retriever");

        Console.WriteLine("My Pet:");
        myPet.DisplayInfo();
        Console.WriteLine("\nMy Dog:");
        myDog.DisplayInfo(true);

        PetSeller petseller=new PetSeller("John",myPet);
        petseller.SellPet();


    }
}