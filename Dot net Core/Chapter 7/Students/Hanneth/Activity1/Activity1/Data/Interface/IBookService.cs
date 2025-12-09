using Activity1.Data.Model;

namespace Activity1.Data.Interface
{
    public interface IBookService
    {
        IList<Book> GetAllBooks();
        Book GetBookById(int id);
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);

    }
}
