using ISqlDataFactory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SqlDataFactory
{
    public class DatabaseHandlerFactory
    {
        private string cn;
        public DatabaseHandlerFactory()
        {
            var configuration = GetConfiguration();


            cn = configuration.GetSection("ConnectionStrings").GetSection("Database").Value;
          
        }
        public IDatabaseHandler CreateDatabase()
        {
            IDatabaseHandler database = null;
            database = new SqlDataAccess(cn);
            var provider = GetProviderName();

            switch (provider.ToLower())
            {
                case "sqlserver":
                    database = new SqlDataAccess(cn);
                    break;

                case "system.data.oracleclient":
                    break;

                case "system.data.oleDb":
                    break;

                case "system.data.odbc":
                    break;
            }


            return database;
        }
        public IConfigurationRoot GetConfiguration()
        {
            var configurationBuilder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return configurationBuilder.Build();
        }
        public string GetProviderName()
        {
            var conf = GetConfiguration();
            return conf.GetSection("ConnectionStrings").GetSection("ProviderName").Value;
        }
    }
}
