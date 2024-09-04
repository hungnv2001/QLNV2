using Microsoft.EntityFrameworkCore;
using QLNhanVien.Data;

namespace QLNhanVien.Context
{
	public class MyContext : DbContext
	{
		public MyContext()
		{

		}

		public MyContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Seed data for KyNang
			modelBuilder.Entity<KyNang>().HasData(
				new KyNang {ID=1, Ten = "Lập trình C#", Mota = "Kỹ năng lập trình với C#" },
				new KyNang { ID = 2, Ten = "Lập trình ASP.NET", Mota = "Kỹ năng phát triển ứng dụng web với ASP.NET" },
				new KyNang { ID = 3, Ten = "Entity Framework", Mota = "Kỹ năng làm việc với Entity Framework để truy cập dữ liệu" }
			);

			// Seed data for NhanVien
			modelBuilder.Entity<NhanVien>().HasData(
				new NhanVien { ID = 1, Ten = "Nguyen Van A", NgheNghiep = "Lập trình viên", GioiTinh = "Nam" },
				new NhanVien { ID = 2, Ten = "Tran Thi B", NgheNghiep = "Thiết kế web", GioiTinh = "Nữ" },
				new NhanVien { ID = 3, Ten = "Le Van C", NgheNghiep = "Quản trị hệ thống", GioiTinh = "Nam" }
			);

			// Seed data for KinhNghiemLamViec
			modelBuilder.Entity<KinhNghiemLamViec>().HasData(
				new KinhNghiemLamViec { ID = 1, TenKinhNghiem = "Dự án A", ViTri = "Lập trình viên", CongNghe = "C#", Mota = "Dự án phát triển phần mềm", ThoiGian = 12, IDNhanVien = 1 },
				new KinhNghiemLamViec { ID = 2, TenKinhNghiem = "Dự án B", ViTri = "Thiết kế web", CongNghe = "ASP.NET", Mota = "Dự án thiết kế web", ThoiGian = 8, IDNhanVien = 1 },
				new KinhNghiemLamViec { ID = 3, TenKinhNghiem = "Dự án C", ViTri = "Quản trị hệ thống", CongNghe = "Linux", Mota = "Quản lý hệ thống mạng", ThoiGian = 24, IDNhanVien = 3 }
			);

			// Seed data for KyNang_NhanVien
			modelBuilder.Entity<KyNang_NhanVien>().HasData(
				new KyNang_NhanVien { ID = 1, IDNhanVien = 1, IDKyNang = 1 },
				new KyNang_NhanVien { ID = 2, IDNhanVien = 1, IDKyNang = 3 },
				new KyNang_NhanVien { ID = 3, IDNhanVien = 2, IDKyNang = 2 },
				new KyNang_NhanVien { ID = 4, IDNhanVien = 3, IDKyNang = 3 }
			);

		}
		public DbSet<NhanVien> NhanViens { get; set; }
		public DbSet<KyNang> KyNangs { get; set; }
		public DbSet<KyNang_NhanVien> KyNang_NhanViens { get; set; }
		public DbSet<KinhNghiemLamViec> KinhNghiemLamViecs { get; set; }
	}
}
