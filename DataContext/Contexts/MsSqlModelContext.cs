using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DataContext.Contexts
{
    public class MsSqlModelContext : ModelContextBase
    {
        public MsSqlModelContext(DbConnection connection)
            : base(connection)
        {
        }

        public MsSqlModelContext(string connection)
            : base(connection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
