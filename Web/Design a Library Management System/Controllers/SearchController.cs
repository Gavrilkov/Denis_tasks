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
        private readonly ISearchService _searchService;
        public SearchController(ISearchService searchService) { _searchService = searchService; }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDTO>>> GetBooks([FromQuery] string q)
        {

            var books = await _searchService.SearchBooks(q);

            if (books == null)
            {
                return NotFound("No such books have been found");
            }
            return Ok(books);
        }
    }
}
