using System.Data;
using System.Data.SqlClient;

namespace SqlDataFactory
{
    public class DataParameterManager
    {
        public static IDbDataParameter CreateParameter(string providerName, string name, object value, DbType dbType, ParameterDirection direction = ParameterDirection.Input)
        {
            IDbDataParameter parameter = null;
            switch (providerName.ToLower())
            {
                case "sqlserver":
                    return CreateSqlParameter(name, value, dbType, direction);

                case "system.data.oracleclient":
                    break;

                case "system.data.oledb":
                    break;

                case "system.data.odbc":
                    break;
            }

            return parameter;
        }

        public static IDbDataParameter CreateParameter(string providerName, string name, int size, object value, DbType dbType, ParameterDirection direction = ParameterDirection.Input)
        {
            IDbDataParameter parameter = null;
            switch (providerName.ToLower())
            {
                case "sqlserver":
                    return CreateSqlParameter(name, size, value, dbType, direction);

                case "system.data.oracleclient":
                    break;

                case "system.data.oleDb":
                    break;

                case "system.data.odbc":
                    break;
            }
            return parameter;

        }

        private static IDbDataParameter CreateSqlParameter(string name, object value, DbType dbType, ParameterDirection direction)
        {
            return new SqlParameter
            {
                DbType = dbType,
                ParameterName = name,
                Direction = direction,
                Value = value
            };
        }

        private static IDbDataParameter CreateSqlParameter(string name, int size, object value, DbType dbType, ParameterDirection direction)
        {
            return new SqlParameter
            {
                DbType = dbType,
                ParameterName = name,
                Size = size,
                Direction = direction,
                Value = value
            };
        }
    }
}
