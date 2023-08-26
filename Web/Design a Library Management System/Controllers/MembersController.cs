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

        public async void Get()
        {
            await _memberService.GetLibraryMembers();

        }

        //public async Task<ActionResult<IEnumerable<LibraryMemberDTO>>> GetMembers()
        //{
        //  var result = await _memberService.GetLibraryMembers();
        //  return result;
        //}


        //[HttpGet("{id}")]

        //public async Task<ActionResult<LibraryMemberDTO>> GetMember(int id)
        //{
        //    var result = await _memberService.GetLibraryMember(id);
        //    return result;
        //}

        //[HttpPost]

        //public async Task<ActionResult<LibraryMemberEntity>> PostMembers(LibraryMemberDTO libraryMembers)
        //{
        //    var result = await _memberService.PostMembers(libraryMembers);
        //    return result;
        //}

    }
}
