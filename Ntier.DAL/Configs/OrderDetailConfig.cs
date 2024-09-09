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
    public class OrderDetailConfig : IEntityTypeConfiguration<OrderDetail>
    {
    
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {

            builder.HasKey(x => x.ID);
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new { x.OrderID, x.ProductID });
            
            builder.Property(x=>x.Quantity).IsRequired(true);
            builder.Property(x=>x.UnitPrice).IsRequired(true);
            builder.Property(x=>x.Discount).IsRequired(true);
        }
    }
}
