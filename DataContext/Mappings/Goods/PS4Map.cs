using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Entity.Goods;

namespace DataContext.Mappings.Goods
{
    class PS4Map : EntityTypeConfiguration<PS4>
    {
        private PS4Map()
        {
            //Table & Column Mappings
            ToTable("PlayStation_PS4");

            Property(t => t.ModelType);
        }
    }
}
