using QuanLyBanHang.Model_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Repository.ConnectAndQuery
{
    class QueryNhanVien
    {
        private GeneralQuery query;
        public QueryNhanVien()
        {
            query = new GeneralQuery();
        }
        public void insert(Class_NhanVien nv)
        {
            string sql = "INSERT INTO KhachHang(MaNhanVien,TenNhanVien,GioiTinh,NgaySinh,DiaChi,MaQue,DienThoai) VALUES(";
            sql += nv.MaNhanVien1 + ",N'" + nv.TenNhanVien1 + "',N'" + nv.GioiTinh1 + "',N'" + nv.NgaySinh1 + "',N'" + nv.DiaChi1 + "',N'" + nv.MaQue1 + "',N'" + nv.DienThoai1 + "')";
            query.insert(sql);
        }
        public void delete(Class_NhanVien nv)
        {
            string sql = "DELETE FROM NhanVien WHERE MaNhanVien = " + nv.MaNhanVien1;
            query.insert(sql);
        }
        public void update(Class_NhanVien nv)
        {
            string sql = "UPDATE NhanVien WHERE SET MaNhanVien=" + nv.MaNhanVien1 + ",TenNhanVien=N'" +
                nv.TenNhanVien1 + "', GioiTinh=N'" + nv.GioiTinh1 + "', NgaySinh='" + nv.NgaySinh1 + ",DiaChi=N'" + nv.DiaChi1 + ",MaQue=N'" + nv.MaQue1 + ",DienThoai=N'" + nv.DienThoai1+"')";
            query.insert(sql);
        }
    }
}
