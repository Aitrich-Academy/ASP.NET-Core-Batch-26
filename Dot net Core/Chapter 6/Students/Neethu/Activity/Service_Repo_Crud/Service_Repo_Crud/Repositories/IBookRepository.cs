using Service_Repo_Crud.Models;

namespace Service_Repo_Crud.Repositories
{
    public interface IBookRepository
    {
        List<Book> GetAllBookList(string ch);
        void Add(Book book);
        void Save();
        Book GetBook(int  id);  
        void Update(Book book);
        void Delete(Book book);
    }
}
