using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNhanVien.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KyNangs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KyNangs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgheNghiep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KinhNghiemLamViecs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKinhNghiem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViTri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CongNghe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGian = table.Column<double>(type: "float", nullable: false),
                    IDNhanVien = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KinhNghiemLamViecs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KinhNghiemLamViecs_NhanViens_IDNhanVien",
                        column: x => x.IDNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KyNang_NhanViens",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDNhanVien = table.Column<int>(type: "int", nullable: false),
                    IDKyNang = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KyNang_NhanViens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KyNang_NhanViens_KyNangs_IDKyNang",
                        column: x => x.IDKyNang,
                        principalTable: "KyNangs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KyNang_NhanViens_NhanViens_IDNhanVien",
                        column: x => x.IDNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "KyNangs",
                columns: new[] { "ID", "Mota", "Ten" },
                values: new object[,]
                {
                    { 1, "Kỹ năng lập trình với C#", "Lập trình C#" },
                    { 2, "Kỹ năng phát triển ứng dụng web với ASP.NET", "Lập trình ASP.NET" },
                    { 3, "Kỹ năng làm việc với Entity Framework để truy cập dữ liệu", "Entity Framework" }
                });

            migrationBuilder.InsertData(
                table: "NhanViens",
                columns: new[] { "ID", "GioiTinh", "NgheNghiep", "Ten" },
                values: new object[,]
                {
                    { 1, "Nam", "Lập trình viên", "Nguyen Van A" },
                    { 2, "Nữ", "Thiết kế web", "Tran Thi B" },
                    { 3, "Nam", "Quản trị hệ thống", "Le Van C" }
                });

            migrationBuilder.InsertData(
                table: "KinhNghiemLamViecs",
                columns: new[] { "ID", "CongNghe", "IDNhanVien", "Mota", "TenKinhNghiem", "ThoiGian", "ViTri" },
                values: new object[,]
                {
                    { 1, "C#", 1, "Dự án phát triển phần mềm", "Dự án A", 12.0, "Lập trình viên" },
                    { 2, "ASP.NET", 1, "Dự án thiết kế web", "Dự án B", 8.0, "Thiết kế web" },
                    { 3, "Linux", 3, "Quản lý hệ thống mạng", "Dự án C", 24.0, "Quản trị hệ thống" }
                });

            migrationBuilder.InsertData(
                table: "KyNang_NhanViens",
                columns: new[] { "ID", "IDKyNang", "IDNhanVien" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 3, 1 },
                    { 3, 2, 2 },
                    { 4, 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_KinhNghiemLamViecs_IDNhanVien",
                table: "KinhNghiemLamViecs",
                column: "IDNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_KyNang_NhanViens_IDKyNang",
                table: "KyNang_NhanViens",
                column: "IDKyNang");

            migrationBuilder.CreateIndex(
                name: "IX_KyNang_NhanViens_IDNhanVien",
                table: "KyNang_NhanViens",
                column: "IDNhanVien");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KinhNghiemLamViecs");

            migrationBuilder.DropTable(
                name: "KyNang_NhanViens");

            migrationBuilder.DropTable(
                name: "KyNangs");

            migrationBuilder.DropTable(
                name: "NhanViens");
        }
    }
}
