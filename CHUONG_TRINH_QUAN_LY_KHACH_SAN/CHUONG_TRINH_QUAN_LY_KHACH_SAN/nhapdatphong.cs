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
    public partial class frmnhapdatphong : Form
    {
        public frmnhapdatphong()
        {
            InitializeComponent();
        }

        private void btnnhapdatphong_Click(object sender, EventArgs e)
        {
            string baoloi = "";
            database nhap = new database();
            dtgrnhapdatphong.DataSource = nhap.Execute_Procedure(ref baoloi, "sp_nhapdatphong", CommandType.StoredProcedure,
                new SqlParameter("@makhach", txtmakhach.Text),
                new SqlParameter("@maphong", txtmaphong.Text),
                new SqlParameter("@ngayden", txtngayden.Text),
                new SqlParameter("@ngaydi", txtngaydi.Text));
            database xem = new database();
            dtgrnhapdatphong.DataSource = xem.Execute_Procedure(ref baoloi, "sp_xemdatphong", CommandType.StoredProcedure);

        }
    }
}
