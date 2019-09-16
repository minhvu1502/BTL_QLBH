using QuanLyBanHang.Model_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Repository.ConnectAndQuery
{
    class QueryNhaCungCap
    {
        private GeneralQuery query;
        public QueryNhaCungCap()
        {
            query = new GeneralQuery();
        }
        public void insert(Class_NhaCungCap ncc)
        {
            string sql = "INSERT INTO NhaCungCap(MaNhaCungCap,TenNhaCungCap,DiaChi,DienThoai) VALUES(";
            sql += ncc.MaNhaCungCap1 + ",N'" + ncc.TenNhaCungCap1 + "',N'" + ncc.DiaChi1 + "',N'" + ncc.DienThoai1  + "')";
            query.insert(sql);
        }
        public void delete(Class_NhaCungCap ncc)
        {
            string sql = "DELETE FROM NhaCungCap WHERE MaNhaCungCap = " + ncc.MaNhaCungCap1;
            query.insert(sql);
        }
        public void update(Class_NhaCungCap ncc)
        {
            string sql = "UPDATE NhaCungCap WHERE SET MaNhaCungCap=" + ncc.MaNhaCungCap1 + ",TenNhaCungCap=N'" +
              ncc.TenNhaCungCap1 + "', DiaChi=N'" + ncc.DiaChi1 + "', DienThoai='" +ncc.DienThoai1 + "')";
            query.insert(sql);
        }
    }
}
