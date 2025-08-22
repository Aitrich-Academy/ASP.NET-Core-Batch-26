using class_object_method;

internal class Program
{
    private static void Main(string[] args)
    {
        Student s1 = new Student();

        // Assign value to field
        s1.name = "Rahul";

        // Call method
        s1.SayHello();
    }
}