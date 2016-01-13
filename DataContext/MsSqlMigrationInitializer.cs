using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using DataContext.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using DataContext.Migrations;

namespace DataContext
{
    public class MsSqlMigrationInitializer : MigrateDatabaseToLatestVersion<MsSqlModelContext, Configuration>
    {
        public override void InitializeDatabase(MsSqlModelContext context)
        {
            var migrator = new DbMigrator(new Configuration());

            var pendingMigrations = migrator.GetPendingMigrations();
            var lastMigration = pendingMigrations.LastOrDefault();
            if (lastMigration != null)
            {
                try
                {
                    migrator.Update(lastMigration);
                }
                catch (DbUpdateException ex)
                {
                    // Retrieve the error messages as a list of strings.
                    var errorMessages = ex.Entries;

                    // Join the list to a single string.
                    var fullErrorMessage = string.Join("; ", errorMessages);

                    // Combine the original exception message with the new one.
                    var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                    // Throw a new DbEntityValidationException with the improved exception message.
                    throw new DbEntityValidationException(exceptionMessage, ex);
                }
            }

        }
    }
}
