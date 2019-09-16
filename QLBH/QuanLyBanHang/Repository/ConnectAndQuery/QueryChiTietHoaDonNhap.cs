using QuanLyBanHang.Model_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Repository.ConnectAndQuery
{
    class QueryChiTietHoaDonNhap
    {
        private GeneralQuery query;
        public QueryChiTietHoaDonNhap()
        {
            query = new GeneralQuery();
        }
        public void insert(Class_ChiTietHoaDonNhap CTHDN)
        {
            string sql = "INSERT INTO ChiTietHoaDonNhap(MaHoaDonNhap,MaNguyenLieu,SoLuong,DonGia,KhuyenMai,ThanhTien) VALUES(";
            sql += CTHDN.MaHoaDonNhap1 + ",N'" + CTHDN.MaNguyenLieu1 + "',N'" + CTHDN.SoLuong1 + "',N'" + CTHDN.DonGia1 
                + "',N'" + CTHDN.KhuyenMai1 + "',N'" + CTHDN.ThanhTien1 + "')";
            query.insert(sql);
        }
        public void delete(Class_ChiTietHoaDonNhap CTHDN)
        {
            string sql = "DELETE FROM ChiTietHoaDonNhap WHERE MaHoaDonNhap = "+ CTHDN.MaHoaDonNhap1 + " and MaNguyenLieu = " + CTHDN.MaNguyenLieu1;
            query.insert(sql);
        }
        public void update(Class_ChiTietHoaDonNhap CTHDN)
        {
            string sql = "UPDATE ChiTietHoaDonNhap WHERE SET MaHoaDonNhap=" + CTHDN.MaHoaDonNhap1 + ",MaNguyenLieu=N'" +
               CTHDN.MaNguyenLieu1+ "', SoLuong='" + CTHDN.SoLuong1 + "', DonGia='" + CTHDN.DonGia1 + ",KhuyenMai='" 
               + CTHDN.KhuyenMai1 + ",ThanhTien='" + CTHDN.ThanhTien1 + "')";
            query.insert(sql);
        }
    }
}
