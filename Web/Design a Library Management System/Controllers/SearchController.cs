using Design_a_Library_Management_System.Model;
using Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Design_a_Library_Management_System.Controllers
{
    [ApiController]
    [Route("api/search")]
    public class SearchController : ControllerBase
    {
        private readonly LibraryContext _context;

        public SearchController(LibraryContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDTO>>> GetBooks([FromQuery] string q)
        {
            if (string.IsNullOrWhiteSpace(q))
            {
                return BadRequest("Search query cannot be empty.");
            }
            var books = await _context.SearchBooks(q);
            var booksDTO = books.Select(k => new BookDTO()
            {
                Id = k.Id,
                Title = k.Title,
                Author = k.Author,
                ISBN = k.ISBN,
            }).ToList();

            if (books.Count == 0)
            {
                return NotFound();
            }

            return Ok(booksDTO);
        }
    }
}
