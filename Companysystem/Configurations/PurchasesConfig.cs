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
    public class PurchasesConfig : IEntityTypeConfiguration<Purchases>
    {
        public void Configure(EntityTypeBuilder<Purchases> builder)
        {
            builder.Property(p => p.Price).HasColumnType("decimal(18,2)");
            builder.Property(p => p.PriceValue).HasColumnType("decimal(18,2)");
            builder.Property(p => p.deduct).HasColumnType("decimal(18,2)");
            builder.Property(p => p.TransportAndShipping).HasColumnType("decimal(18,2)");
            builder.Property(p => p.Customs).HasColumnType("decimal(18,2)");
            builder.Property(p => p.others).HasColumnType("decimal(18,2)");
            builder.Property(p => p.NetPriceValue).HasColumnType("decimal(18,2)");
            builder.Property(p => p.priceUnit).HasColumnType("decimal(18,2)");


        }
    }
}
