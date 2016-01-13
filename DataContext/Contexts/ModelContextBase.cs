using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Data.Common;
using Entity.Goods;

namespace DataContext.Contexts
{
    public abstract class ModelContextBase : DbContext
    {
        protected ModelContextBase(DbConnection connection)
            : base(connection, true)
        {
        }

        protected ModelContextBase(string connection)
            : base(connection)
        {
        }

        protected ModelContextBase()
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }

        public virtual DbSet<PlayStation> PlayStation { get; set; }
    }
}
