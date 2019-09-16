using QuanLyBanHang.Model_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Repository.ConnectAndQuery
{
    class QueryChiTietPhieuDB
    {
        private GeneralQuery query;
        public QueryChiTietPhieuDB()
        {
            query = new GeneralQuery();
        }
        public void insert(Class_ChiTietPhieuDB CTPDB)
        {
            string sql = "INSERT INTO ChiTietPhieuDB(MaPhieu,MaMonAn,MaLoai,SoLuong,GiamGia,ThanhTien) VALUES(";
            sql += CTPDB.MaPhieu1 + ",N'" + CTPDB.MaMonAn1 + "',N'" +CTPDB.MaLoai1 + "',N'" + CTPDB.SoLuong1 + "',N'" 
                    + CTPDB.GiamGia1 + "',N'" + CTPDB.ThanhTien1 + "')";
            query.insert(sql);
        }
        public void delete(Class_ChiTietPhieuDB CTPDB)
        {
            string sql = "DELETE FROM ChiTietPhieuDB WHERE MaPhieu = " + CTPDB.MaPhieu1 + " and MaMonAn = " +CTPDB.MaMonAn1;
            query.insert(sql);
        }
        public void update(Class_ChiTietPhieuDB CTPDB)
        {
            string sql = "UPDATE ChiTietPhieuDB WHERE SET MaPhieu = " + CTPDB.MaPhieu1 + ",MaMonAn=N'" +
                CTPDB.MaMonAn1+ "', MaLoai=N'" + CTPDB.MaLoai1 + "', SoLuong='" + CTPDB.SoLuong1 + ",GiamGia=N'" + CTPDB.GiamGia1 + ",ThanhTien=N'" + CTPDB.ThanhTien1 +"')";
            query.insert(sql);
        }
    }
}
