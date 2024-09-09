using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ntier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntier.DAL.Configs
{
    public class TerritoriesConfig : IEntityTypeConfiguration<Territory>
    {
        public void Configure(EntityTypeBuilder<Territory> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x=>x.ID).HasMaxLength(20).IsRequired(true);
            builder.Property(x => x.TerritoryDescription).HasMaxLength(50).IsRequired(true);
            
        }
    }
}
