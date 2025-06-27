namespace DEAN_SQL
{
    partial class NhanVienView
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
            this.txtnguoiql = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.lblnguoiql = new System.Windows.Forms.Label();
            this.lbltennv = new System.Windows.Forms.Label();
            this.lblchucvu = new System.Windows.Forms.Label();
            this.lblmanv = new System.Windows.Forms.Label();
            this.grpthongtinnhacc = new System.Windows.Forms.GroupBox();
            this.lst_dl = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btntuoi = new System.Windows.Forms.Button();
            this.grpnhapthongtin.SuspendLayout();
            this.grpthongtinnhacc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(1082, 439);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(182, 72);
            this.btnclear.TabIndex = 49;
            this.btnclear.Text = "Mới";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(608, 439);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(182, 72);
            this.btnsua.TabIndex = 48;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(370, 439);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(182, 72);
            this.btnxoa.TabIndex = 47;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(134, 439);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(182, 72);
            this.btnthem.TabIndex = 46;
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
            this.label5.TabIndex = 45;
            this.label5.Text = "APP";
            // 
            // grpnhapthongtin
            // 
            this.grpnhapthongtin.Controls.Add(this.txtnguoiql);
            this.grpnhapthongtin.Controls.Add(this.txttennv);
            this.grpnhapthongtin.Controls.Add(this.txtchucvu);
            this.grpnhapthongtin.Controls.Add(this.txtmanv);
            this.grpnhapthongtin.Controls.Add(this.lblnguoiql);
            this.grpnhapthongtin.Controls.Add(this.lbltennv);
            this.grpnhapthongtin.Controls.Add(this.lblchucvu);
            this.grpnhapthongtin.Controls.Add(this.lblmanv);
            this.grpnhapthongtin.ForeColor = System.Drawing.Color.White;
            this.grpnhapthongtin.Location = new System.Drawing.Point(134, 103);
            this.grpnhapthongtin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpnhapthongtin.Name = "grpnhapthongtin";
            this.grpnhapthongtin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpnhapthongtin.Size = new System.Drawing.Size(1134, 314);
            this.grpnhapthongtin.TabIndex = 44;
            this.grpnhapthongtin.TabStop = false;
            this.grpnhapthongtin.Text = "Nhập thông tin nhân viên";
            // 
            // txtnguoiql
            // 
            this.txtnguoiql.Location = new System.Drawing.Point(717, 203);
            this.txtnguoiql.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnguoiql.Name = "txtnguoiql";
            this.txtnguoiql.Size = new System.Drawing.Size(343, 31);
            this.txtnguoiql.TabIndex = 7;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(717, 75);
            this.txttennv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttennv.Multiline = true;
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(343, 32);
            this.txttennv.TabIndex = 6;
            // 
            // txtchucvu
            // 
            this.txtchucvu.Location = new System.Drawing.Point(194, 203);
            this.txtchucvu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(320, 31);
            this.txtchucvu.TabIndex = 5;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(194, 75);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(320, 31);
            this.txtmanv.TabIndex = 4;
            // 
            // lblnguoiql
            // 
            this.lblnguoiql.AutoSize = true;
            this.lblnguoiql.Location = new System.Drawing.Point(590, 208);
            this.lblnguoiql.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnguoiql.Name = "lblnguoiql";
            this.lblnguoiql.Size = new System.Drawing.Size(102, 25);
            this.lblnguoiql.TabIndex = 3;
            this.lblnguoiql.Text = "Người QL";
            // 
            // lbltennv
            // 
            this.lbltennv.AutoSize = true;
            this.lbltennv.Location = new System.Drawing.Point(590, 80);
            this.lbltennv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltennv.Name = "lbltennv";
            this.lbltennv.Size = new System.Drawing.Size(84, 25);
            this.lbltennv.TabIndex = 2;
            this.lbltennv.Text = "TenNV:";
            this.lbltennv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblchucvu
            // 
            this.lblchucvu.AutoSize = true;
            this.lblchucvu.Location = new System.Drawing.Point(81, 208);
            this.lblchucvu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblchucvu.Name = "lblchucvu";
            this.lblchucvu.Size = new System.Drawing.Size(97, 25);
            this.lblchucvu.TabIndex = 1;
            this.lblchucvu.Text = "Chức vụ:";
            // 
            // lblmanv
            // 
            this.lblmanv.AutoSize = true;
            this.lblmanv.Location = new System.Drawing.Point(81, 80);
            this.lblmanv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmanv.Name = "lblmanv";
            this.lblmanv.Size = new System.Drawing.Size(77, 25);
            this.lblmanv.TabIndex = 0;
            this.lblmanv.Text = "MaNV:";
            // 
            // grpthongtinnhacc
            // 
            this.grpthongtinnhacc.Controls.Add(this.lst_dl);
            this.grpthongtinnhacc.ForeColor = System.Drawing.Color.White;
            this.grpthongtinnhacc.Location = new System.Drawing.Point(134, 520);
            this.grpthongtinnhacc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpthongtinnhacc.Name = "grpthongtinnhacc";
            this.grpthongtinnhacc.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpthongtinnhacc.Size = new System.Drawing.Size(1134, 331);
            this.grpthongtinnhacc.TabIndex = 43;
            this.grpthongtinnhacc.TabStop = false;
            this.grpthongtinnhacc.Text = "Thông tin nhân viên";
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
            this.columnHeader1.Text = "MANV";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TENNV";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CHUCVU";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "MAQL";
            this.columnHeader4.Width = 90;
            // 
            // btntuoi
            // 
            this.btntuoi.Location = new System.Drawing.Point(844, 439);
            this.btntuoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntuoi.Name = "btntuoi";
            this.btntuoi.Size = new System.Drawing.Size(182, 72);
            this.btntuoi.TabIndex = 50;
            this.btntuoi.Text = "Tuổi";
            this.btntuoi.UseVisualStyleBackColor = true;
            this.btntuoi.Click += new System.EventHandler(this.btntuoi_Click);
            // 
            // NhanVienView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1402, 878);
            this.Controls.Add(this.btntuoi);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpnhapthongtin);
            this.Controls.Add(this.grpthongtinnhacc);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NhanVienView";
            this.Text = "NhanVienView";
            this.Load += new System.EventHandler(this.NhanVienView_Load);
            this.grpnhapthongtin.ResumeLayout(false);
            this.grpnhapthongtin.PerformLayout();
            this.grpthongtinnhacc.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtnguoiql;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label lblnguoiql;
        private System.Windows.Forms.Label lbltennv;
        private System.Windows.Forms.Label lblchucvu;
        private System.Windows.Forms.Label lblmanv;
        private System.Windows.Forms.GroupBox grpthongtinnhacc;
        private System.Windows.Forms.ListView lst_dl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btntuoi;
    }
}