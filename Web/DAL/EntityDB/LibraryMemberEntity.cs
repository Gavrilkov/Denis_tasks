using System.Xml.Linq;
using System.Xml;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DesignLibraryManagementSystem.Models
{
    public class LibraryMemberEntity
    {
        public int MemberID { get; set; }
        public string Name { get; set; }
      
        public List<BookEntity> BooksBorrowed { get; set; } = new List<BookEntity>();

    }
}
