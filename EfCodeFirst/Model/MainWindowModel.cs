using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataContext.Parameters;
using DataContext.Factory.Implementations;
using DataContext.Contexts;

namespace EfCodeFirst.Model
{
    public class MainWindowModel
    {
        public void CreateDataBase()
        {
            var contextFactory = new MsSqlDatabaseContextFactory();
            var parameters = new DbConnectionParameters 
            {
                DbServerUrl = "(localdb)\\v11.0",
                DbInstanceName = "TestCodeFirst",

                IsOsUser = true,
                ConnectionUserName = "",
                ConnectionUserPassword = ""
            };

            ModelContextBase context = contextFactory.CreateModelContext(contextFactory.CreateDbConnection(parameters));

            context.Database.CommandTimeout = 800;

            if (context.Database.Exists())
                context.Database.Delete();

            context.Database.Initialize(false);
        }
    }
}
