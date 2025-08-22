using Encapsulation;

internal class Program
{
    private static void Main(string[] args)
    {
        Student s = new Student();

        s.Age = 20;            // Valid age
        s.ShowAge();           // Output: Student Age: 20

        s.Age = 3;             // Invalid age (too young)
        s.ShowAge();           // Output: Invalid age entered.
    }
}