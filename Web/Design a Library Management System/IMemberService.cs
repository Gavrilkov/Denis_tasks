using Design_a_Library_Management_System.Model;
using DesignLibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Design_a_Library_Management_System
{
    public interface IMemberService
    {
        public  Task<IEnumerable<LibraryMemberDTO>> GetLibraryMembers();

        public  Task<LibraryMemberDTO> GetLibraryMember(int id);

        public  Task<LibraryMemberEntity> PostMembers(LibraryMemberDTO libraryMembers);
    }
}
