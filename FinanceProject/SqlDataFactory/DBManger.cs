using DTO;
using ISqlDataFactory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;

namespace SqlDataFactory
{
    public class DBManager : IDBManager
    {
        private readonly DatabaseHandlerFactory dbFactory;
        private readonly IDatabaseHandler database;
        private string providerName;

        public DBManager()
        {
            dbFactory = new DatabaseHandlerFactory();
            database = dbFactory.CreateDatabase();
            providerName = dbFactory.GetProviderName();
        }

        public IDbConnection GetDatabaseConnection()
        {
            return database.CreateConnection();
        }

        public void CloseConnection(IDbConnection connection)
        {
            database.CloseConnection(connection);
        }


        public IDbDataParameter CreateParameter(string name, object value, DbType dbType)
        {
            if (value == null)
            {
                value = System.DBNull.Value;
            }
            return DataParameterManager.CreateParameter(providerName, name, value, dbType, ParameterDirection.Input);
        }

        public IDbDataParameter CreateParameter(string name, int size, object value, DbType dbType)
        {
            return DataParameterManager.CreateParameter(providerName, name, size, value, dbType, ParameterDirection.Input);
        }

        public IDbDataParameter CreateParameter(string name, int size, object value, DbType dbType, ParameterDirection direction)
        {
            return DataParameterManager.CreateParameter(providerName, name, size, value, dbType, direction);
        }

        public DataTable GetDataTable(string commandText, CommandType commandType, IDbDataParameter[] parameters = null)
        {
            using (var connection = database.CreateConnection())
            {
                connection.Open();
                using (var command = database.CreateCommand(commandText, commandType, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {
                            command.Parameters.Add(item);
                        }
                    }

                    var dataset = new DataSet();
                    var dataAdapter = database.CreateAdapter(command);
                    dataAdapter.Fill(dataset);

                    //connection.Close();

                    return dataset.Tables[0];
                }

            }
        }

      
        public DataSet GetDataSet(string commandText, CommandType commandType, IDbDataParameter[] parameters = null)
        {

            using (var connection = database.CreateConnection())
            {
                connection.Open();
                using (var command = database.CreateCommand(commandText, commandType, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {
                            command.Parameters.Add(item);
                        }
                    }

                    var dataset = new DataSet();
                    var dataAdapter = database.CreateAdapter(command);
                    dataAdapter.Fill(dataset);

                    //connection.Close();

                    return dataset;
                }
            }
        }


        public IDataReader GetDataReader(string commandText, CommandType commandType, List<IDbDataParameter> parameters, out IDbConnection connection)
        {
            IDataReader reader = null;

            connection = database.CreateConnection();
            connection.Open();
            var command = database.CreateCommand(commandText, commandType, connection);
            if (parameters != null)
            {
                foreach (var item in parameters)
                {
                    command.Parameters.Add(item);
                }
            }
            reader = command.ExecuteReader();

            
            return reader;
        }
        public IDbCommand ExecuteStoredProcedure(string commandText, CommandType commandType, List<IDbDataParameter> parameters)
        {

            IDbCommand cmd = null;

            IDbConnection connection = database.CreateConnection();
            connection.Open();
            cmd = database.CreateCommand(commandText, commandType, connection);
            if (parameters != null)
            {
                foreach (var item in parameters)
                {
                    cmd.Parameters.Add(item);
                }
            }
            cmd.ExecuteNonQuery();
            return cmd;
        }

        public void Delete(string commandText, CommandType commandType, IDbDataParameter[] parameters = null)
        {
            using (var connection = database.CreateConnection())
            {
                using (var command = database.CreateCommand(commandText, commandType, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {
                            command.Parameters.Add(item);
                        }
                    }


                    command.ExecuteNonQuery();
                }
            }
        }

        public void Insert(string commandText, CommandType commandType, IDbDataParameter[] parameters = null)
        {
            using (var connection = database.CreateConnection())
            {
                connection.Open();
                using (var command = database.CreateCommand(commandText, commandType, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {
                            command.Parameters.Add(item);
                        }
                    }


                    command.ExecuteNonQuery();
                }
                connection.Dispose();
            }
        }

        public void InsertOrUpdate(string commandText, CommandType commandType)
        {
            var ret = 0;
            using (var connection = database.CreateConnection())
            {

                connection.Open();
                using (var command = database.CreateCommand(commandText, commandType, connection))
                {
                    ret = command.ExecuteNonQuery();
                }
                connection.Dispose();
            }
            if (ret == 0)
            {
                throw new Exception("Não foi possivel salvar esta alteração na base de Dados");
            }
        }

        public int Insert(string commandText, CommandType commandType, IDbDataParameter[] parameters, out int lastID)
        {
            lastID = 0;
            using (var connection = database.CreateConnection())
            {
                using (var command = database.CreateCommand(commandText, commandType, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {
                            command.Parameters.Add(item);
                        }
                    }


                    object newID = command.ExecuteScalar();
                    lastID = Convert.ToInt32(newID);
                }
            }
            return lastID;
        }


        public long Insert(string commandText, CommandType commandType, IDbDataParameter[] parameters, out long lastID)
        {
            lastID = 0;
            using (var connection = database.CreateConnection())
            {
                using (var command = database.CreateCommand(commandText, commandType, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {
                            command.Parameters.Add(item);
                        }
                    }


                    object newID = command.ExecuteScalar();
                    lastID = Convert.ToInt64(newID);
                }
            }
            return lastID;
        }

        public void InsertWithTransaction(string commandText, CommandType commandType, IDbDataParameter[] parameters)
        {
            IDbTransaction transactionScope = null;
            using (var connection = database.CreateConnection())
            {
                connection.Open();
                transactionScope = connection.BeginTransaction();
                using (var command = database.CreateCommand(commandText, commandType, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {
                            command.Parameters.Add(item);
                        }
                    }
                    try
                    {
                        command.ExecuteNonQuery();
                        transactionScope.Commit();
                    }
                    catch (Exception)
                    {
                        transactionScope.Rollback();
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }


        public void InsertWithTransaction(string commandText, CommandType commandType, IsolationLevel isolationLevel, IDbDataParameter[] parameters)
        {
            IDbTransaction transactionScope = null;
            using (var connection = database.CreateConnection())
            {
                connection.Open();
                transactionScope = connection.BeginTransaction(isolationLevel);
                using (var command = database.CreateCommand(commandText, commandType, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {
                            command.Parameters.Add(item);
                        }
                    }
                    try
                    {
                        command.ExecuteNonQuery();
                        transactionScope.Commit();
                    }
                    catch (Exception)
                    {
                        transactionScope.Rollback();
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public void Update(string commandText, CommandType commandType, IDbDataParameter[] parameters)
        {
            using (var connection = database.CreateConnection())
            {
                using (var command = database.CreateCommand(commandText, commandType, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {
                            command.Parameters.Add(item);
                        }
                    }
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateWithTransaction(string commandText, CommandType commandType, IDbDataParameter[] parameters)
        {
            IDbTransaction transactionScope = null;
            using (var connection = database.CreateConnection())
            {
                connection.Open();
                transactionScope = connection.BeginTransaction();
                using (var command = database.CreateCommand(commandText, commandType, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {
                            command.Parameters.Add(item);
                        }
                    }
                    try
                    {
                        command.ExecuteNonQuery();
                        transactionScope.Commit();
                    }
                    catch (Exception)
                    {
                        transactionScope.Rollback();
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public void UpdateWithTransaction(string commandText, CommandType commandType, IsolationLevel isolationLevel, IDbDataParameter[] parameters)
        {
            IDbTransaction transactionScope = null;
            using (var connection = database.CreateConnection())
            {
                connection.Open();
                transactionScope = connection.BeginTransaction(isolationLevel);
                using (var command = database.CreateCommand(commandText, commandType, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {
                            command.Parameters.Add(item);
                        }
                    }
                    try
                    {
                        command.ExecuteNonQuery();
                        transactionScope.Commit();
                    }
                    catch (Exception)
                    {
                        transactionScope.Rollback();
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public IDbCommand CreateStoredProcedure(string pCommandText, CommandType commandType)
        {
            using (var connection = database.CreateConnection())
            {
                return database.CreateCommand(pCommandText, CommandType.StoredProcedure, connection);
            }
            
        }
    }
}
