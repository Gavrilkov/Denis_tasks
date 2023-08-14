using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml;

namespace DesignLibraryManagementSystem.Models
{
    public class TransactionEntity
    {
//        •	Properties:
//•	TransactionID: An integer representing the unique ID of the transaction.
//•	Borrower: A reference to a LibraryMember object representing the member who borrowed the book.
//•	BookBorrowed: A reference to a Book object representing the borrowed book.
//•	DueDate: A date indicating the due date for returning the book.

        public int TransactionID { get; set; }
        public DateTime DueDate { get; set; }

       
        public LibraryMemberEntity MemberID { get; set; } = new LibraryMemberEntity();
       
        public BookEntity BookID { get; set; } = new BookEntity();
    }
}
