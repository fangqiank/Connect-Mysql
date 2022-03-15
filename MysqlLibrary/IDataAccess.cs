using System.Collections.Generic;
using System.Threading.Tasks;

namespace MysqlLibrary
{
    public interface IDataAccess
    {
        Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionStr);
        Task SaveData<T>(string sql, T parameters, string connectionStr);
    }
}