public class Program
{
    private static void Main(string[] args)
    {
        //declaration of 2D array  
        string[,] roles = new string[2, 2];

        roles[0, 0] = "JobProvider";                //initialization  
        roles[0, 1] = "Admin";
        roles[1, 0] = "JobSeeker";
        roles[1, 1] = "CompanyMember";

        //traversal  
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(roles[i, j] + " ");
            }
            Console.WriteLine();            //new line at each row	
        }
       

    }
}