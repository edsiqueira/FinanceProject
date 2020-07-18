using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ISqlDataFactory
{
    public interface IDBManager
    {
        IDbConnection GetDatabaseConnection();
        public void CloseConnection(IDbConnection connection);
        public IDbDataParameter CreateParameter(string name, object value, DbType dbType);
        public IDbDataParameter CreateParameter(string name, int size, object value, DbType dbType);
        public IDbDataParameter CreateParameter(string name, int size, object value, DbType dbType, ParameterDirection direction);
        public DataTable GetDataTable(string commandText, CommandType commandType, IDbDataParameter[] parameters = null);
        public DataSet GetDataSet(string commandText, CommandType commandType, IDbDataParameter[] parameters = null);
        public IDataReader GetDataReader(string commandText, CommandType commandType, List<IDbDataParameter> parameters, out IDbConnection connection);
        public IDbCommand ExecuteStoredProcedure(string commandText, CommandType commandType, List<IDbDataParameter> parameters);
        public void Delete(string commandText, CommandType commandType, IDbDataParameter[] parameters = null);
        public void Insert(string commandText, CommandType commandType, IDbDataParameter[] parameters = null);
        void InsertOrUpdate(string commandText, CommandType commandType);
        public int Insert(string commandText, CommandType commandType, IDbDataParameter[] parameters, out int lastID);
        public long Insert(string commandText, CommandType commandType, IDbDataParameter[] parameters, out long lastID);
        public void InsertWithTransaction(string commandText, CommandType commandType, IDbDataParameter[] parameters);
        public void InsertWithTransaction(string commandText, CommandType commandType, IsolationLevel isolationLevel, IDbDataParameter[] parameters);
        public void Update(string commandText, CommandType commandType, IDbDataParameter[] parameters);
        public void UpdateWithTransaction(string commandText, CommandType commandType, IDbDataParameter[] parameters);
        public void UpdateWithTransaction(string commandText, CommandType commandType, IsolationLevel isolationLevel, IDbDataParameter[] parameters);
        public IDbCommand CreateStoredProcedure(string pCommandText, CommandType commandType);

    }
}
