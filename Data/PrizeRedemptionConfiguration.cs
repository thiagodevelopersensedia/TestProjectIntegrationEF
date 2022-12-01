using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data
{
    public class PrizeRedemptionConfiguration : IEntityTypeConfiguration<PrizeRedemptionEntity>
    {
        public void Configure(EntityTypeBuilder<PrizeRedemptionEntity> builder)
        {
            builder.ToTable("Redemptions");
            builder.HasKey(k => k.RedemptionId);
            builder.HasIndex(i => i.RedemptionId);
            builder.Property(p => p.Price).HasColumnType("money");
            builder.Property(p => p.Jackpot).HasColumnType("money");
            builder.Property(p => p.JackpotLimit).HasColumnType("money");
            builder.Property(p => p.RedemptionType).HasColumnType("varchar(100)");
            builder.Property(p => p.RequestTime).IsRequired(false);
        }
    }
}
