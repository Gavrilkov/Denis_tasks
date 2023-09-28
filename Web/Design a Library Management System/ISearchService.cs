using Design_a_Library_Management_System.Model;
using DesignLibraryManagementSystem.Models;

namespace Design_a_Library_Management_System
{
    public interface ISearchService
    {
        public Task<List<BookDTO>> SearchBooks(string query);
    }
}
