using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DataContext.Factory.Interfaces;
using System.Data.Common;
using DataContext.Parameters;
using DataContext.Contexts;

namespace DataContext.Factory.Implementations
{
    public class MsSqlDatabaseContextFactory : IDatabaseContextFactory
    {
        public DbConnection CreateDbConnection(DbConnectionParameters dbConnectionParameters)
        {
            var connectionStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = dbConnectionParameters.DbServerUrl,
                InitialCatalog = dbConnectionParameters.DbInstanceName,
                IntegratedSecurity = true,
                MultipleActiveResultSets = true
            };

            if (!dbConnectionParameters.IsOsUser)
            {
                connectionStringBuilder.UserID = dbConnectionParameters.ConnectionUserName;
                connectionStringBuilder.Password = dbConnectionParameters.ConnectionUserPassword;
                connectionStringBuilder.IntegratedSecurity = false;
            }

            if (dbConnectionParameters.IsLocalDatabase)
            {
                connectionStringBuilder.AttachDBFilename = String.Format("{0}\\{1}.mdf", dbConnectionParameters.LocalDbFileCatalog, dbConnectionParameters.DbInstanceName);
            }

            return new SqlConnection(connectionStringBuilder.ToString());

        }

        public ModelContextBase CreateModelContext(DbConnection databaseConnection)
        {
            Database.SetInitializer(new MsSqlMigrationInitializer());

            return new MsSqlModelContext(databaseConnection);
        }
    }
}
