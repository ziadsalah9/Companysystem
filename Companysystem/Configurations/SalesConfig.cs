using Companysystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companysystem.Configurations
{
    public class SalesConfig : IEntityTypeConfiguration<Sales>
    {
        public void Configure(EntityTypeBuilder<Sales> builder)
        {
            builder.Property(p => p.priceValue).HasColumnType("decimal(18,2)");
            builder.Property(p => p.Price).HasColumnType("decimal(18,2)");
            builder.Property(p => p.NetPriceValue).HasColumnType("decimal(18,2)");
            builder.Property(p => p.Commissions).HasColumnType("decimal(18,2)");
            builder.Property(p => p.deduct).HasColumnType("decimal(18,2)");

        }
    }
}
