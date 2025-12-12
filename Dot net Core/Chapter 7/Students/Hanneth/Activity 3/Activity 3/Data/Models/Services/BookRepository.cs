using Activity_3.Data.Models.Interface;
using Microsoft.EntityFrameworkCore;

namespace Activity_3.Data.Models.Services
{
    public class BookRepository:IBookRepository
    {
        private readonly ApplicationDbContext _context;
        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }
       public IList<Book> GetAllBooks()
        {
            return _context.Booksss.ToList();
        }
       public Book GetBookById(int id)
        {
            return _context.Booksss.FirstOrDefault(b=>b.Id==id);
        }
       public IList<Book> searchBook(string search)
        {
                var bookList=_context.Booksss.Where(b=>b.Title.Contains(search)).ToList();
                return bookList;
        }
        public void AddBook(Book book)
        {
            _context.Booksss.Add(book);
            _context.SaveChanges();
        }
       public void UpdateBook(Book book)
        {
            _context.Update(book);
            _context.SaveChanges();
        }
       public void DeleteBook(int id)
        {
            var book = _context.Booksss.Find(id);
            if (book != null)
            {
                _context.Booksss.Remove(book);
                _context.SaveChanges();
            }
        }
    }
}
