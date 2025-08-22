using System;
internal class Program
{
    struct Student
    {
        public string Sname;
        public double mark1;
        public double mark2;
        public double mark3;
    }
    private static void Main(string[] args)
    {
        Student[] students = new Student[5];
        string ch;
        double average;
        do
        {
            Console.WriteLine("Enter Your Name: ");
            students[0].Sname = Console.ReadLine();
            Console.WriteLine("Enter Mark1: ");
            students[0].mark1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Mark2: ");
            students[0].mark2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Mark3: ");
            students[0].mark3 = Convert.ToDouble(Console.ReadLine());
            average = (students[0].mark1 + students[0].mark2 + students[0].mark3) / 3;
            Console.WriteLine("Average is : "+average);
            if(average>=90)
            {
                Console.WriteLine("Grade is: A");
            }
            else if(average>=75&&average<90)
            {
                Console.WriteLine("Grade is: B");
            }
            else if (average >= 50 && average < 75)
            {
                Console.WriteLine("Grade is: C");
            }
            else if(average<50)
            {
                Console.WriteLine("Grade is: F");
            }
            Console.WriteLine("Do you want to enter another student?(y/n)");
            ch=Console.ReadLine();
            


        } while (ch == "y"  || ch =="Y");

    }
}