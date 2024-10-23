using Companysystem.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Companysystem.Configurations
{
    public class StoreConfig : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.Property(p => p.price).HasColumnType("decimal(18,2)");
            builder.Property(p => p.InventoryCost).HasColumnType("decimal(18,2)");

            builder.HasKey(p => p.Id);
            //builder
          //.HasOne(s => s.PurchasesBill)
          //.WithMany()
          //.HasForeignKey(s => s.PurchasesBillId)
          //.OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(s => s.Sales)
                .WithMany()
                .HasForeignKey(s => s.salesid)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
