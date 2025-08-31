using Encapsulation;

internal class Program
{
     static void Main(string[] args)
    {
        Pet dog = new Pet("Max", 3, "Labrador");
        Pet cat = new Pet("Whiskers", 2, "Persian");

        Pet[] petsForSale= {dog, cat};

         PetSeller petseller=new PetSeller(petsForSale);
        petseller.DisplayAvailablePets();
    }
}