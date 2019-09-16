using QuanLyBanHang.Model_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Repository.ConnectAndQuery
{
    class QueryCongDung
    {
        private GeneralQuery query;
        public QueryCongDung()
        {
            query = new GeneralQuery();
        }
        public void insert(Class_CongDung cd)
        {
            string sql = "INSERT INTO CongDung(MaCongDung,TenCongDung) VALUES(";
            sql +=cd.MaCongDung1 + ",N'" + cd.TenCongDung1 + "')";
            query.insert(sql);
        }
        public void delete(Class_CongDung cd)
        {
            string sql = "DELETE FROM CongDung WHERE MaCongDung = " + cd.MaCongDung1;
            query.insert(sql);
            query.insert(sql);
        }
        public void update(Class_CongDung cd)
        {
            string sql = "UPDATE CongDung WHERE SET MaCongDung=" + cd.MaCongDung1 + ",TenCongDung=N'" +
              cd.TenCongDung1  + "')";
            query.insert(sql);
        }
    }
}
