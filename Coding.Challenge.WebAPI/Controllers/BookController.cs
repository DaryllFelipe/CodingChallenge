using Coding.Challenge.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
namespace Coding.Challenge.WebAPI.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("get-books")]
        public async Task<IActionResult> Get([FromQuery] string searchText = "", [FromQuery] int size = 1, [FromQuery] int page = 1)
        {
            var books = await _bookService.GetBooksBySearch(searchText, size, page);
            return Ok(books);
        }
    }
}
