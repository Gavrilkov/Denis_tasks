using Design_a_Library_Management_System.Model;
using DesignLibraryManagementSystem.Models;
using Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using static System.Reflection.Metadata.BlobBuilder;

namespace DesignLibraryManagementSystem.Controllers
{
    [ApiController]
 //   [Route("DesignLibraryManagement/Api")]
    
    public class DesignLibraryManagementController : ControllerBase
    {
        private readonly LibraryContext _context;

        public DesignLibraryManagementController(LibraryContext context)
        {
            _context = context;
        }

        [HttpGet("books")]

        public async Task<ActionResult<IEnumerable<BookEntity>>> GetBooks()
        {
            return await _context.Book.ToListAsync();
        }

        [HttpGet("books/{id}")]

        public async Task<ActionResult<BookEntity>> GetBook(int id)
        {
            var Books = await _context.Book.FindAsync(id);

            if (Books == null)
            {
                return NotFound();
            }

            return Books;
        }

        [HttpPost("books")]
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

        [HttpGet("members")]
        public async Task<ActionResult<IEnumerable<LibraryMemberEntity>>> GetLibraryMembers()
        {
            return await _context.LibraryMember.ToListAsync();
        }

        [HttpGet("members/{id}")]

        public async Task<ActionResult<LibraryMemberEntity>> GetLibraryMember(int id)
        {
            var LibraryMembers = await _context.LibraryMember.FindAsync(id);

            if (LibraryMembers == null)
            {
                return NotFound();
            }

            return LibraryMembers;
        }

        [HttpPost("members")]

        public async Task<ActionResult<LibraryMemberEntity>> PostMembers(LibraryMemberDTO libraryMembers)
        {
            var libraryMemberEntity = new LibraryMemberEntity();
            libraryMemberEntity.Name = libraryMembers.Name;

            _context.LibraryMember.Add(libraryMemberEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLibraryMember", new { id = libraryMemberEntity.MemberID }, libraryMemberEntity);
        }

        [HttpGet("bookings")]
        public async Task<ActionResult<IEnumerable<TransactionEntity>>> GetBookings()
        {
            return await _context.LibraryTransaction.ToListAsync();
        }

        [HttpGet("bookings/{id}")]
        public async Task<ActionResult<TransactionEntity>> GetBooking(int id)
        {
            var booking = await _context.LibraryTransaction.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            return booking;
        }

        [HttpPost("bookings")]
        public async Task<ActionResult<TransactionEntity>> PostBookings(TransactionDTO bookings)
        {
            var transactionEntity = new TransactionEntity();
        //    transactionEntity.TransactionID = bookings.TransactionID;
            transactionEntity.DueDate = bookings.DueDate;

            var libraryMember = await _context.LibraryMember.FirstOrDefaultAsync(member => member.MemberID == bookings.MemberID);

            if (libraryMember == null)
            {
                return NotFound();
            }
            transactionEntity.MemberID = libraryMember;

            var book = await _context.Book.FirstOrDefaultAsync(b => b.Id == bookings.BookID);
            if (book == null)
            {
                return NotFound();
            }
            transactionEntity.BookID = book;

            _context.LibraryTransaction.Add(transactionEntity);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetBooking", new { id = transactionEntity.TransactionID }, transactionEntity);
        }
    }
}