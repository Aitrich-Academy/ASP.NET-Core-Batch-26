public class Program
{
    private static void Main(string[] args)
    {
        // Declare the array  
        string[][] roles = new string[2][];

        // Initialize the array          
        roles[0] = new string[] { "JobProvider" };
        roles[1] = new string[] { "JobSeeker", "JobProvider", "CompanyMember" };

        // Traverse array elements  
        for (int i = 0; i < roles.Length; i++)
        {
            for (int j = 0; j < roles[i].Length; j++)
            {
                System.Console.Write(roles[i][j] + " ");
            }
            Console.WriteLine();
        }
     

    }
}