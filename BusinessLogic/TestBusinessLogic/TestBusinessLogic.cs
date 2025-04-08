using System;
using Interfaces;

namespace BL{
    public class TestBusinessLogic : SPOBusinessLogicBase, ITestBusinessLogic
    {
        private readonly ITestRepository _repository;
        public TestBusinessLogic(ITestRepository respository):base()
        {
            _repository = respository;    
        }

        public async Task<List<studentDetails>> GetAllStudents()
        {
            return await _repository.GetAllStudents();
        }
    }
}