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
    public class ProductsConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired(true);
            builder.Property(x=>x.ProductName).HasMaxLength(40).IsRequired(true);
            //builder.Property(x=>x.SuppliersID).IsRequired(false);
            //builder.Property(x=>x.CategoriesID).IsRequired(false);
            builder.Property(x=>x.QuantityPerUnit).HasMaxLength(20).IsRequired(true);
            builder.Property(x=>x.UnitPrice).IsRequired(false);
            builder.Property(x => x.UnitsOnOrder).IsRequired(false);
            builder.Property(x => x.ReorderLevel).IsRequired(false);
            builder.Property(x => x.Discontinued).IsRequired(true);









        }
    }
}
