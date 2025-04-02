namespace Interfaces{
    public interface ITestRepository : ISPOBaseRepository
    {
        // Define methods for the test repository
        Task<List<studentDetails>> GetAllAsync();
    }
}