using Blazor_Crud_Activity1.Data.Models;
using Blazor_Crud_Activity1.Data.Repositories;

namespace Blazor_Crud_Activity1.Data.Services
{
    public class BookService:IBookService
    {

        private readonly IBookRepository _Repo;

        public BookService(IBookRepository repo)
        {
            _Repo = repo;
        }

        public IList<Book> GetAllBooks()
        {
            return _Repo.GetAllBooks();
        }

        public void AddBook(Book book)
        {
            _Repo.AddBook(book);
        }

        public Book GetBookById(int id)
        {
            return _Repo.GetBookById(id);
        }

        public void UpdateBook(Book book)
        {
            _Repo.UpdateBook(book);
        }

        public void DeleteBook(int id)
        {
            _Repo.DeleteBook(id);
        }
    }
}
