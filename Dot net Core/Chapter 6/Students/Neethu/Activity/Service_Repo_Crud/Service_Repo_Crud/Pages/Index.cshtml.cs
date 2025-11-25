using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Service_Repo_Crud.Models;
using Service_Repo_Crud.Services;
namespace Service_Repo_Crud.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IBookService _bookService;

        public IndexModel(IBookService bookService)
        {
            _bookService = bookService;
        }

        [BindProperty (SupportsGet =true)]
        public string Search {  get; set; }

        public int TotalCount { get; set; }
        public List<Book> BookList { get; set; }
        public void OnGet()
        {
            BookList = _bookService.GetBooks(Search);
            TotalCount = BookList.Count();
        }
        public void OnPost()
        {

        }
    }
}
