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
    internal class OrdersConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired(true);
            //builder.Property(x=>x.CustomerID).HasMaxLength(5).IsRequired(false);
            //builder.Property(x=>x.EmployeeID).IsRequired(false);
            builder.Property(x=>x.OrderDate).IsRequired(false);
            builder.Property(x=>x.RequieredDate).IsRequired(false);
            builder.Property(x=>x.ShippedDate).IsRequired(false);
            //builder.Property(x=>x.Shipper).IsRequired(false);
            builder.Property(x=>x.Freight).IsRequired(false);
            builder.Property(x=>x.ShipName).HasMaxLength(40).IsRequired(false);
            builder.Property(x => x.ShipAddress).HasMaxLength(60).IsRequired(false);
            builder.Property(x => x.ShipCity).HasMaxLength(40).IsRequired(false);
            builder.Property(x => x.ShipRegion).HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.ShipPostalCode).HasMaxLength(10).IsRequired(false);
            builder.Property(x => x.ShipCountry).HasMaxLength(15).IsRequired(false);

        }
    }
}
