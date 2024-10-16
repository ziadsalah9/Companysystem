using Companysystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companysystem
{
    internal class CostsAndExpensisConfig : IEntityTypeConfiguration<CostsAndExpensesModel>
    {
        public void Configure(EntityTypeBuilder<CostsAndExpensesModel> builder)
        {
            builder.Property(p => p.Statment).HasColumnType("decimal(18,2)");
            builder.Property(p => p.Cars).HasColumnType("decimal(18,2)");
            builder.Property(p => p.Rints).HasColumnType("decimal(18,2)");
            builder.Property(p => p.Salaries).HasColumnType("decimal(18,2)");
            builder.Property(p => p.others).HasColumnType("decimal(18,2)");
            builder.Property(p => p.Insurance).HasColumnType("decimal(18,2)");
            builder.Property(p => p.Mails).HasColumnType("decimal(18,2)");
            builder.Property(p => p.WaterElectericityGas).HasColumnType("decimal(18,2)");
            builder.Property(p => p.PhoneandInternet).HasColumnType("decimal(18,2)");
            builder.Property(p => p.Totalcost).HasColumnType("decimal(18,2)");



        }
    }
}
