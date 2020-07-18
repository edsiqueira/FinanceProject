using ISqlDataFactory;
using System.Data;
using System.Data.SqlClient;

namespace SqlDataFactory
{
    public class SqlDataAccess : IDatabaseHandler
    {
        private string ConnString { get; set; }
        public SqlDataAccess(string connectionString)
        {
            ConnString = connectionString;
        }

        public void CloseConnection(IDbConnection conn)
        {
            var sqlConnection = (SqlConnection)conn;
            sqlConnection.Close();
            sqlConnection.Dispose();
        }

        public IDataAdapter CreateAdapter(IDbCommand command)
        {
            return new SqlDataAdapter((SqlCommand)command);
        }

        public IDbCommand CreateCommand(string commandText, CommandType commandType, IDbConnection connection)
        {
            return new SqlCommand
            {
                CommandText = commandText,
                Connection = (SqlConnection)connection,
                CommandType = commandType
            };
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(ConnString);
        }

        public IDbDataParameter CreateParameter(IDbCommand command)
        {
            SqlCommand sqlCommand = (SqlCommand)command;
            return sqlCommand.CreateParameter();
        }
    }
}
