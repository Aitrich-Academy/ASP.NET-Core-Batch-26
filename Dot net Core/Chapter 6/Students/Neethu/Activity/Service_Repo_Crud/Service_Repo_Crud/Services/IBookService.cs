using Service_Repo_Crud.Models;

namespace Service_Repo_Crud.Services
{
    public interface IBookService
    {
        List<Book> GetBooks(string ch);

        bool AddBook(Book book);
        Book GetBookById(int id);
        void UpdateBook(Book book);
        void DeleteBook(Book book);
    }
}
