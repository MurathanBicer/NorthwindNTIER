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
    public class CustomerCostemerDemoConfig : IEntityTypeConfiguration<CustomerCustomerDemo>
    {


        /*
         builder.HasKey(x => new { x.CustomerID, x.CustomerDomographicID });
         builder.HasOne(x => x.Customer)
        .WithMany(x => x.CustomerCustomerDemo)
        .HasForeignKey(x => x.CustomerID);

         builder.HasOne(x => x.CustomerDemographic)
        .WithMany(x => x.CustomerCustomerDemo)
        .HasForeignKey(x => x.CustomerDomographicID);
        */
        public void Configure(EntityTypeBuilder<CustomerCustomerDemo> builder)
        {
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new { x.CustomerID, x.CustomerDemographicsID });

            builder
                .HasOne(x => x.Customer)
                .WithMany(x => x.CustomerCustomerDemos)
                .HasForeignKey(x => x.Customer);

            builder.HasOne(x => x.Customerdemographics)
                .WithMany(x => x.CustomerCustomerDemos)
                .HasForeignKey(x => x.CustomerDemographicsID);

        }
    }
}
