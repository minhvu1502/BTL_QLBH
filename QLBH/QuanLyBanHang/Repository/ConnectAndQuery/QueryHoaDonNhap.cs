using QuanLyBanHang.Model_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Repository.ConnectAndQuery
{
    class QueryHoaDonNhap
    {
        private GeneralQuery query;
        public QueryHoaDonNhap()
        {
            query = new GeneralQuery();
        }
        public void insert(Class_HoaDonNhap HDN)
        {
            string sql = "INSERT INTO KhachHang(MaHoaDonNhap,NgayNhap,MaNhanVien,MaNhaCungCap,TongTien) VALUES(";
            sql += HDN.MaHoaDonNhap1 + ",N'" + HDN.NgayNhap1 + "',N'" + HDN.MaNhanVien1 + "',N'" + HDN.MaNhaCungCap1 + "',N'" + HDN.TongTien1  + "')";
            query.insert(sql);
        }
        public void delete(Class_HoaDonNhap HDN)
        {
            string sql = "DELETE FROM HoaDonNhap WHERE MaHoaDonNhap = " + HDN.MaHoaDonNhap1;
            query.insert(sql);
        }
        public void update(Class_HoaDonNhap HDN)
        {
            string sql = "UPDATE HoaDonNhap WHERE SET MaHoaDonNhap=" + HDN.MaHoaDonNhap1 + ",NgayNhap=N'" +
                HDN.NgayNhap1 + "', MaNhanVien=N'" + HDN.MaNhanVien1 + "', MaNhaCungCap='" + HDN.MaNhaCungCap1 + ",TongTien=N'" +HDN.TongTien1 +"')";
            query.insert(sql);
        }
    }
}
