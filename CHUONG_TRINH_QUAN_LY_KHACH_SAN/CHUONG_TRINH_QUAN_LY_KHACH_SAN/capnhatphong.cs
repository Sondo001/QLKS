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
    public partial class frmcapnhatphong : Form
    {
        public frmcapnhatphong()
        {
            InitializeComponent();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {

        }

        private void btncapnhat_Click_1(object sender, EventArgs e)
        {
            database capnhat = new database();
            string baoloi = "";
            dtgrcapnhatphong.DataSource = capnhat.Execute_Procedure(ref
            baoloi, "sp_capnhatphong", CommandType.StoredProcedure, new
            SqlParameter("@maphongcu", txtmaphongcu.Text), new
            SqlParameter("@loaiphongcu", txtloaiphongcu.Text), new
            SqlParameter("@giaphongcu", txtgiaphongcu.Text), new
            SqlParameter("@sogiuongcu", txtsogiuongcu.Text), new
            SqlParameter("@maphongmoi", txtmaphongmoi.Text), new
            SqlParameter("@loaiphongmoi", txtloaiphongmoi.Text), new
            SqlParameter("@giaphongmoi", txtgiaphongmoi.Text), new
            SqlParameter("@sogiuongmoi", txtsogiuongmoi.Text));
            database xem = new database();
            dtgrcapnhatphong.DataSource = xem.Execute_Procedure(ref baoloi,
           "sp_xemphong", CommandType.StoredProcedure);
        }
    }
}
