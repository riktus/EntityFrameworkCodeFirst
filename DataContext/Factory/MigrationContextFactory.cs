using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using DataContext.Contexts;
using DataContext.Factory.Implementations;
using DataContext.Parameters;

namespace DataContext.Factory
{
    public class MigrationContextFactory : IDbContextFactory<MsSqlModelContext>
    {
        public MsSqlModelContext Create()
        {
            var connectionFactory = new MsSqlDatabaseContextFactory();
            var desktopDbConnectionParameters = new DbConnectionParameters
            {
                DbServerUrl = "(localdb)\\v11.0",
                DbInstanceName = "TestCodeFirst",

                IsOsUser = true,
                ConnectionUserName = "",
                ConnectionUserPassword = ""
            };

            return new MsSqlModelContext(connectionFactory.CreateDbConnection(desktopDbConnectionParameters));
        }
    }
}
