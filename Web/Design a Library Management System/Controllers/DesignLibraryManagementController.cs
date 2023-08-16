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

        [HttpGet("api/books")]

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

        [HttpGet("books/{id}")]

        public async Task<ActionResult<BookDTO>> GetBook(int id)
        {
            var Books = await _context.Book.FindAsync(id);

            if (Books == null)
            {
                return NotFound();
            }
            var bookDTO = new BookDTO()
            {
                Id = Books.Id,
                Title = Books.Title,
                Author = Books.Author,
                ISBN = Books.ISBN
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

        [HttpGet("api/members")]
        public async Task<ActionResult<IEnumerable<LibraryMemberDTO>>> GetLibraryMembers()
        {
            var libraryMembers = await _context.LibraryMember.ToListAsync();
            var libraryMembersDTOList = libraryMembers.Select(x => new LibraryMemberDTO()
            {
                MemberID = x.MemberID,
                Name = x.Name
            }).ToList();
            return libraryMembersDTOList;
        }

        [HttpGet("api/members/{id}")]

        public async Task<ActionResult<LibraryMemberDTO>> GetLibraryMember(int id)
        {
            var libraryMember = await _context.LibraryMember.FindAsync(id);

            if (libraryMember == null)
            {
                return NotFound();
            }
            var libraryMemberDTO = new LibraryMemberDTO()
            {
                MemberID = libraryMember.MemberID, 
                Name = libraryMember.Name
            };
            return libraryMemberDTO;
        }

        [HttpPost("api/members")]

        public async Task<ActionResult<LibraryMemberEntity>> PostMembers(LibraryMemberDTO libraryMembers)
        {
            var libraryMemberEntity = new LibraryMemberEntity();
            libraryMemberEntity.Name = libraryMembers.Name;

            _context.LibraryMember.Add(libraryMemberEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLibraryMember", new { id = libraryMemberEntity.MemberID }, libraryMemberEntity);
        }

        [HttpGet("api/bookings")]
        public async Task<ActionResult<IEnumerable<TransactionDTO>>> GetBookings()
        {
            var transactionDTO = new TransactionDTO();

            var booking = await _context.LibraryTransaction.Include(t => t.MemberID).Include(t => t.BookID).ToListAsync();

            if (booking == null)
            {
                return NotFound();
            }
            var transactionDTOList = booking.Select(booking => new TransactionDTO
            {
                TransactionID = booking.TransactionID,
                DueDate = booking.DueDate,
                MemberIDDTO = booking.MemberID.MemberID,
                BookIDDTO = booking.BookID.Id
            }).ToList();
            return transactionDTOList;
        }

        [HttpGet("bookings/{id}")]
        public async Task<ActionResult<TransactionDTO>> GetBooking(int id)
        {
            var transactionDTO = new TransactionDTO();
            var booking = await _context.LibraryTransaction.Include(t => t.MemberID).Include(t => t.BookID).FirstOrDefaultAsync(t => t.TransactionID == id);

            if (booking == null)
            {
                return NotFound();
            }
            transactionDTO.DueDate = booking.DueDate;
            transactionDTO.TransactionID = booking.TransactionID;
            transactionDTO.MemberIDDTO = booking.MemberID.MemberID;
            transactionDTO.BookIDDTO = booking.BookID.Id;

            return transactionDTO;
        }

        [HttpPost("api/bookings")]
        public async Task<ActionResult<TransactionDTO>> PostBookings(TransactionDTO bookings)
        {
            var transactionEntity = new TransactionEntity();
        //    transactionEntity.TransactionID = bookings.TransactionID;
            transactionEntity.DueDate = bookings.DueDate;

            var libraryMember = await _context.LibraryMember.FirstOrDefaultAsync(member => member.MemberID == bookings.BookIDDTO);

            if (libraryMember == null)
            {
                return NotFound();
            }
            transactionEntity.MemberID = libraryMember;

            var book = await _context.Book.FirstOrDefaultAsync(b => b.Id == bookings.BookIDDTO);
            if (book == null)
            {
                return NotFound();
            }
            transactionEntity.BookID = book;

            _context.LibraryTransaction.Add(transactionEntity);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetBooking", new { id = transactionEntity.TransactionID }, bookings);
        }
    }
}