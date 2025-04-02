

namespace Core{
    public interface IDataAccess
    {
        string connectionString { get; set; }

        int CommandTimeout { get; set; }

        Task<List<dynamic>> ExecuteStoredProcedureAsync(string sp, object parameters);
        Task<List<dynamic>> ExecuteStoredProcedureWithParamAsync(string sp, object parameters);

        Task<List<T>> ExecuteStoredProcedureAsync<T>(string sp, object parameters);
        Task<List<T>> ExecuteStoredProcedureWithParamAsync<T>(string sp, object parameters);
    }
}