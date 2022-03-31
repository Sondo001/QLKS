using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CHUONG_TRINH_QUAN_LY_KHACH_SAN
{
    class database
    {
        public SqlConnection conn;
        public SqlCommand cmd;
        public SqlDataAdapter adapter = null;
        public string str;
        public database()
        {
            str = @"Data Source=DESKTOP-9OIDLHR\SQLSERVER;Initial Catalog=QUANLYKHACHSAN;User ID=sa;pwd = 12345;";
        }
        public void ketnoi()
        {
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.Connection = conn;
            conn.Open();
        }
        public void Close()
        {
            cmd.Dispose();
            conn.Close();
        }
        public void Excecuted_SQL(string sqlin)
        {
            ketnoi();
            cmd = new SqlCommand(sqlin, conn);
            cmd.ExecuteNonQuery();
            Close();
        }
        public DataSet Excecuted_DataSet(string sqlin)
        {
            ketnoi();
            DataSet Table = new DataSet();
            // Sau khi thực thi thì đổ dữ liệu trong Connect -> biến Adappter;
            // Fill Adappter vào DataSet Table;
            adapter = new SqlDataAdapter(sqlin, conn);
            adapter.Fill(Table);
            Close();
            return Table;
        }
        // Lấy dữ liệu thông qua Adapter đổ vào Table ( Data Table)
        public DataTable Excecuted_DataTable(string sqlin)
        {
            ketnoi();
            DataTable DataTable = new DataTable();
            // Sau khi thực thi thì đổ dữ liệu trong Connect -> biến Adappter;
            // Fill Adappter vào DataSet Table;
            adapter = new SqlDataAdapter(sqlin, conn);
            adapter.Fill(DataTable);
            Close();
            return DataTable;
        }
        // Thực thi một câu lệnh sử dụng Stored_procedure của SQL
        public DataTable Execute_Procedure(ref string erro, string sqlin, CommandType ct, params SqlParameter[] param)
        {
            ketnoi();
            DataTable da = new DataTable();
            cmd.CommandText = sqlin;
            cmd.CommandType = ct;
            cmd.Parameters.Clear();
            foreach (SqlParameter p in param)
            {// đổ các tham số của hàm xử lý vào đối tượng command;
                cmd.Parameters.Add(p);
            }
            try
            {
                cmd.ExecuteNonQuery();
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(da);

            }
            catch (SqlException ex)
            {
                erro = ex.Message;
            }
            finally
            {
                Close();
            }
            return da;
        }
        public DataSet Execute_Procedure_DataSet(ref string erro, string sqlin, CommandType ct, params SqlParameter[] param)
        {
            ketnoi();
            DataSet da = new DataSet();
            cmd.CommandText = sqlin;
            cmd.CommandType = ct;
            cmd.Parameters.Clear();
            foreach (SqlParameter p in param)
            {// đổ các tham số của hàm xử lý vào đối tượng command;
                cmd.Parameters.Add(p);
            }
            try
            {
                cmd.ExecuteNonQuery();
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(da);

            }
            catch (SqlException ex)
            {
                erro = ex.Message;
            }
            finally
            {
                Close();
            }
            return da;
        }
    }
}
