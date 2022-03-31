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
    public partial class frmxoakhachhang : Form
    {
        public frmxoakhachhang()
        {
            InitializeComponent();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string baoloi = "";
            database xoa = new database();
            database xem = new database();
            dtgrxoakhachhang.DataSource = xoa.Execute_Procedure(ref baoloi, "sp_xoakhachhang", CommandType.StoredProcedure,
                new SqlParameter("@makhach", txtmakh.Text),
                new SqlParameter("@tenkhach", txthoten.Text),
                new SqlParameter("@diachi", txtdiachi.Text),
                new SqlParameter("@dienthoai", txtdienthoai.Text));
            dtgrxoakhachhang.DataSource = xem.Execute_Procedure(ref baoloi, "sp_xemkhachhang", CommandType.StoredProcedure);
        }

    }
}
