using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml;

namespace DesignLibraryManagementSystem.Models
{
    public class TransactionEntity
    {
        public int TransactionID { get; set; }
        public DateTime DueDate { get; set; }
       
        public LibraryMemberEntity MemberID { get; set; } = new LibraryMemberEntity();
       
        public BookEntity BookID { get; set; } = new BookEntity();
    }
}
