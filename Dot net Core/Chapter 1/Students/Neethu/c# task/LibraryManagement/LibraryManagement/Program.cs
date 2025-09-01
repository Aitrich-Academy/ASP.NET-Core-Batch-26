internal class Program
{
    struct Book
    {
        public int BookId;
        public string Title;
        public string Author;
    }
    private static void Main(string[] args)
    {
        Book[] books = new Book[5];
        for(int i=0;i<books.Length;i++)
        {
            Console.WriteLine("Enter the Book ID");
            books[i].BookId=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Book Title");
            books[i].Title = Console.ReadLine();
            Console.WriteLine("Enter the Book Author's Name");
            books[i].Author = Console.ReadLine();

        }
        Console.WriteLine("/nBook Details in Library Collection");
        for(int i=0;i < books.Length;i++)
        {
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Book ID: " + books[i].BookId);
            Console.WriteLine("Book Title: " + books[i].Title);
            Console.WriteLine("Author Name: " + books[i].Author);
            Console.WriteLine("-----------------------------------------------------------------------------");
        }
    }
}