using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CHUONG_TRINH_QUAN_LY_KHACH_SAN
{
    public partial class frmnhapkhachhang : Form
    {
        public frmnhapkhachhang()
        {
            InitializeComponent();
        }

        private void btnnhapkhachhang_Click(object sender, EventArgs e)
        {
            string baoloi = "";
            database nhap = new database();
            dtgrnhapkhach.DataSource = nhap.Execute_Procedure(ref baoloi, "sp_nhapkhachhang", CommandType.StoredProcedure, 
                new SqlParameter("@makhach", txtmakh.Text), 
                new SqlParameter("@tenkhach", txthoten.Text), 
                new SqlParameter("@diachi", txtdiachi.Text), 
                new SqlParameter("@dienthoai", txtdienthoai.Text));
            database xem = new database();
            dtgrnhapkhach.DataSource = xem.Execute_Procedure(ref baoloi, "sp_xemkhachhang", CommandType.StoredProcedure);

        }
    }
}
