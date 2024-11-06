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
    public class Transactionstoreconfig : IEntityTypeConfiguration<StoreTransaction>
    {
        public void Configure(EntityTypeBuilder<StoreTransaction> builder)
        {
            builder.Property(p => p.quantity).HasColumnType("decimal(18,2)");


            builder
            .HasOne(s => s.Sales)
            .WithMany()
            .HasForeignKey(s => s.salessId)
            .OnDelete(DeleteBehavior.NoAction);

            builder
            .HasOne(s => s.Store)
            .WithMany()
            .HasForeignKey(s => s.storessId)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
