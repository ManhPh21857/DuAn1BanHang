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
    internal class GioHangCTConfiguration : IEntityTypeConfiguration<GioHangCT>
    {
        public void Configure(EntityTypeBuilder<GioHangCT> builder)
        {
            builder.ToTable("GioHangCT");
            builder.HasKey(x => x.MaGHCT);

            builder.HasOne(x => x.DienThoaiCTS).WithMany(p=>p.GioHangCTS).HasForeignKey(p => p.MaDTCT);
            builder.HasOne(x => x.GioHangS).WithMany(p=>p.GioHangCTs).HasForeignKey(p => p.MaGH);

            builder.Property(p => p.MaDTCT).IsRequired();
            builder.Property(p => p.MaGH).IsRequired();
            builder.Property(p => p.SoLuong).IsRequired();
            builder.Property(p => p.DonGia).IsRequired();

            // set khóa ngoại
           
        }
    }
}
