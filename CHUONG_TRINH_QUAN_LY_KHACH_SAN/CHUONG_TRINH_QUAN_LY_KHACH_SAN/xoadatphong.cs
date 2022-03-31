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
    public partial class frmxoadatphong : Form
    {
        public frmxoadatphong()
        {
            InitializeComponent();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string baoloi = "";
            database xoa = new database();
            database xem = new database();
            dtgrxoadatphong.DataSource = xoa.Execute_Procedure(ref baoloi, "sp_xoadatphong", CommandType.StoredProcedure,
                new SqlParameter("@maphong", txtmaphong.Text),
                new SqlParameter("@makhach", txtmakhach.Text),
                new SqlParameter("@ngayden", txtngayden.Text),
                new SqlParameter("@ngaydi", txtngaydi.Text));
            dtgrxoadatphong.DataSource = xem.Execute_Procedure(ref baoloi, "sp_xemdatphong", CommandType.StoredProcedure);
        }
    }
}
