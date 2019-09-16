using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Repository.ConnectAndQuery
{
    class GeneralQuery
    {
        private SqlConnection con;
        public GeneralQuery()
        {
            //tạo đối tượng Connection
            con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Sử dụng Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Application.StartupPath + @"\QLBanHang.mdf;Integrated Security=True";
            con.Open(); // mở kết nối
        }

        public void insert(string sql)
        {
            //Thực thi câu lệnh SQL sử dụng đối tượng Command
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
        public void delete(string sql)
        {
            //Thực thi câu lệnh SQL sử dụng đối tượng Command
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
        public void update(string sql)
        {
            //Thực thi câu lệnh SQL sử dụng đối tượng Command
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
        public void select(string sql)
        {
            //tạo đối tượng DataSet
            DataSet ds = new DataSet();
            //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
            dap.Fill(ds);
        }
    }
}
