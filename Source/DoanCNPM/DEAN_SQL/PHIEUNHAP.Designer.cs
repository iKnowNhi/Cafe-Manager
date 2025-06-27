namespace DEAN_SQL
{
    partial class PHIEUNHAP
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
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txtngaynhap = new System.Windows.Forms.TextBox();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.txtmapn = new System.Windows.Forms.TextBox();
            this.lblmanv = new System.Windows.Forms.Label();
            this.lblngaynhap = new System.Windows.Forms.Label();
            this.lblmancc = new System.Windows.Forms.Label();
            this.lblmapn = new System.Windows.Forms.Label();
            this.grpthongtinhchitiethd = new System.Windows.Forms.GroupBox();
            this.lst_dl = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.grpnhapthongtin.Controls.Add(this.txtmanv);
            this.grpnhapthongtin.Controls.Add(this.txtngaynhap);
            this.grpnhapthongtin.Controls.Add(this.txtmancc);
            this.grpnhapthongtin.Controls.Add(this.txtmapn);
            this.grpnhapthongtin.Controls.Add(this.lblmanv);
            this.grpnhapthongtin.Controls.Add(this.lblngaynhap);
            this.grpnhapthongtin.Controls.Add(this.lblmancc);
            this.grpnhapthongtin.Controls.Add(this.lblmapn);
            this.grpnhapthongtin.ForeColor = System.Drawing.Color.White;
            this.grpnhapthongtin.Location = new System.Drawing.Point(134, 103);
            this.grpnhapthongtin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpnhapthongtin.Name = "grpnhapthongtin";
            this.grpnhapthongtin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpnhapthongtin.Size = new System.Drawing.Size(1134, 314);
            this.grpnhapthongtin.TabIndex = 23;
            this.grpnhapthongtin.TabStop = false;
            this.grpnhapthongtin.Text = "Nhập thông tin phiếu nhập";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(717, 203);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(343, 31);
            this.txtmanv.TabIndex = 7;
            // 
            // txtngaynhap
            // 
            this.txtngaynhap.Location = new System.Drawing.Point(717, 75);
            this.txtngaynhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtngaynhap.Multiline = true;
            this.txtngaynhap.Name = "txtngaynhap";
            this.txtngaynhap.Size = new System.Drawing.Size(343, 32);
            this.txtngaynhap.TabIndex = 6;
            // 
            // txtmancc
            // 
            this.txtmancc.Location = new System.Drawing.Point(194, 203);
            this.txtmancc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(320, 31);
            this.txtmancc.TabIndex = 5;
            // 
            // txtmapn
            // 
            this.txtmapn.Location = new System.Drawing.Point(194, 75);
            this.txtmapn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmapn.Name = "txtmapn";
            this.txtmapn.Size = new System.Drawing.Size(320, 31);
            this.txtmapn.TabIndex = 4;
            // 
            // lblmanv
            // 
            this.lblmanv.AutoSize = true;
            this.lblmanv.Location = new System.Drawing.Point(590, 208);
            this.lblmanv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmanv.Name = "lblmanv";
            this.lblmanv.Size = new System.Drawing.Size(77, 25);
            this.lblmanv.TabIndex = 3;
            this.lblmanv.Text = "MaNV:";
            // 
            // lblngaynhap
            // 
            this.lblngaynhap.AutoSize = true;
            this.lblngaynhap.Location = new System.Drawing.Point(590, 80);
            this.lblngaynhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblngaynhap.Name = "lblngaynhap";
            this.lblngaynhap.Size = new System.Drawing.Size(119, 25);
            this.lblngaynhap.TabIndex = 2;
            this.lblngaynhap.Text = "NgayNhap:";
            this.lblngaynhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblmancc
            // 
            this.lblmancc.AutoSize = true;
            this.lblmancc.Location = new System.Drawing.Point(81, 208);
            this.lblmancc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmancc.Name = "lblmancc";
            this.lblmancc.Size = new System.Drawing.Size(93, 25);
            this.lblmancc.TabIndex = 1;
            this.lblmancc.Text = "MaNCC:";
            // 
            // lblmapn
            // 
            this.lblmapn.AutoSize = true;
            this.lblmapn.Location = new System.Drawing.Point(81, 80);
            this.lblmapn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmapn.Name = "lblmapn";
            this.lblmapn.Size = new System.Drawing.Size(77, 25);
            this.lblmapn.TabIndex = 0;
            this.lblmapn.Text = "MaPN:";
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
            this.grpthongtinhchitiethd.Text = "Thông tin phiếu nhập";
            // 
            // lst_dl
            // 
            this.lst_dl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
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
            this.columnHeader1.Text = "MAPN";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NGAYNHAP";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MANCC";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "MANV";
            this.columnHeader4.Width = 90;
            // 
            // PHIEUNHAP
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
            this.Name = "PHIEUNHAP";
            this.Text = "PHIEUNHAP";
            this.Load += new System.EventHandler(this.PHIEUNHAP_Load);
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
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txtngaynhap;
        private System.Windows.Forms.TextBox txtmancc;
        private System.Windows.Forms.TextBox txtmapn;
        private System.Windows.Forms.Label lblmanv;
        private System.Windows.Forms.Label lblngaynhap;
        private System.Windows.Forms.Label lblmancc;
        private System.Windows.Forms.Label lblmapn;
        private System.Windows.Forms.GroupBox grpthongtinhchitiethd;
        private System.Windows.Forms.ListView lst_dl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}