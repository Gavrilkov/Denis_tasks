using Design_a_Library_Management_System.Model;
using DesignLibraryManagementSystem.Models;
using Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Design_a_Library_Management_System.Controllers
{
    [ApiController]
    [Route("api/members")]
    public class MembersController : ControllerBase
    {
        private readonly LibraryContext _context;

        public MembersController(LibraryContext context)
        {
            _context = context;
        }

        [HttpGet]
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

        [HttpGet("{id}")]

        public async Task<ActionResult<LibraryMemberDTO>> GetLibraryMember(int id)
        {
            var libraryMember = await _context.LibraryMember.FindAsync(id);

            if (libraryMember == null)
            {
                return NotFound("libraryMember not found");
            }
            var libraryMemberDTO = new LibraryMemberDTO()
            {
                MemberID = libraryMember.MemberID,
                Name = libraryMember.Name
            };
            return libraryMemberDTO;
        }

        [HttpPost]

        public async Task<ActionResult<LibraryMemberEntity>> PostMembers(LibraryMemberDTO libraryMembers)
        {
            var libraryMemberEntity = new LibraryMemberEntity();
            libraryMemberEntity.Name = libraryMembers.Name;

            _context.LibraryMember.Add(libraryMemberEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLibraryMember", new { id = libraryMemberEntity.MemberID }, libraryMemberEntity);
        }

    }
}
