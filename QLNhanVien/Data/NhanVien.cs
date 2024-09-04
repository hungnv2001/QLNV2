namespace QLNhanVien.Data
{
    public class NhanVien
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string NgheNghiep { get; set; }
        public string GioiTinh { get; set; }
        public virtual List<KyNang_NhanVien> KyNang_NhanViens { get; set; }
        public virtual List<KinhNghiemLamViec> KinhNghiemLamViecs { get; set; }

    }
}
