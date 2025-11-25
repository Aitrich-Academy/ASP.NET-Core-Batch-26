using Service_Repo_Crud.Models;
using Service_Repo_Crud.Repositories;

namespace Service_Repo_Crud.Services
{
    public class BookService: IBookService
    {
        private readonly IBookRepository _Repo;

        public BookService(IBookRepository bookRepository)
        {
            _Repo = bookRepository;
        }
        public List<Book> GetBooks(string ch)
        {
            return _Repo.GetAllBookList(ch);


        }
        public bool AddBook(Book book)
        {
            _Repo.Add(book);
            _Repo.Save();
            return true;

        }
        public Book GetBookById(int id)
        {
            return _Repo.GetBook(id);
        }

        public void UpdateBook(Book book)
        {
            _Repo.Update(book);
            _Repo.Save();
        }
        public void DeleteBook(Book book)
        {
            _Repo.Delete(book);
            _Repo.Save();
        }
    }
}
