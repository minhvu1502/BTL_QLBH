using QuanLyBanHang.Model_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Repository.ConnectAndQuery
{
    class QueryQue
    {
        private GeneralQuery query;
        public QueryQue()
        {
            query = new GeneralQuery();
        }
        public void insert(Class_Que que)
        {
            string sql = "INSERT INTO Que(MaQue,TenQue) VALUES(";
            sql += que.MaQue1 + ",N'" + que.TenQue1+ "')";
            query.insert(sql);
        }
        public void delete(Class_Que que)
        {
            string sql = "DELETE FROM Que WHERE MaQue = " + que.MaQue1;
            query.insert(sql);
            query.insert(sql);
        }
        public void update(Class_Que que)
        {
            string sql = "UPDATE Que WHERE SET MaQue = " + que.MaQue1 + ",TenQue=N'" +
             que.TenQue1+ "')";
            query.insert(sql);
        }
    }
}
