using QuanLyBanHang.Model_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Repository.ConnectAndQuery
{
    class QueryPhieuBanHang
    {
        private GeneralQuery query;
        public QueryPhieuBanHang()
        {
            query = new GeneralQuery();
        }
        public void insert(Class_PhieuDatBan PDB)
        {
            string sql = "INSERT INTO PhieuDatBan(MaPhieu,MaKhach,MaNhanVien,NgayDat,NgayDung,TongTien) VALUES(";
            sql += PDB.MaPhieu1 + ",N'" + PDB.MaKhach1 + "',N'" + PDB.MaNhanVien1 + "',N'" + PDB.NgayDat1 + "',N'" 
                + PDB.NgayDung1 + "',N'" + PDB.TongTien1  + "')";
            query.insert(sql);
        }
        public void delete(Class_PhieuDatBan PDB)
        {
            string sql = "DELETE FROM PhieuDatBan WHERE MaPhieu = " + PDB.MaPhieu1;
            query.insert(sql);
        }
        public void update(Class_PhieuDatBan PDB)
        {
            string sql = "UPDATE PhieuDatBan WHERE SET MaPhieu=" + PDB.MaPhieu1 + ",MaKhach=N'" +
               PDB.MaKhach1 + "', MaNhanVien=N'" + PDB.MaNhanVien1 + "', NgayDat='" + PDB.NgayDat1 
               + ",NgayDung=N'" + PDB.NgayDung1 + ",TongTien=N'" + PDB.TongTien1+ "')";
            query.insert(sql);
        }
    }
}
