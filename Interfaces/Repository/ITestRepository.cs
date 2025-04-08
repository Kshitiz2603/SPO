namespace Interfaces{
    public interface ITestRepository {
        Task<List<studentDetails>> GetAllStudents();
    }
}