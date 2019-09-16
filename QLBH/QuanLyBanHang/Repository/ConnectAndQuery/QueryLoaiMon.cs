using QuanLyBanHang.Model_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Repository.ConnectAndQuery
{
    class QueryLoaiMon
    {
        private GeneralQuery query;
        public QueryLoaiMon()
        {
            query = new GeneralQuery();
        }
        public void insert(Class_LoaiMon loai_mon)
        {
            string sql = "INSERT INTO LoaiMon(MaLoai,TenLoai) VALUES(";
            sql +=loai_mon.MaLoai1 + ",N'" + loai_mon.TenLoai1 + "')";
            query.insert(sql);
        }
        public void delete(Class_LoaiMon loai_mon)
        {
            string sql = "DELETE FROM LoaiMon WHERE MaLoaiMon = " + loai_mon.MaLoai1;
            query.insert(sql);
            query.insert(sql);
        }
        public void update(Class_LoaiMon loai_mon)
        {
            string sql = "UPDATE LoaiMon WHERE SET MaLoai=" + loai_mon.MaLoai1 + ",TenLoai=N'" +
             loai_mon.TenLoai1 + "')";
            query.insert(sql);
        }
    }
}
