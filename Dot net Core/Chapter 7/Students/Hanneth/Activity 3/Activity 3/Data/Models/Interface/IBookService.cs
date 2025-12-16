namespace Activity_3.Data.Models.Interface
{
    public interface IBookService
    {
        IList<Book> GetAllBooks();
        Book GetBookById(int id);
        IList<Book> searchBook(string search);

        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
    }
}
