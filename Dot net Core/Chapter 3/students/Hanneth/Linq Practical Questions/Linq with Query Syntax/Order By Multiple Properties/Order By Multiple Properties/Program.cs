using System.Reflection;

class Book
{
    public string Title;
    public string Author;
    public int Year;
}
internal class Program
{
    private static void Main(string[] args)
    {
       List<Book> Booklist = new List<Book>
       {
           new Book{Title="abcd",Author="Madhav",Year=1982},
           new Book{Title="ccdd",Author="Komal",Year=1981},
           new Book{Title="efgh",Author="Madhav",Year=1983},
           new Book{Title="hijk",Author="Komal",Year=1982},
           new Book{Title="lmno",Author="Madhav",Year=1982},
       };
        var orderedList = from book in Booklist orderby book.Author, book.Year select book;
        foreach (Book b in orderedList)
        {
            Console.WriteLine($"{b.Title}  {b.Author}  {b.Year}");
        }
    }
}