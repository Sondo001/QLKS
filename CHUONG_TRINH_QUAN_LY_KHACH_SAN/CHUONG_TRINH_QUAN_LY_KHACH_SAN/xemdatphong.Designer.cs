
namespace CHUONG_TRINH_QUAN_LY_KHACH_SAN
{
    partial class frmxemdatphong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgrxemdatphong = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxemdatphong = new System.Windows.Forms.Button();
            this.txtdatphong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrxemdatphong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrxemdatphong
            // 
            this.dtgrxemdatphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrxemdatphong.Location = new System.Drawing.Point(29, 217);
            this.dtgrxemdatphong.Name = "dtgrxemdatphong";
            this.dtgrxemdatphong.Size = new System.Drawing.Size(587, 175);
            this.dtgrxemdatphong.TabIndex = 35;
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.Red;
            this.btnthoat.Location = new System.Drawing.Point(510, 155);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(107, 40);
            this.btnthoat.TabIndex = 33;
            this.btnthoat.Text = ">>Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnxemdatphong
            // 
            this.btnxemdatphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxemdatphong.ForeColor = System.Drawing.Color.Red;
            this.btnxemdatphong.Location = new System.Drawing.Point(397, 155);
            this.btnxemdatphong.Name = "btnxemdatphong";
            this.btnxemdatphong.Size = new System.Drawing.Size(107, 40);
            this.btnxemdatphong.TabIndex = 34;
            this.btnxemdatphong.Text = ">>Xem";
            this.btnxemdatphong.UseVisualStyleBackColor = true;
            this.btnxemdatphong.Click += new System.EventHandler(this.btnxemdatphong_Click);
            // 
            // txtdatphong
            // 
            this.txtdatphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatphong.Location = new System.Drawing.Point(215, 160);
            this.txtdatphong.Name = "txtdatphong";
            this.txtdatphong.Size = new System.Drawing.Size(159, 29);
            this.txtdatphong.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "MÃ PHÒNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 73);
            this.label1.TabIndex = 30;
            this.label1.Text = "Xem Thông Tin Đặt Phòng";
            // 
            // frmxemdatphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgrxemdatphong);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxemdatphong);
            this.Controls.Add(this.txtdatphong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmxemdatphong";
            this.Text = "xemdatphong";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrxemdatphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrxemdatphong;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxemdatphong;
        private System.Windows.Forms.TextBox txtdatphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}