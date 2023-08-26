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
        private readonly SearchService _searchService;
        public SearchController(SearchService searchService) { _searchService = searchService; }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDTO>>> GetBooks([FromQuery] string q)
        {

            var books = await _searchService.SearchBooks(q);
            var booksDTO = books.Select(k => new BookDTO()
            {
                Id = k.Id,
                Title = k.Title,
                Author = k.Author,
                ISBN = k.ISBN,
            }).ToList();

            if (books.Count == 0)
            {
                return NotFound("No such books have been found");
            }
            return Ok(booksDTO);
        }
    }
}
