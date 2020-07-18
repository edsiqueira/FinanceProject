using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ISqlDataFactory
{
    public interface IDatabaseHandler
    {
        IDbConnection CreateConnection();
        void CloseConnection(IDbConnection conn);
        IDbCommand CreateCommand(string commandText, CommandType commandType, IDbConnection connection);
        IDataAdapter CreateAdapter(IDbCommand command);
        IDbDataParameter CreateParameter(IDbCommand command);
    }
}
