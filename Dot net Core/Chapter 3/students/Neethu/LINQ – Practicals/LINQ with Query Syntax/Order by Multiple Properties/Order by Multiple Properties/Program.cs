using Order_by_Multiple_Properties;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Book> books = new List<Book>
        {
            new Book{Title="Harry potter",Author="J K Rowling",Year=1990},
            new Book{Title="Pride and Prejudice",Author="Jane Austen",Year=1813},
            new Book{Title="Frankenstein", Author="Mary Shelley", Year=1818},
            new Book{Title="The Alchemist", Author="Paulo Coelho ", Year=1988},
            new Book{Title="The Da Vinci Code", Author="Dan Brown", Year=2003},
            new Book{Title="War and Peace",Author="Leo Tolstoy",Year=1869}



        };
        var orderbyAuthor = from creations in books orderby creations.Author select creations;
        Console.WriteLine("Sorted book list based on Author names");
        foreach(var book in orderbyAuthor)
        {
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Year: {book.Year}");


        }
        var orderbyYear=from booklist in books orderby booklist.Year select booklist;
        Console.WriteLine("\n\nSorted book list based on Year");
        foreach (var book in orderbyYear)
        {
            Console.WriteLine($"Year: {book.Year}");
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine($"Title: {book.Title}");
            


        }
    }
}