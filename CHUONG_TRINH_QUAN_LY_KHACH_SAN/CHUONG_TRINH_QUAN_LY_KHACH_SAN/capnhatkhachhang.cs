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
    public partial class frmcapnhatkhachhang : Form
    {
        public frmcapnhatkhachhang()
        {
            InitializeComponent();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            database capnhat = new database();
            string baoloi = "";
            dtgrcapnhatkh.DataSource = capnhat.Execute_Procedure(ref
            baoloi, "sp_capnhatkhachhang", CommandType.StoredProcedure, new
            SqlParameter("@makhachcu", txtmakhcu.Text), new
            SqlParameter("@tenkhachcu", txthotencu.Text), new
            SqlParameter("@diachicu", txtdiachicu.Text), new
            SqlParameter("@dienthoaicu", txtdienthoaicu.Text), new
            SqlParameter("@makhachmoi", txtmakhmoi.Text), new
            SqlParameter("@tenkhachmoi", txthotenmoi.Text), new
            SqlParameter("@diachimoi", txtdiachimoi.Text), new
            SqlParameter("@dienthoaimoi", txtdienthoaimoi.Text));
            database xem = new database();
            dtgrcapnhatkh.DataSource = xem.Execute_Procedure(ref baoloi,
           "sp_xemkhachhang", CommandType.StoredProcedure);
        }

        private void frmcapnhatkhachhang_Load(object sender, EventArgs e)
        {

        }
    }
}
