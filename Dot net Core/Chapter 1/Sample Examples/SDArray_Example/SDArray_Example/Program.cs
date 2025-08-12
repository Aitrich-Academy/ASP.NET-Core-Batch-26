public class Program
{
    private static void Main(string[] args)
    {
        // Example: Creating an integer array with 4 elements
        string[] roles = new string[4];

        // Assigning values to array elements
        roles[0] = "Company Member";
        roles[1] = "JobSeeker";
        roles[2] = "JobProvider";
        roles[3] = "Admin";

        // Iterating over array elements using a loop
        for (int i = 0; i < roles.Length; i++)
        {
            Console.WriteLine(roles[i]);
        }
       

    }
}