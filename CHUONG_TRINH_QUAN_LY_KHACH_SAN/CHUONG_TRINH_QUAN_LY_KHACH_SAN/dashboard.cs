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
    public partial class frmmain : Form
    {
        private bool isCollapsed;
        public frmmain()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void btntrangchu_Click(object sender, EventArgs e)
        {
            loadform(new frmtrangchu());
        }
        private void btndatphong_Click(object sender, EventArgs e)
        {

        }

        private void btnphong_Click(object sender, EventArgs e)
        {

        }


        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nhậpKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmnhapkhachhang());
        }

        private void xóaPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loadform(new frmxoakhachhang());
        }

        private void xemKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmxemkhachhang());
        }

        private void nhậpPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmnhapphong());
        }

        private void xóaKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmxoakhachhang());
        }

        private void xemPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmxemphong());
        }

        private void xóaPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmxoapphong());
        }

        private void xemPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loadform(new frmxemdatphong());
        }

        private void cậpNhậtKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmcapnhatkhachhang());
        }

        private void cậpNhậtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmcapnhatphong());
        }

        private void cậpNhậtPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loadform(new frmcapnhatdatphong());
        }

        private void nhậpThôngTinĐặtPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmnhapdatphong());
        }
    }
}
