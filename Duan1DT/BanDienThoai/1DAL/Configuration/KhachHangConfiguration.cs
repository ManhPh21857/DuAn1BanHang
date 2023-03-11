using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using _1DAL.Models;

namespace _1DAL.Configuration
{
    internal class KhachHangConfiguration : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable("KhachHang");
            builder.HasKey(x => x.MaKH);

            builder.Property(p => p.TenKH).HasColumnType("nvarchar(50)").
                IsRequired();
            builder.Property(p => p.GioiTinh).HasColumnType("int").IsRequired();
            builder.Property(p => p.DiaChi).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(p => p.SDT).HasColumnType("nvarchar(15)").IsRequired();
            builder.Property(p => p.Diem).HasColumnName("Diem").
                HasColumnType("int").IsRequired();
        }
    }
}
