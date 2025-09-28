class student
{
    public string name;
    public int mark;
}
internal class Program
{
    private static void Main(string[] args)
    {
        List<student> students = new List<student>
        {
            new student { name = "Hanna", mark = 61 },
            new student{ name="Abooth",mark=99},
            new student{name="Fathima" ,mark=98} ,
            new student{ name="Poker", mark=58}
        };
        double averageMark = students.Average(s => s.mark);
        List<string> studentsAboveAverage = students
       .Where(s => s.mark > averageMark)
       .Select(s => s.name)
       .ToList();
        foreach (string name in studentsAboveAverage)
        {
            Console.WriteLine(name);
        }

    }
}