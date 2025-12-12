using Blazor_Crud_Activity3.Data.Models;

namespace Blazor_Crud_Activity3.Data.Services
{
    public interface IBookService
    {
        public IList<Book> GetAllBooks();

        public void AddBook(Book book);
        public Book GetBookById(int id);

        public void UpdateBook(Book book);
        public void DeleteBook(int id);

        public List<Book> GetBookByName(string name);
    }
}
