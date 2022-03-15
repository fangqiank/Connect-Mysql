using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MysqlLibrary
{
    public class DataAccess : IDataAccess
    {
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionStr)
        {
            using (IDbConnection connection = new MySqlConnection(connectionStr))
            {
                var rows = await connection.QueryAsync<T>(sql, parameters);
                return rows.ToList();
            }
        }

        public Task SaveData<T>(string sql, T parameters, string connectionStr)
        {
            using (IDbConnection connection = new MySqlConnection(connectionStr))
            {
                return connection.ExecuteAsync(sql, parameters);
            }
        }
    }
}
