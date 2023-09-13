using Design_a_Library_Management_System.Model;
using DesignLibraryManagementSystem.Models;
using Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Design_a_Library_Management_System.Controllers
{
    [ApiController]
    [Route("api/members")]
    public class MembersController : Controller
    {
        private readonly IMemberService _memberService;

        public MembersController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        [HttpGet]
        
        public async Task<ActionResult<IEnumerable<LibraryMemberDTO>>> GetMembers()
        {
            var result = await _memberService.GetLibraryMembers();
            return Ok(result);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<LibraryMemberDTO>> GetMember(int id)
        {
            var result = await _memberService.GetLibraryMember(id);
            if (result == null) 
            { 
            return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]

        public async Task<ActionResult<LibraryMemberDTO>> PostMembers(LibraryMemberDTO libraryMembers)
        {
            var createdMember = await _memberService.PostMembers(libraryMembers);
            return CreatedAtAction("GetMember", new { id = createdMember.MemberID }, createdMember);
        }
    }
}
