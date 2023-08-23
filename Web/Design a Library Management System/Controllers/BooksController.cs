using Design_a_Library_Management_System.Model;
using DesignLibraryManagementSystem.Models;
using Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Design_a_Library_Management_System.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly LibraryContext _context;

        public BooksController(LibraryContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<BookDTO>>> GetBooks()
        {

            var Books = await _context.Book.ToListAsync();
            var BookDTOList = Books.Select(x => new BookDTO
            {
                Id = x.Id,
                Title = x.Title,
                Author = x.Author,
                ISBN = x.ISBN
            }).ToList();
            return Ok(BookDTOList);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<BookDTO>> GetBook(int id)
        {
            var books = await _context.Book.FindAsync(id);

            if (books == null)
            {
                return NotFound("book not found");
            }
            var bookDTO = new BookDTO()
            {
                Id = books.Id,
                Title = books.Title,
                Author = books.Author,
                ISBN = books.ISBN
            };
            return bookDTO;
        }

        [HttpPost("api/books")]
        public async Task<ActionResult<BookEntity>> PostBooks(BookDTO Books)
        {
            var bookEntity = new BookEntity();
            bookEntity.Title = Books.Title;
            bookEntity.Author = Books.Author;
            bookEntity.ISBN = Books.ISBN;

            _context.Book.Add(bookEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBook", new { id = bookEntity.Id }, bookEntity);
        }
    }
}
