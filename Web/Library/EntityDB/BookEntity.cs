using System.Text.Json.Serialization;

namespace DesignLibraryManagementSystem.Models
{
    public class BookEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public virtual ICollection<TransactionEntity> LibraryTransaction { get; set; } = new List<TransactionEntity>();
    }
}
