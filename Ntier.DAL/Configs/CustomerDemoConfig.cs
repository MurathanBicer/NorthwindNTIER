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
    public class CustomerDemoConfig : IEntityTypeConfiguration<CustomerDemographics>
    {
        public void Configure(EntityTypeBuilder<CustomerDemographics> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x=>x.ID).HasMaxLength(10).IsRequired(true);
            builder.Property(x=>x.CustomerDescription).HasMaxLength(255).IsRequired(false);
        }
    }
}
