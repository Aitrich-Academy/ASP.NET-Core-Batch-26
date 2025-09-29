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
        var pass=from student in students where student.mark>=60 select student.name;
        Console.WriteLine("Name                    Result");
        Console.WriteLine("--------------------------------");
        foreach (var re in pass)
        {
            Console.WriteLine($"{re}                    Pass");
        }
        var fail=from student in students where student.mark<60 select student.name;
        foreach (var re in fail)
        {
            Console.WriteLine($"{re}                        Fail");
        }
    }
}