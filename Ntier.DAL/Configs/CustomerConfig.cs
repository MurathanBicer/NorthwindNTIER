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
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired(true);
            builder.Property(x=>x.CompanyName).HasMaxLength(255).IsRequired(true);
            builder.Property(x=>x.ContactName).HasMaxLength(255).IsRequired(false);
            builder.Property(x=>x.Address).HasMaxLength(255).IsRequired(false);
            builder.Property(x=>x.City).HasMaxLength(255).IsRequired(false);
            builder.Property(x=>x.Region).HasMaxLength(255).IsRequired(false);  
            builder.Property(x=>x.PostalCode).HasMaxLength(255).IsRequired(false);
            builder.Property(x=>x.Country).HasMaxLength(255).IsRequired(false);
            builder.Property(x=>x.Phone).HasMaxLength(15).IsRequired(false);
            builder.Property(x=>x.Fax).IsRequired(false);
        }
    }
}
