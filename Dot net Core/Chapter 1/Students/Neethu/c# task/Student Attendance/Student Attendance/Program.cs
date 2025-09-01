internal class Program
{
    struct Student
    {
        public int RollNo;
        public string Name;
        public int Attendance;
    }
    private static void Main(string[] args)
    {
        Student[] students = new Student[5];
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine("Enter the Student Roll Number");
            students[i].RollNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Student name");
            students[i].Name = Console.ReadLine();
            Console.WriteLine("Enter the Attendance");
            students[i].Attendance = Convert.ToInt32(Console.ReadLine());

        }
        for (int i = 0;i < students.Length;i++)
        {
            if (students[i].Attendance<75)
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Roll Number: " + students[i].RollNo);
                Console.WriteLine("Student Name: " + students[i].Name);
                Console.WriteLine("Attendance: " + students[i].Attendance);
                Console.WriteLine("-----------------------------------------------");

            }
        }
    }
}