using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Entity.Goods;

namespace DataContext.Mappings.Goods
{
    class PlayStationMap : EntityTypeConfiguration<PlayStation>
    {
        private PlayStationMap()
        {
            //Primary Key
            HasKey(t => t.Id);

            //Table & Column Mappings
            ToTable("PlayStation");

            Property(t => t.Color);
            Property(t => t.IsBundle);
            Property(t => t.MemoryCapacity);
            Property(t => t.Name);
            Property(t => t.Price);
            Property(t => t.Revision);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
