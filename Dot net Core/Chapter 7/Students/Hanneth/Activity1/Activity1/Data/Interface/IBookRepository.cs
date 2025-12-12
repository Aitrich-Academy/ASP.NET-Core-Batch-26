using Activity1.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace Activity1.Data.Interface
{
    public interface IBookRepository
    {
     IList<Book> GetAllBooks();
      Book  GetBookById(int id);
       void UpdateBook(Book book);
        void AddBook(Book book);
       void DeleteBook(int id);
    }
}
