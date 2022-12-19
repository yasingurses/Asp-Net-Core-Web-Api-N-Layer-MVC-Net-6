using Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configur
{
    internal class CategoryConfigur : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            //KATEGORİ 1 1 ARTAR 
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Id).IsRequired().HasMaxLength(50);
        }
    }
}
