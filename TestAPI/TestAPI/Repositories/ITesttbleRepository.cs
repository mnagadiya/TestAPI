using TestAPI.Models.Domain;

namespace TestAPI.Repositories
{
    public interface ITesttbleRepository
    {
        Task<IEnumerable<Testtbl>> GetTesttblsAsync();
    }
}
