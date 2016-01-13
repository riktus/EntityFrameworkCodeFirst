using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Entity.Goods;

namespace DataContext.Mappings.Goods
{
    class PSVitaMap : EntityTypeConfiguration<PSVita>
    {
        private PSVitaMap()
        {
            //Table & Column Mappings
            ToTable("PlayStation_PSVita");
        }
    }
}
