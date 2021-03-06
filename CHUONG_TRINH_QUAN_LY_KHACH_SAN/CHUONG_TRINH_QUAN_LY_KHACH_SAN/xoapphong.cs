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
    public partial class frmxoapphong : Form
    {
        public frmxoapphong()
        {
            InitializeComponent();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string baoloi = "";
            database xoa = new database();
            database xem = new database();
            dtgrxoaphong.DataSource = xoa.Execute_Procedure(ref baoloi, "sp_xoaphong", CommandType.StoredProcedure,
                new SqlParameter("@maphong", txtmaphong.Text),
                new SqlParameter("@loaiphong", txtloaiphong.Text),
                new SqlParameter("@giaphong", txtgiaphong.Text),
                new SqlParameter("@sogiuong", txtsogiuong.Text));
            dtgrxoaphong.DataSource = xem.Execute_Procedure(ref baoloi, "sp_xemphong", CommandType.StoredProcedure);
        }
    }
}
