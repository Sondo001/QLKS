
namespace CHUONG_TRINH_QUAN_LY_KHACH_SAN
{
    partial class frmxemkhachhang
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
            this.dtgrxemkh = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxemkhachhang = new System.Windows.Forms.Button();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrxemkh)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrxemkh
            // 
            this.dtgrxemkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrxemkh.Location = new System.Drawing.Point(24, 243);
            this.dtgrxemkh.Name = "dtgrxemkh";
            this.dtgrxemkh.Size = new System.Drawing.Size(587, 175);
            this.dtgrxemkh.TabIndex = 29;
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.Red;
            this.btnthoat.Location = new System.Drawing.Point(505, 181);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(107, 40);
            this.btnthoat.TabIndex = 27;
            this.btnthoat.Text = ">>Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnxemkhachhang
            // 
            this.btnxemkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxemkhachhang.ForeColor = System.Drawing.Color.Red;
            this.btnxemkhachhang.Location = new System.Drawing.Point(392, 181);
            this.btnxemkhachhang.Name = "btnxemkhachhang";
            this.btnxemkhachhang.Size = new System.Drawing.Size(107, 40);
            this.btnxemkhachhang.TabIndex = 28;
            this.btnxemkhachhang.Text = ">>Xem";
            this.btnxemkhachhang.UseVisualStyleBackColor = true;
            this.btnxemkhachhang.Click += new System.EventHandler(this.btnxemkhachhang_Click);
            // 
            // txtmakh
            // 
            this.txtmakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmakh.Location = new System.Drawing.Point(210, 186);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(159, 29);
            this.txtmakh.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "MÃ KHÁCH HÀNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 73);
            this.label1.TabIndex = 18;
            this.label1.Text = "Xem Thông Tin Khách Hàng";
            // 
            // frmxemkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgrxemkh);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxemkhachhang);
            this.Controls.Add(this.txtmakh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmxemkhachhang";
            this.Text = "xemkhachhang";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrxemkh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrxemkh;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxemkhachhang;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}