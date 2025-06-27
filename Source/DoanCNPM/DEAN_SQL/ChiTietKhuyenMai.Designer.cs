namespace DEAN_SQL
{
    partial class ChiTietKhuyenMai
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
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grpnhapthongtin = new System.Windows.Forms.GroupBox();
            this.txtmakm = new System.Windows.Forms.TextBox();
            this.txtmahg = new System.Windows.Forms.TextBox();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.lbltenkm = new System.Windows.Forms.Label();
            this.lblmahang = new System.Windows.Forms.Label();
            this.lblmahd = new System.Windows.Forms.Label();
            this.grpthongtinhchitiethd = new System.Windows.Forms.GroupBox();
            this.lst_dl = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpnhapthongtin.SuspendLayout();
            this.grpthongtinhchitiethd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.ForeColor = System.Drawing.Color.Black;
            this.btnclear.Location = new System.Drawing.Point(1048, 414);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(219, 72);
            this.btnclear.TabIndex = 35;
            this.btnclear.Text = "Mới";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsua
            // 
            this.btnsua.ForeColor = System.Drawing.Color.Black;
            this.btnsua.Location = new System.Drawing.Point(740, 414);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(219, 72);
            this.btnsua.TabIndex = 34;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.ForeColor = System.Drawing.Color.Black;
            this.btnxoa.Location = new System.Drawing.Point(436, 414);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(219, 72);
            this.btnxoa.TabIndex = 33;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.ForeColor = System.Drawing.Color.Black;
            this.btnthem.Location = new System.Drawing.Point(134, 414);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(219, 72);
            this.btnthem.TabIndex = 32;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(654, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 42);
            this.label5.TabIndex = 31;
            this.label5.Text = "APP";
            // 
            // grpnhapthongtin
            // 
            this.grpnhapthongtin.Controls.Add(this.txtmakm);
            this.grpnhapthongtin.Controls.Add(this.txtmahg);
            this.grpnhapthongtin.Controls.Add(this.txtmahd);
            this.grpnhapthongtin.Controls.Add(this.lbltenkm);
            this.grpnhapthongtin.Controls.Add(this.lblmahang);
            this.grpnhapthongtin.Controls.Add(this.lblmahd);
            this.grpnhapthongtin.ForeColor = System.Drawing.Color.White;
            this.grpnhapthongtin.Location = new System.Drawing.Point(134, 103);
            this.grpnhapthongtin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpnhapthongtin.Name = "grpnhapthongtin";
            this.grpnhapthongtin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpnhapthongtin.Size = new System.Drawing.Size(1134, 277);
            this.grpnhapthongtin.TabIndex = 30;
            this.grpnhapthongtin.TabStop = false;
            this.grpnhapthongtin.Text = "Nhập thông tin khuyến mãi";
            // 
            // txtmakm
            // 
            this.txtmakm.Location = new System.Drawing.Point(700, 67);
            this.txtmakm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmakm.Multiline = true;
            this.txtmakm.Name = "txtmakm";
            this.txtmakm.Size = new System.Drawing.Size(343, 32);
            this.txtmakm.TabIndex = 6;
            // 
            // txtmahg
            // 
            this.txtmahg.Location = new System.Drawing.Point(200, 177);
            this.txtmahg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmahg.Name = "txtmahg";
            this.txtmahg.Size = new System.Drawing.Size(320, 31);
            this.txtmahg.TabIndex = 5;
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(200, 67);
            this.txtmahd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(320, 31);
            this.txtmahd.TabIndex = 4;
            // 
            // lbltenkm
            // 
            this.lbltenkm.AutoSize = true;
            this.lbltenkm.Location = new System.Drawing.Point(596, 72);
            this.lbltenkm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltenkm.Name = "lbltenkm";
            this.lbltenkm.Size = new System.Drawing.Size(80, 25);
            this.lbltenkm.TabIndex = 2;
            this.lbltenkm.Text = "MaKM:";
            this.lbltenkm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblmahang
            // 
            this.lblmahang.AutoSize = true;
            this.lblmahang.Location = new System.Drawing.Point(87, 181);
            this.lblmahang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmahang.Name = "lblmahang";
            this.lblmahang.Size = new System.Drawing.Size(79, 25);
            this.lblmahang.TabIndex = 1;
            this.lblmahang.Text = "MaHG:";
            // 
            // lblmahd
            // 
            this.lblmahd.AutoSize = true;
            this.lblmahd.Location = new System.Drawing.Point(87, 72);
            this.lblmahd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmahd.Name = "lblmahd";
            this.lblmahd.Size = new System.Drawing.Size(78, 25);
            this.lblmahd.TabIndex = 0;
            this.lblmahd.Text = "MaHD:";
            // 
            // grpthongtinhchitiethd
            // 
            this.grpthongtinhchitiethd.Controls.Add(this.lst_dl);
            this.grpthongtinhchitiethd.ForeColor = System.Drawing.Color.White;
            this.grpthongtinhchitiethd.Location = new System.Drawing.Point(134, 520);
            this.grpthongtinhchitiethd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpthongtinhchitiethd.Name = "grpthongtinhchitiethd";
            this.grpthongtinhchitiethd.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpthongtinhchitiethd.Size = new System.Drawing.Size(1134, 331);
            this.grpthongtinhchitiethd.TabIndex = 29;
            this.grpthongtinhchitiethd.TabStop = false;
            this.grpthongtinhchitiethd.Text = "Thông tin chi tiết hóa đơn";
            // 
            // lst_dl
            // 
            this.lst_dl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lst_dl.FullRowSelect = true;
            this.lst_dl.GridLines = true;
            this.lst_dl.HideSelection = false;
            this.lst_dl.Location = new System.Drawing.Point(92, 61);
            this.lst_dl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_dl.Name = "lst_dl";
            this.lst_dl.Size = new System.Drawing.Size(952, 229);
            this.lst_dl.TabIndex = 0;
            this.lst_dl.UseCompatibleStateImageBehavior = false;
            this.lst_dl.View = System.Windows.Forms.View.Details;
            this.lst_dl.Click += new System.EventHandler(this.lst_dl_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MAHD";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MAKM";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MAHG";
            this.columnHeader3.Width = 90;
            // 
            // ChiTietKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1402, 878);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpnhapthongtin);
            this.Controls.Add(this.grpthongtinhchitiethd);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChiTietKhuyenMai";
            this.Text = "ChiTietKhuyenMai";
            this.Load += new System.EventHandler(this.ChiTietKhuyenMai_Load);
            this.grpnhapthongtin.ResumeLayout(false);
            this.grpnhapthongtin.PerformLayout();
            this.grpthongtinhchitiethd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpnhapthongtin;
        private System.Windows.Forms.TextBox txtmakm;
        private System.Windows.Forms.TextBox txtmahg;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.Label lbltenkm;
        private System.Windows.Forms.Label lblmahang;
        private System.Windows.Forms.Label lblmahd;
        private System.Windows.Forms.GroupBox grpthongtinhchitiethd;
        private System.Windows.Forms.ListView lst_dl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}