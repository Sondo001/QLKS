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
    public partial class frmnhapphong : Form
    {
        public frmnhapphong()
        {
            InitializeComponent();
        }

        private void btnnhapphong_Click(object sender, EventArgs e)
        {
            string baoloi = "";
            database nhap = new database();
            dtgrnhapphong.DataSource = nhap.Execute_Procedure(ref baoloi, "sp_nhapphong", CommandType.StoredProcedure,
                new SqlParameter("@maphong", txtmaphong.Text),
                new SqlParameter("@tenphong", txttenphong.Text),
                new SqlParameter("@giaphong", txtgiaphong.Text),
                new SqlParameter("@sogiuong", txtsogiuong.Text));
            database xem = new database();
            dtgrnhapphong.DataSource = xem.Execute_Procedure(ref baoloi, "sp_xemphong", CommandType.StoredProcedure);

        }
    }
}
