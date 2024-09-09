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
    public class SuppliersConfig : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(x => x.ID);
            
            builder.Property(x=>x.CompanyName).HasMaxLength(40).IsRequired(true);
            builder.Property(x => x.ContactName).HasMaxLength(30).IsRequired(false);
            builder.Property(x => x.ContactTitle).HasMaxLength(30).IsRequired(false);
            builder.Property(x => x.Address).HasMaxLength(60).IsRequired(false);
            builder.Property(x => x.City).HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.Region).HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.PostalCode).HasMaxLength(10).IsRequired(false);
            builder.Property(x => x.Country).HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.Phone).HasMaxLength(24).IsRequired(false);
            builder.Property(x => x.Fax).HasMaxLength(24).IsRequired(false);
            builder.Property(x => x.HomePage).IsRequired(true);




        }
    }
}
