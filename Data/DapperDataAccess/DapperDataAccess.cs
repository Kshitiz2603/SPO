using System;
using System.Data;
using Core;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using Dapper;

namespace Data{
    public partial class DapperDataAccess : IDataAccess
    {
        public string connectionString { get; set; }
        public int CommandTimeout { get; set; }

        public DapperDataAccess(string connectionString, int commandTimeout)
        {
            this.connectionString = connectionString;
            this.CommandTimeout = commandTimeout;
        }

        public async Task<MySqlConnection> GetOpenConnectionAsync(){
            MySqlConnection connection = new MySqlConnection(connectionString);

            await connection.OpenAsync();
            return connection;
        }

        public async Task<List<dynamic>> ExecuteStoredProcedureAsync(string sp, object parameters)
        {
            using(var connection = await GetOpenConnectionAsync()){
                return (await connection.QueryAsync(sp, commandType: CommandType.StoredProcedure)).AsList();
            }
        }

        public async Task<List<dynamic>> ExecuteStoredProcedureWithParamAsync(string sp, object parameters)
        {
            using(var connection = await GetOpenConnectionAsync()){
                return (await connection.QueryAsync(sp, commandType: CommandType.StoredProcedure)).AsList();
            }
        }

        public async Task<List<T>> ExecuteStoredProcedureAsync<T>(string sp, object parameters)
        {
            using(var connection = await GetOpenConnectionAsync()){
                return (await connection.QueryAsync<T>(sp, commandType: CommandType.StoredProcedure)).AsList();
            }
        }

        public async Task<List<T>> ExecuteStoredProcedureWithParamAsync<T>(string sp, object parameters)
        {
            using(var connection = await GetOpenConnectionAsync()){
                return (await connection.QueryAsync<T>(sp, commandType: CommandType.StoredProcedure)).AsList();
            }
        }
    }

}