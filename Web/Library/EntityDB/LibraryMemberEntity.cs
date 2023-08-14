using System.Xml.Linq;
using System.Xml;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DesignLibraryManagementSystem.Models
{
    public class LibraryMemberEntity
    {
//        •	MemberID: An integer representing the unique ID of the library member.
//•	Name: A string representing the name of the library member.
//•	BooksBorrowed: A list of Book objects representing the books borrowed by the member.
 
        public int MemberID { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public List<BookEntity> BooksBorrowed { get; set; } = new List<BookEntity>();
     //   public  List<LibraryTransaction> LibraryTransaction { get; set; } = new List<LibraryTransaction>();

        public void BorrowBook(BookEntity book)
        {
            BooksBorrowed.Add(book);
        }

        public void ReturnBook(BookEntity book)
        {
            BooksBorrowed.Remove(book);
        }

    }
}
