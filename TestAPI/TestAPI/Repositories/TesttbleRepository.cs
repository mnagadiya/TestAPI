using Microsoft.EntityFrameworkCore;
using TestAPI.Models;
using TestAPI.Models.Domain;

namespace TestAPI.Repositories
{
    public class TesttbleRepository : ITesttbleRepository
    {
        private readonly TestdbContext _context;
        public TesttbleRepository(TestdbContext context)
        {
            _context = context;
        }      

        public async Task<IEnumerable<Testtbl>> GetTesttblsAsync()
        {
            return await _context.Testtbls.ToListAsync();
        }
    }
}
