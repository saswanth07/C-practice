using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetBooks()
        {
            var books = new[] {
                new { Id = 1, Title = "C# Basics" },
                new { Id = 2, Title = "Learning .NET Core" }
            };
            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            var book = new { Id = id, Title = $"Sample Book {id}" };
            return Ok(book);
        }
    }
}
