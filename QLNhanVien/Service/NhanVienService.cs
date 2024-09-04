using Microsoft.EntityFrameworkCore;
using QLNhanVien.Context;
using QLNhanVien.Data;

namespace QLNhanVien.Service
{
	public class NhanVienService
	{
		private readonly MyContext _context;

		public NhanVienService(MyContext context)
        {
			_context = context;
		}
		public List<NhanVien>GetNhanViens()
		{
			return  _context.NhanViens.Include(p => p.KyNang_NhanViens).ThenInclude(p => p.KyNang).ToList();
		}
    }
}
