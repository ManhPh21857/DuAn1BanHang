using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace _1DAL.Configuration
{
    public class KhuyenMaiConfiguration : IEntityTypeConfiguration<KhuyenMai>
    {
        public void Configure(EntityTypeBuilder<KhuyenMai> builder)
        {
            builder.ToTable("KhuyenMai");
            builder.HasKey(p => p.MaKM);
            builder.Property(x => x.MaKM).UseIdentityColumn(1, 1);
            builder.Property(p => p.TenKM).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(p => p.GiamGia).HasColumnType("int").IsRequired();
            builder.Property(p => p.NgayKetThuc).HasColumnType("DateTime").IsRequired();
            builder.Property(p => p.NgayBatDau).HasColumnType("DateTime").IsRequired();
            builder.Property(p => p.TrangThai).HasColumnType("int").IsRequired();
        }
    }
}
