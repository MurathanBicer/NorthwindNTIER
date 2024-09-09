using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ntier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntier.DAL.Configs
{
    public class CategoriesConfig : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x=>x.CategoryName).HasMaxLength(256).IsRequired(true);
            builder.Property(x=>x.ID).IsRequired(true);
            builder.Property(x=>x.Description).HasMaxLength(256).IsRequired(false);
            builder.Property(x=>x.Picture).IsRequired(false);
            
            

            //seed category data
            //******************
        }
    }
}
