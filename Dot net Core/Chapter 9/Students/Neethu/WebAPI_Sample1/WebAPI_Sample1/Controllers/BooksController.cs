using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Sample1.Models;

namespace WebAPI_Sample1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly AppDbContext context;
        public BooksController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public ActionResult GetBooks()
        {
            var books = context.Books.ToList();
            return Ok(books);
        }
        [HttpGet("{id}")]
        public ActionResult GetBook(int id)
        {
            var book=context.Books.FirstOrDefault(b=>b.Id==id);
            if (book==null)
            {
                return NotFound();
            }
            return Ok(book);
        }
        [HttpPost]
        public ActionResult PostBook(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
            return Ok(book);
        }
        [HttpPut("{id}")]
         public ActionResult PutBook(int id,Book book)
        {
            if(id!=book.Id)
            {
                return BadRequest();
            }
            context.Books.Update(book);
            context.SaveChanges();
            return Ok(book);

        }
        [HttpDelete("{id}")]
        public ActionResult DeleteBook(int id)
        {
            var book = context.Books.Find(id);
            if(book==null)
            {
                return NotFound();
            }
            context.Books.Remove(book);
            context.SaveChanges();
            return Ok(book);
        }
    }
}
