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
    [Route("api/bookings")]
    
    public class BookingsController : ControllerBase
    {
        private readonly LibraryContext _context;

        public BookingsController(LibraryContext context)
        {
            _context = context;
        }

        [HttpGet]
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

        [HttpGet("{id}")]
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

        [HttpPost]
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