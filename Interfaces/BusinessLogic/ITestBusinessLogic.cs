using System;

namespace Interfaces{
    public interface ITestBusinessLogic
    {
        Task<List<studentDetails>> GetAllStudents();
    }
}