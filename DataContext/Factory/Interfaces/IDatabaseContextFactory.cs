using System.Data.Common;
using DataContext.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataContext.Parameters;

namespace DataContext.Factory.Interfaces
{
    public interface IDatabaseContextFactory
    {
        DbConnection CreateDbConnection(DbConnectionParameters dbConnectionParameters);
        ModelContextBase CreateModelContext(DbConnection databaseConnection);
    }
}
