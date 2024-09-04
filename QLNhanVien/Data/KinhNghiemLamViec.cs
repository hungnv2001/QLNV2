using System.ComponentModel.DataAnnotations.Schema;

namespace QLNhanVien.Data
{
    public class KinhNghiemLamViec
    {
        public int ID { get; set; }
        public string TenKinhNghiem { get; set; }
        public string ViTri { get; set; }
        public string CongNghe { get; set; }
        public string Mota { get; set; }
        public double ThoiGian { get; set; }
        public int IDNhanVien { get; set; }
        [ForeignKey("IDNhanVien")]
        public NhanVien NhanVien { get; set; }
    }
}
