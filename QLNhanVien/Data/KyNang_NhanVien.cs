using System.ComponentModel.DataAnnotations.Schema;

namespace QLNhanVien.Data
{
    public class KyNang_NhanVien
    {
        public int ID { get; set; }
        public int IDNhanVien { get; set; }
        public int IDKyNang { get; set; }
        [ForeignKey("IDNhanVien")]
        public NhanVien NhanVien { get; set; }
        [ForeignKey("IDKyNang")]
        public KyNang KyNang { get; set; }
    }
}
