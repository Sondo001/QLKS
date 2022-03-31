using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHUONG_TRINH_QUAN_LY_KHACH_SAN
{
    public partial class frmxemdatphong : Form
    {
        public frmxemdatphong()
        {
            InitializeComponent();
        }

        private void btnxemdatphong_Click(object sender, EventArgs e)
        {
            database xem = new database();
            string baoloi = "";
            dtgrxemdatphong.DataSource = xem.Execute_Procedure(ref baoloi, "sp_xemdatphong", CommandType.StoredProcedure);
        }
    }
}
