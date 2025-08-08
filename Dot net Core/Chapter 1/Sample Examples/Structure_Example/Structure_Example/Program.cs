struct Student
{
    public int Id;
    public string Name;
}
class Program
{
    static void Main()
    {
        Student s1;
        s1.Id = 1;
        s1.Name = "Anu";

        Console.WriteLine("ID: " + s1.Id);       // Output: ID: 1
        Console.WriteLine("Name: " + s1.Name);   // Output: Name: Anu
    }
}
