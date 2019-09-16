using QuanLyBanHang.Model_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Repository.ConnectAndQuery
{
    class QueryNguyenLieu
    {
        private GeneralQuery query;
        public QueryNguyenLieu()
        {
            query = new GeneralQuery();
        }
        public void insert(Class_NguyenLieu NL)
        {
            string sql = "INSERT INTO NguyenLieu(MaNguyenLieu,TenNguyenLieu,DonViTinh,SoLuong,DonGiaNhap,DonGiaBan,CongDung,YeuCau,ChongChiDinh) VALUES(";
            sql += NL.MaNguyenLieu1 + ",N'" + NL.TenNguyenLieu1 + "',N'" + NL.DonViTinh1 + "',N'" + NL.SoLuong1 + "',N'" 
                + NL.DonGiaNhap1 + "',N'" +NL.DonGiaBan1+ "',N'" +NL.CongDung1 + NL.YeuCau1 + "',N'" + NL.ChongChiDinh1 + "')";
            query.insert(sql);
        }
        public void delete(Class_NguyenLieu NL)
        {
            string sql = "DELETE FROM NguyenLieu WHERE MaNguyenLieu = " +NL.MaNguyenLieu1;
            query.insert(sql);
        }
        public void update(Class_NguyenLieu NL)
        {
            string sql = "UPDATE NguyenLieu WHERE SET MaNguyenLieu=" + NL.MaNguyenLieu1+ ",TenNguyenLieu=N'" +
                NL.TenNguyenLieu1 + "', DonViTinh=N'" + NL.DonViTinh1 + "', SoLuong='" + NL.SoLuong1 + ",DonGiaNhap=N'" + NL.DonGiaNhap1 
                + ",DonGiaBan=N'" + NL.DonGiaBan1+ ",CongDung=N'" +NL.CongDung1 + ",YeuCau=N'" + NL.YeuCau1 + ",ChongChiDinh=N'" + NL.ChongChiDinh1 + "')";
            query.insert(sql);
        }
    }
}
