using Activity_3.Data.Models.Interface;

namespace Activity_3.Data.Models.Services
{
    public class BookService:IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public IList<Book> GetAllBooks()
        {
           return _bookRepository.GetAllBooks();
        }
       public Book GetBookById(int id)
        {
            return _bookRepository.GetBookById(id);
        }
       public IList<Book> searchBook(string search)
        {
            return _bookRepository.searchBook(search);
        }
        public void AddBook(Book book)
        {
            _bookRepository.AddBook(book);
        }
       public void UpdateBook(Book book)
        {
            _bookRepository.UpdateBook(book);
        }
        public void DeleteBook(int id)
        { 
            _bookRepository.DeleteBook(id);
        }
    }
}
