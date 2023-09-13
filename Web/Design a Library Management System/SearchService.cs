using Design_a_Library_Management_System.Model;
using DesignLibraryManagementSystem.Models;
using Library;
using Microsoft.EntityFrameworkCore;

namespace Design_a_Library_Management_System
{
    public class SearchService : ISearchService
    {
        private readonly LibraryContext _context;

        public SearchService(LibraryContext context)
        {
            _context = context;
        }
        public async Task<List<BookDTO>> SearchBooks(string query)
        {
            var result = await _context.Book.Where(f => f.Title.Contains(query) || f.Author.Contains(query)).Select(d => new BookDTO
            {
                Id = d.Id,
                Title = d.Title,
                Author = d.Author,
                ISBN = d.ISBN
            }).ToListAsync();
            
            return result;
        }
    }
}
