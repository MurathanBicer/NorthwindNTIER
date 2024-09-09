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
    public class ShippersConfig : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired(true);
            builder.Property(x => x.CompayName).HasMaxLength(40).IsRequired(true);
            builder.Property(x=>x.Phone).HasMaxLength(24).IsRequired(true);
            

        }
    }
}
