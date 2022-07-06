using BookStore.Core;
using Microsoft.AspNetCore.Mvc;

namespace MongoDBWith.NETCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly BooksServices booksServices;
        public BookController(BooksServices booksServices)
        {
            this.booksServices = booksServices;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(booksServices.GetBooks());
        }
    }
}
