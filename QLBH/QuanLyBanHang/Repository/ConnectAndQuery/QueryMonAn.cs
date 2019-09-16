using QuanLyBanHang.Model_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Repository.ConnectAndQuery
{
    class QueryMonAn
    {
        private GeneralQuery query;
        public QueryMonAn()
        {
            query = new GeneralQuery();
        }
        public void insert(Class_MonAn mon_an)
        {
            string sql = "INSERT INTO MonAn(MaMonAn,TenMonAn,MaCongDung,MaLoai,CachLam,YeuCau,DonGia) VALUES(";
            sql += mon_an.MaMonAn1 + ",N'" + mon_an.TenMonAn1 + "',N'" +mon_an.MaCongDung1 + "',N'" + mon_an.MaLoai1 + "',N'"
                + mon_an.CachLam1 + "',N'" + mon_an.YeuCau1 + "',N'" + mon_an.DonGia1 + "')";
            query.insert(sql);
        }
        public void delete(Class_MonAn mon_an)
        {
            string sql = "DELETE FROM MonAn WHERE MaMonAn = " + mon_an.MaMonAn1;
            query.insert(sql);
        }
        public void update(Class_MonAn mon_an)
        {
            string sql = "UPDATE MonAn WHERE SET MaMonAn=" + mon_an.MaMonAn1 + ",TenMonAn=N'" +
               mon_an.TenMonAn1 + "', MaCongDung=N'" + mon_an.MaCongDung1 + "', MaLoai='" + mon_an.MaLoai1 
                + ",CachLam=N'" + mon_an.CachLam1 + ",YeuCau=N'" + mon_an.YeuCau1 + ",DonGia=N'" + mon_an.DonGia1+ "')";
            query.insert(sql);
        }
    }
}
