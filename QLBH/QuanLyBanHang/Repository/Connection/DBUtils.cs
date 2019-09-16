using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyBanHang.Repository.Connection
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"DESKTOP-RPK6PAD\SQLEXPRESS";

            string database = "QuanLyBanHang";
            string username = "Admin";
            string password = "admin";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }

}
