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
    public class EmployeesConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x=>x.ID).IsRequired(true);
            builder.Property(x=>x.FirstName).HasMaxLength(10).IsRequired(true);
            builder.Property(x => x.LastName).HasMaxLength(10).IsRequired(true);
            builder.Property(x => x.Title).HasMaxLength(30).IsRequired(false);
            builder.Property(x => x.Title).HasMaxLength(30).IsRequired(false);
            builder.Property(x => x.TitleOfCourtesy).HasMaxLength(25).IsRequired(false);
            builder.Property(x => x.BirthDate).IsRequired(false);
            builder.Property(x => x.HireDate).IsRequired(false);
            builder.Property(x => x.Address).HasMaxLength(60).IsRequired(false);
            builder.Property(x => x.City).HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.Region).HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.PostalCode).HasMaxLength(10).IsRequired(false);
            builder.Property(x => x.Country).HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.HomePhone).HasMaxLength(24).IsRequired(false);
            builder.Property(x => x.Extension).HasMaxLength(4).IsRequired(false);
            builder.Property(x => x.Photo).IsRequired(false);
            builder.Property(x => x.Notes).IsRequired(false);
            builder.Property(x => x.ReportsTo).IsRequired(false);
            builder.Property(x => x.PhotoPath).HasMaxLength(255).IsRequired(false);











        }
    }
}
