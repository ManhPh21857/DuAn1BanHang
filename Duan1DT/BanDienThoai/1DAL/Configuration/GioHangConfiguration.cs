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
    public class GioHangConfiguration : IEntityTypeConfiguration<GioHang>
    {
        public void Configure(EntityTypeBuilder<GioHang> builder)
        {
            builder.ToTable("GioHang");
            builder.HasKey(p => p.MaGH);
            builder.Property(x => x.MaGH).UseIdentityColumn(1, 1);
            builder.HasOne(p => p.NhanVienS).WithMany(p => p.GioHangs).HasForeignKey(p => p.MaNV);
            builder.HasOne(p => p.KhachHangS).WithMany(p => p.GioHangs).HasForeignKey(p => p.MaKH);
        }
    }
}
