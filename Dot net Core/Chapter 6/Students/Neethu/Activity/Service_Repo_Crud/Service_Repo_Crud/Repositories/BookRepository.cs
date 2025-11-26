using Service_Repo_Crud.Data;
using Service_Repo_Crud.Models;

namespace Service_Repo_Crud.Repositories
{
    public class BookRepository:IBookRepository
    {
        private readonly LibraryDbContext _db;

        public BookRepository(LibraryDbContext db)
        {
            _db = db;
        }
        public List<Book> GetAllBookList(string ch)
        {
            if(ch == null)
            {
                return _db.BookTable.ToList();
            }
            else
            {
                return _db.BookTable.Where(b=>b.Title.Contains(ch)).ToList();
            }
        }
        public void Add(Book book)=>_db.BookTable.Add(book);
        public void Save()=>_db.SaveChanges();

        public Book GetBook(int id)=>_db.BookTable.FirstOrDefault(b=>b.BookId==id);
        public void Update(Book book)=>_db.BookTable.Update(book);

        public void Delete(Book book)=>_db.BookTable.Remove(book);
        
    }
}
