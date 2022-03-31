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
    public partial class frmcapnhatdatphong : Form
    {
        public frmcapnhatdatphong()
        {
            InitializeComponent();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            database capnhat = new database();
            string baoloi = "";
            dtgrcapnhatdatphong.DataSource = capnhat.Execute_Procedure(ref
            baoloi, "sp_capnhatdatphong", CommandType.StoredProcedure, new
            SqlParameter("@maphongcu", txtmaphongcu.Text), new
            SqlParameter("@makhachcu", txtmakhachcu.Text), new
            SqlParameter("@ngaydencu", txtngaydencu.Text), new
            SqlParameter("@ngaydicu", txtngaydicu.Text), new
            SqlParameter("@maphongmoi", txtmaphongmoi.Text), new
            SqlParameter("@makhachmoi", txtmakhachmoi.Text), new
            SqlParameter("@ngaydenmoi", txtngaydenmoi.Text), new
            SqlParameter("@ngaydimoi", txtngaydimoi.Text));
            database xem = new database();
            dtgrcapnhatdatphong.DataSource = xem.Execute_Procedure(ref baoloi,
           "sp_xemdatphong", CommandType.StoredProcedure);
        }
    }
}
