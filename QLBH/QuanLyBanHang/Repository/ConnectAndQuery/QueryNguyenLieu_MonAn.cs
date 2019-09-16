using QuanLyBanHang.Model_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Repository.ConnectAndQuery
{
    class QueryNguyenLieu_MonAn
    {
        private GeneralQuery query;
        public QueryNguyenLieu_MonAn()
        {
            query = new GeneralQuery();
        }
        public void insert(Class_NguyenLieu_MonAn NL_MA)
        {
            string sql = "INSERT INTO NguyenLieu_MonAn(MaMonAn,MaNguyenLieu,SoLuong) VALUES(";
            sql += NL_MA.MaMonAn1 + ",N'" + NL_MA.MaNguyenLieu1 + "',N'" +NL_MA.SoLuong1 + "')";
            query.insert(sql);
        }
        public void delete(Class_NguyenLieu_MonAn NL_MA)
        {
            string sql = "DELETE FROM NguyenLieu_MonAn WHERE MaMonAn = " +NL_MA.MaMonAn1 + " and MaNguyenLieu = " + NL_MA.MaNguyenLieu1;
            query.insert(sql);
            query.insert(sql);
        }
        public void update(Class_NguyenLieu_MonAn NL_MA)
        {
            string sql = "UPDATE NguyenLieu_MonAn WHERE SET MaMonAn=" +NL_MA.MaMonAn1 + ",MaNguyenLieu=N'" +
               NL_MA.MaNguyenLieu1 + "', SoLuong=N'" + NL_MA.SoLuong1 + "')";
            query.insert(sql);
        }
    }
}
