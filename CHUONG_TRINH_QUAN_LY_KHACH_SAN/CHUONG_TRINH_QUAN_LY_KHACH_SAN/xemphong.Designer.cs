
namespace CHUONG_TRINH_QUAN_LY_KHACH_SAN
{
    partial class frmxemphong
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
            this.dtgrxemphong = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxemphong = new System.Windows.Forms.Button();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrxemphong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrxemphong
            // 
            this.dtgrxemphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrxemphong.Location = new System.Drawing.Point(27, 222);
            this.dtgrxemphong.Name = "dtgrxemphong";
            this.dtgrxemphong.Size = new System.Drawing.Size(587, 175);
            this.dtgrxemphong.TabIndex = 35;
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.Red;
            this.btnthoat.Location = new System.Drawing.Point(508, 160);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(107, 40);
            this.btnthoat.TabIndex = 33;
            this.btnthoat.Text = ">>Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnxemphong
            // 
            this.btnxemphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxemphong.ForeColor = System.Drawing.Color.Red;
            this.btnxemphong.Location = new System.Drawing.Point(395, 160);
            this.btnxemphong.Name = "btnxemphong";
            this.btnxemphong.Size = new System.Drawing.Size(107, 40);
            this.btnxemphong.TabIndex = 34;
            this.btnxemphong.Text = ">>Xem";
            this.btnxemphong.UseVisualStyleBackColor = true;
            this.btnxemphong.Click += new System.EventHandler(this.btnxemphong_Click);
            // 
            // txtmakh
            // 
            this.txtmakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmakh.Location = new System.Drawing.Point(213, 165);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(159, 29);
            this.txtmakh.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "MÃ Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 73);
            this.label1.TabIndex = 30;
            this.label1.Text = "Xem Thông Tin Phòng";
            // 
            // frmxemphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgrxemphong);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxemphong);
            this.Controls.Add(this.txtmakh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmxemphong";
            this.Text = "xemphong";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrxemphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrxemphong;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxemphong;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}