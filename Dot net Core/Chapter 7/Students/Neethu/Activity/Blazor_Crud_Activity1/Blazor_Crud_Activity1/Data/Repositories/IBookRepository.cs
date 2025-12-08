using Blazor_Crud_Activity1.Data.Models;

namespace Blazor_Crud_Activity1.Data.Repositories
{
    public interface IBookRepository
    {

        public IList<Book> GetAllBooks();
        public void AddBook(Book book);

        public Book GetBookById(int id);

        public void UpdateBook(Book book);
        public void DeleteBook(int id);
    }
}
