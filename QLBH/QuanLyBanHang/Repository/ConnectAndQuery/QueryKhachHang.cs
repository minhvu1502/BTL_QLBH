using QuanLyBanHang.Model_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Repository.ConnectAndQuery
{
    class QueryKhachHang
    {
        private GeneralQuery query;
        public QueryKhachHang()
        {
            query = new GeneralQuery();
        }
        public void insert(Class_Khach khach)
        {
            string sql = "INSERT INTO KhachHang(MaKhachHang,TenKhachHang, DiaChi,DienThoai) VALUES(";
            sql += khach.MaKhach1 + ",N'" + khach.TenKhach1 + "',N'" + khach.DiaChi1 + "',N'" + khach.DienThoai1 + "')";
            query.insert(sql);
        }
        public void delete(Class_Khach khach)
        {
            string sql = "DELETE FROM Khach WHERE MaKhachHang = " + khach.MaKhach1;
            query.insert(sql);
        }
        public void update(Class_Khach khach)
        {
            string sql = "UPDATE Khach WHERE SET MaKhachHang=" + khach.MaKhach1 + ",TenKhacHang=N'" + khach.TenKhach1 + "', DiaChi=N'" + khach.DiaChi1 + "', DienThoai='" + khach.DienThoai1 + "')";
            query.insert(sql);
        }
    }
}
