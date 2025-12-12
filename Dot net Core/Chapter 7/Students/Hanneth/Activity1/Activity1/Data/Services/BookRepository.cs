using Activity1.Data.Interface;
using Activity1.Data.Model;

namespace Activity1.Data.Services
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;
        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<Book> GetAllBooks()
        {
            var book = _context.books.ToList();
            return book;
        }
        public Book GetBookById(int id)
        {
            var book = _context.books.FirstOrDefault(b => b.Id == id);
            return book;
        }
        public void AddBook(Book book)
        {
            _context.books.Add(book);
            _context.SaveChanges();
        }
        public void UpdateBook(Book book)
        {
            _context.books.Update(book);
            _context.SaveChanges();
        }
        public void DeleteBook(int id)
        {
            var book = _context.books.Find(id);
            if (id != null)
            {
                _context.books.Remove(book);
                _context.SaveChanges();
            }
        }
    }
}
