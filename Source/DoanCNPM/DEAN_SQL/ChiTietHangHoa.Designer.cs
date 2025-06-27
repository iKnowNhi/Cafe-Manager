namespace DEAN_SQL
{
    partial class ChiTietHangHoa
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
            this.cbomahg = new System.Windows.Forms.ComboBox();
            this.cbomanl = new System.Windows.Forms.ComboBox();
            this.txtdvt = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.lbldvt = new System.Windows.Forms.Label();
            this.lblmahg = new System.Windows.Forms.Label();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.lblmanl = new System.Windows.Forms.Label();
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
            this.btnclear.Location = new System.Drawing.Point(699, 281);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(146, 46);
            this.btnclear.TabIndex = 28;
            this.btnclear.Text = "Mới";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(493, 281);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(146, 46);
            this.btnsua.TabIndex = 27;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(291, 281);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(146, 46);
            this.btnxoa.TabIndex = 26;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(89, 281);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(146, 46);
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
            this.label5.Location = new System.Drawing.Point(436, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "APP";
            // 
            // grpnhapthongtin
            // 
            this.grpnhapthongtin.Controls.Add(this.cbomahg);
            this.grpnhapthongtin.Controls.Add(this.cbomanl);
            this.grpnhapthongtin.Controls.Add(this.txtdvt);
            this.grpnhapthongtin.Controls.Add(this.txtsoluong);
            this.grpnhapthongtin.Controls.Add(this.lbldvt);
            this.grpnhapthongtin.Controls.Add(this.lblmahg);
            this.grpnhapthongtin.Controls.Add(this.lblsoluong);
            this.grpnhapthongtin.Controls.Add(this.lblmanl);
            this.grpnhapthongtin.ForeColor = System.Drawing.Color.White;
            this.grpnhapthongtin.Location = new System.Drawing.Point(89, 66);
            this.grpnhapthongtin.Name = "grpnhapthongtin";
            this.grpnhapthongtin.Size = new System.Drawing.Size(756, 201);
            this.grpnhapthongtin.TabIndex = 23;
            this.grpnhapthongtin.TabStop = false;
            this.grpnhapthongtin.Text = "Nhập thông tin chi tiết hóa đơn";
            // 
            // cbomahg
            // 
            this.cbomahg.FormattingEnabled = true;
            this.cbomahg.Location = new System.Drawing.Point(133, 42);
            this.cbomahg.Name = "cbomahg";
            this.cbomahg.Size = new System.Drawing.Size(215, 24);
            this.cbomahg.TabIndex = 9;
            // 
            // cbomanl
            // 
            this.cbomanl.FormattingEnabled = true;
            this.cbomanl.Location = new System.Drawing.Point(467, 42);
            this.cbomanl.Name = "cbomanl";
            this.cbomanl.Size = new System.Drawing.Size(230, 24);
            this.cbomanl.TabIndex = 8;
            // 
            // txtdvt
            // 
            this.txtdvt.Location = new System.Drawing.Point(467, 119);
            this.txtdvt.Name = "txtdvt";
            this.txtdvt.Size = new System.Drawing.Size(230, 22);
            this.txtdvt.TabIndex = 7;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(133, 125);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(215, 22);
            this.txtsoluong.TabIndex = 5;
            // 
            // lbldvt
            // 
            this.lbldvt.AutoSize = true;
            this.lbldvt.Location = new System.Drawing.Point(397, 124);
            this.lbldvt.Name = "lbldvt";
            this.lbldvt.Size = new System.Drawing.Size(38, 16);
            this.lbldvt.TabIndex = 3;
            this.lbldvt.Text = "DVT:";
            // 
            // lblmahg
            // 
            this.lblmahg.AutoSize = true;
            this.lblmahg.Location = new System.Drawing.Point(58, 45);
            this.lblmahg.Name = "lblmahg";
            this.lblmahg.Size = new System.Drawing.Size(49, 16);
            this.lblmahg.TabIndex = 2;
            this.lblmahg.Text = "MaHG:";
            this.lblmahg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.Location = new System.Drawing.Point(58, 128);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(64, 16);
            this.lblsoluong.TabIndex = 1;
            this.lblsoluong.Text = "SoLuong:";
            // 
            // lblmanl
            // 
            this.lblmanl.AutoSize = true;
            this.lblmanl.Location = new System.Drawing.Point(392, 45);
            this.lblmanl.Name = "lblmanl";
            this.lblmanl.Size = new System.Drawing.Size(46, 16);
            this.lblmanl.TabIndex = 0;
            this.lblmanl.Text = "MaNL:";
            // 
            // grpthongtinhchitiethd
            // 
            this.grpthongtinhchitiethd.Controls.Add(this.lst_dl);
            this.grpthongtinhchitiethd.ForeColor = System.Drawing.Color.White;
            this.grpthongtinhchitiethd.Location = new System.Drawing.Point(89, 333);
            this.grpthongtinhchitiethd.Name = "grpthongtinhchitiethd";
            this.grpthongtinhchitiethd.Size = new System.Drawing.Size(756, 212);
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
            this.columnHeader4});
            this.lst_dl.FullRowSelect = true;
            this.lst_dl.GridLines = true;
            this.lst_dl.HideSelection = false;
            this.lst_dl.Location = new System.Drawing.Point(61, 39);
            this.lst_dl.Name = "lst_dl";
            this.lst_dl.Size = new System.Drawing.Size(636, 148);
            this.lst_dl.TabIndex = 0;
            this.lst_dl.UseCompatibleStateImageBehavior = false;
            this.lst_dl.View = System.Windows.Forms.View.Details;
            this.lst_dl.Click += new System.EventHandler(this.lst_dl_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MAHG";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MANL";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SOLUONG";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DVT";
            this.columnHeader4.Width = 90;
            // 
            // ChiTietHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(935, 562);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpnhapthongtin);
            this.Controls.Add(this.grpthongtinhchitiethd);
            this.Name = "ChiTietHangHoa";
            this.Text = "ChiTietHangHoa";
            this.Load += new System.EventHandler(this.ChiTietHangHoa_Load);
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
        private System.Windows.Forms.ComboBox cbomahg;
        private System.Windows.Forms.ComboBox cbomanl;
        private System.Windows.Forms.TextBox txtdvt;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label lbldvt;
        private System.Windows.Forms.Label lblmahg;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.Label lblmanl;
        private System.Windows.Forms.GroupBox grpthongtinhchitiethd;
        private System.Windows.Forms.ListView lst_dl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}