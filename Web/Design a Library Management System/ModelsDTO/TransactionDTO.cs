using DesignLibraryManagementSystem.Models;
using Library;

namespace Design_a_Library_Management_System.Model
{
    public class TransactionDTO
    {
        public int TransactionID { get; set; }
        public DateTime DueDate { get; set; }
        public int MemberIDDTO { get; set; }
        public int BookIDDTO { get; set; }
    }
}