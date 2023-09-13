using DesignLibraryManagementSystem.Models;

namespace Design_a_Library_Management_System
{
    public interface ISearchService
    {
        public Task<List<BookEntity>> SearchBooks(string query);
    }
}
