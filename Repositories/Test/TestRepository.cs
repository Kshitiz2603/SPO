using Interfaces;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Repositories{
    public class TestRepository : SPOBaseRepository, ITestRepository{

        public TestRepository(IDbManager dbManager) : base(dbManager)
        {
            // Constructor logic here
        }

        public async Task<List<studentDetails>> GetAllStudents()
        {
            // Implement the logic to get all records from the database
            // For example, using Dapper or Entity Framework
            return await _db.PortalDb.ExecuteStoredProcedureAsync<studentDetails>("GetAllUsers",new{

            });
        }

        // Add specific database operations for TestRepository here
    }
}