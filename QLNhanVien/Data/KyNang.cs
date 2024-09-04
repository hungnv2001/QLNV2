namespace QLNhanVien.Data
{
    public class KyNang
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string Mota { get; set; }
        public virtual List<KyNang_NhanVien> KyNang_NhanViens { get; set; }
    }
}
