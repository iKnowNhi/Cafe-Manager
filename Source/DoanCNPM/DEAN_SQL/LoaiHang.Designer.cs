﻿namespace DEAN_SQL
{
    partial class LoaiHang
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
            this.txttenloai = new System.Windows.Forms.TextBox();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.lbltenhang = new System.Windows.Forms.Label();
            this.lblmahg = new System.Windows.Forms.Label();
            this.grpthongtinhanghoa = new System.Windows.Forms.GroupBox();
            this.lst_dl = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpnhapthongtin.SuspendLayout();
            this.grpthongtinhanghoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(1048, 439);
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
            this.btnsua.Location = new System.Drawing.Point(740, 439);
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
            this.btnxoa.Location = new System.Drawing.Point(436, 439);
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
            this.btnthem.Location = new System.Drawing.Point(134, 439);
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
            this.grpnhapthongtin.Controls.Add(this.txttenloai);
            this.grpnhapthongtin.Controls.Add(this.txtmaloai);
            this.grpnhapthongtin.Controls.Add(this.lbltenhang);
            this.grpnhapthongtin.Controls.Add(this.lblmahg);
            this.grpnhapthongtin.ForeColor = System.Drawing.Color.White;
            this.grpnhapthongtin.Location = new System.Drawing.Point(134, 103);
            this.grpnhapthongtin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpnhapthongtin.Name = "grpnhapthongtin";
            this.grpnhapthongtin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpnhapthongtin.Size = new System.Drawing.Size(1134, 314);
            this.grpnhapthongtin.TabIndex = 30;
            this.grpnhapthongtin.TabStop = false;
            this.grpnhapthongtin.Text = "Nhập thông tin loại hàng";
            // 
            // txttenloai
            // 
            this.txttenloai.Location = new System.Drawing.Point(700, 145);
            this.txttenloai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttenloai.Multiline = true;
            this.txttenloai.Name = "txttenloai";
            this.txttenloai.Size = new System.Drawing.Size(343, 32);
            this.txttenloai.TabIndex = 6;
            // 
            // txtmaloai
            // 
            this.txtmaloai.Location = new System.Drawing.Point(200, 145);
            this.txtmaloai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(320, 31);
            this.txtmaloai.TabIndex = 4;
            // 
            // lbltenhang
            // 
            this.lbltenhang.AutoSize = true;
            this.lbltenhang.Location = new System.Drawing.Point(596, 150);
            this.lbltenhang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltenhang.Name = "lbltenhang";
            this.lbltenhang.Size = new System.Drawing.Size(96, 25);
            this.lbltenhang.TabIndex = 2;
            this.lbltenhang.Text = "TenLoai:";
            this.lbltenhang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblmahg
            // 
            this.lblmahg.AutoSize = true;
            this.lblmahg.Location = new System.Drawing.Point(87, 150);
            this.lblmahg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmahg.Name = "lblmahg";
            this.lblmahg.Size = new System.Drawing.Size(89, 25);
            this.lblmahg.TabIndex = 0;
            this.lblmahg.Text = "MaLoai:";
            // 
            // grpthongtinhanghoa
            // 
            this.grpthongtinhanghoa.Controls.Add(this.lst_dl);
            this.grpthongtinhanghoa.ForeColor = System.Drawing.Color.White;
            this.grpthongtinhanghoa.Location = new System.Drawing.Point(134, 520);
            this.grpthongtinhanghoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpthongtinhanghoa.Name = "grpthongtinhanghoa";
            this.grpthongtinhanghoa.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpthongtinhanghoa.Size = new System.Drawing.Size(1134, 331);
            this.grpthongtinhanghoa.TabIndex = 29;
            this.grpthongtinhanghoa.TabStop = false;
            this.grpthongtinhanghoa.Text = "Thông tin loại hàng";
            // 
            // lst_dl
            // 
            this.lst_dl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
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
            this.columnHeader1.Text = "MALOAI";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TENLOAI";
            this.columnHeader2.Width = 90;
            // 
            // LoaiHang
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
            this.Controls.Add(this.grpthongtinhanghoa);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoaiHang";
            this.Text = "LoaiHang";
            this.Load += new System.EventHandler(this.LoaiHang_Load);
            this.grpnhapthongtin.ResumeLayout(false);
            this.grpnhapthongtin.PerformLayout();
            this.grpthongtinhanghoa.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txttenloai;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.Label lbltenhang;
        private System.Windows.Forms.Label lblmahg;
        private System.Windows.Forms.GroupBox grpthongtinhanghoa;
        private System.Windows.Forms.ListView lst_dl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}