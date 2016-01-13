using DataContext.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace DataContext.Migrations
{
    public class Configuration : DbMigrationsConfiguration<MsSqlModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MsSqlModelContext context)
        {

        }
    }
}
