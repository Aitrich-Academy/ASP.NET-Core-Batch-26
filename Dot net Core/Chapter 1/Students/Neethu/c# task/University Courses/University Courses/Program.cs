internal class Program
{
    struct Course
    {
        public string CourseCode;
        public string CourseName;
        public int Credits;
    }
    private static void Main(string[] args)
    {
        Course[] courses = new Course[4];
        for (int i = 0; i < courses.Length; i++)
        {
            Console.WriteLine("Enter the Course Code");
            courses[i].CourseCode = Console.ReadLine();
            Console.WriteLine("Enter the Course name");
            courses[i].CourseName = Console.ReadLine();
            Console.WriteLine("Enter the credits");
            courses[i].Credits= Convert.ToInt32(Console.ReadLine());    

        }
        for (int i = 0;i < courses.Length;i++)
        {
            if(courses[i].Credits>3)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Course Code: " + courses[i].CourseCode);
                Console.WriteLine("Course Name: " + courses[i].CourseName);
                Console.WriteLine("Credits: " + courses[i].Credits);
                Console.WriteLine("---------------------------------------------------------");
            }
        }
    }
}