namespace DEAN_SQL
{
    partial class KhuyenMai
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
            this.txtmota = new System.Windows.Forms.TextBox();
            this.lblmota = new System.Windows.Forms.Label();
            this.txtgiamgia = new System.Windows.Forms.TextBox();
            this.txttenkm = new System.Windows.Forms.TextBox();
            this.txtdieukien = new System.Windows.Forms.TextBox();
            this.txtmakm = new System.Windows.Forms.TextBox();
            this.lblgiamgia = new System.Windows.Forms.Label();
            this.lbltenkm = new System.Windows.Forms.Label();
            this.lbldieukien = new System.Windows.Forms.Label();
            this.lblmakm = new System.Windows.Forms.Label();
            this.grpthongtinhchitiethd = new System.Windows.Forms.GroupBox();
            this.lst_dl = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpnhapthongtin.SuspendLayout();
            this.grpthongtinhchitiethd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(1048, 439);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(219, 72);
            this.btnclear.TabIndex = 28;
            this.btnclear.Text = "Mới";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(740, 439);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(219, 72);
            this.btnsua.TabIndex = 27;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(436, 439);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(219, 72);
            this.btnxoa.TabIndex = 26;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(134, 439);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(219, 72);
            this.btnthem.TabIndex = 25;
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
            this.label5.TabIndex = 24;
            this.label5.Text = "APP";
            // 
            // grpnhapthongtin
            // 
            this.grpnhapthongtin.Controls.Add(this.txtmota);
            this.grpnhapthongtin.Controls.Add(this.lblmota);
            this.grpnhapthongtin.Controls.Add(this.txtgiamgia);
            this.grpnhapthongtin.Controls.Add(this.txttenkm);
            this.grpnhapthongtin.Controls.Add(this.txtdieukien);
            this.grpnhapthongtin.Controls.Add(this.txtmakm);
            this.grpnhapthongtin.Controls.Add(this.lblgiamgia);
            this.grpnhapthongtin.Controls.Add(this.lbltenkm);
            this.grpnhapthongtin.Controls.Add(this.lbldieukien);
            this.grpnhapthongtin.Controls.Add(this.lblmakm);
            this.grpnhapthongtin.ForeColor = System.Drawing.Color.White;
            this.grpnhapthongtin.Location = new System.Drawing.Point(134, 103);
            this.grpnhapthongtin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpnhapthongtin.Name = "grpnhapthongtin";
            this.grpnhapthongtin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpnhapthongtin.Size = new System.Drawing.Size(1134, 314);
            this.grpnhapthongtin.TabIndex = 23;
            this.grpnhapthongtin.TabStop = false;
            this.grpnhapthongtin.Text = "Nhập thông tin khuyến mãi";
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(200, 233);
            this.txtmota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(320, 31);
            this.txtmota.TabIndex = 9;
            // 
            // lblmota
            // 
            this.lblmota.AutoSize = true;
            this.lblmota.Location = new System.Drawing.Point(87, 238);
            this.lblmota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmota.Name = "lblmota";
            this.lblmota.Size = new System.Drawing.Size(67, 25);
            this.lblmota.TabIndex = 8;
            this.lblmota.Text = "MoTa";
            // 
            // txtgiamgia
            // 
            this.txtgiamgia.Location = new System.Drawing.Point(700, 138);
            this.txtgiamgia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtgiamgia.Name = "txtgiamgia";
            this.txtgiamgia.Size = new System.Drawing.Size(343, 31);
            this.txtgiamgia.TabIndex = 7;
            // 
            // txttenkm
            // 
            this.txttenkm.Location = new System.Drawing.Point(700, 67);
            this.txttenkm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttenkm.Multiline = true;
            this.txttenkm.Name = "txttenkm";
            this.txttenkm.Size = new System.Drawing.Size(343, 32);
            this.txttenkm.TabIndex = 6;
            // 
            // txtdieukien
            // 
            this.txtdieukien.Location = new System.Drawing.Point(200, 147);
            this.txtdieukien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdieukien.Name = "txtdieukien";
            this.txtdieukien.Size = new System.Drawing.Size(320, 31);
            this.txtdieukien.TabIndex = 5;
            // 
            // txtmakm
            // 
            this.txtmakm.Location = new System.Drawing.Point(200, 67);
            this.txtmakm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmakm.Name = "txtmakm";
            this.txtmakm.Size = new System.Drawing.Size(320, 31);
            this.txtmakm.TabIndex = 4;
            // 
            // lblgiamgia
            // 
            this.lblgiamgia.AutoSize = true;
            this.lblgiamgia.Location = new System.Drawing.Point(596, 145);
            this.lblgiamgia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgiamgia.Name = "lblgiamgia";
            this.lblgiamgia.Size = new System.Drawing.Size(101, 25);
            this.lblgiamgia.TabIndex = 3;
            this.lblgiamgia.Text = "GiamGia:";
            // 
            // lbltenkm
            // 
            this.lbltenkm.AutoSize = true;
            this.lbltenkm.Location = new System.Drawing.Point(596, 72);
            this.lbltenkm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltenkm.Name = "lbltenkm";
            this.lbltenkm.Size = new System.Drawing.Size(87, 25);
            this.lbltenkm.TabIndex = 2;
            this.lbltenkm.Text = "TenKM:";
            this.lbltenkm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldieukien
            // 
            this.lbldieukien.AutoSize = true;
            this.lbldieukien.Location = new System.Drawing.Point(87, 152);
            this.lbldieukien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldieukien.Name = "lbldieukien";
            this.lbldieukien.Size = new System.Drawing.Size(105, 25);
            this.lbldieukien.TabIndex = 1;
            this.lbldieukien.Text = "DieuKien:";
            // 
            // lblmakm
            // 
            this.lblmakm.AutoSize = true;
            this.lblmakm.Location = new System.Drawing.Point(87, 72);
            this.lblmakm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmakm.Name = "lblmakm";
            this.lblmakm.Size = new System.Drawing.Size(80, 25);
            this.lblmakm.TabIndex = 0;
            this.lblmakm.Text = "MaKM:";
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
            this.grpthongtinhchitiethd.TabIndex = 22;
            this.grpthongtinhchitiethd.TabStop = false;
            this.grpthongtinhchitiethd.Text = "Thông tin chi tiết hóa đơn";
            // 
            // lst_dl
            // 
            this.lst_dl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
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
            this.columnHeader1.Text = "MAKM";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TENKM";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DIEUKIEN";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "GIAMGIA";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MOTA";
            this.columnHeader5.Width = 90;
            // 
            // KhuyenMai
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
            this.Name = "KhuyenMai";
            this.Text = "KhuyenMai";
            this.Load += new System.EventHandler(this.KhuyenMai_Load);
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
        private System.Windows.Forms.TextBox txtgiamgia;
        private System.Windows.Forms.TextBox txttenkm;
        private System.Windows.Forms.TextBox txtdieukien;
        private System.Windows.Forms.TextBox txtmakm;
        private System.Windows.Forms.Label lblgiamgia;
        private System.Windows.Forms.Label lbltenkm;
        private System.Windows.Forms.Label lbldieukien;
        private System.Windows.Forms.Label lblmakm;
        private System.Windows.Forms.GroupBox grpthongtinhchitiethd;
        private System.Windows.Forms.ListView lst_dl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.Label lblmota;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}