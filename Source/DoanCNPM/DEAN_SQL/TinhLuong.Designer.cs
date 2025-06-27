namespace DEAN_SQL
{
    partial class TinhLuong
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
            this.btntracuu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grpnhapthongtinlichtruc = new System.Windows.Forms.GroupBox();
            this.cbonam = new System.Windows.Forms.ComboBox();
            this.cbothang = new System.Windows.Forms.ComboBox();
            this.cbongay = new System.Windows.Forms.ComboBox();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.grpthongtinlichtruc = new System.Windows.Forms.GroupBox();
            this.lst_dl = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpnhapthongtinlichtruc.SuspendLayout();
            this.grpthongtinlichtruc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btntracuu
            // 
            this.btntracuu.Location = new System.Drawing.Point(776, 53);
            this.btntracuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntracuu.Name = "btntracuu";
            this.btntracuu.Size = new System.Drawing.Size(219, 72);
            this.btntracuu.TabIndex = 32;
            this.btntracuu.Text = "Tra cứu";
            this.btntracuu.UseVisualStyleBackColor = true;
            this.btntracuu.Click += new System.EventHandler(this.btntracuu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(600, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 42);
            this.label5.TabIndex = 31;
            this.label5.Text = "APP";
            // 
            // grpnhapthongtinlichtruc
            // 
            this.grpnhapthongtinlichtruc.Controls.Add(this.cbonam);
            this.grpnhapthongtinlichtruc.Controls.Add(this.cbothang);
            this.grpnhapthongtinlichtruc.Controls.Add(this.cbongay);
            this.grpnhapthongtinlichtruc.Controls.Add(this.lblsoluong);
            this.grpnhapthongtinlichtruc.Controls.Add(this.btntracuu);
            this.grpnhapthongtinlichtruc.ForeColor = System.Drawing.Color.White;
            this.grpnhapthongtinlichtruc.Location = new System.Drawing.Point(134, 103);
            this.grpnhapthongtinlichtruc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpnhapthongtinlichtruc.Name = "grpnhapthongtinlichtruc";
            this.grpnhapthongtinlichtruc.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpnhapthongtinlichtruc.Size = new System.Drawing.Size(1032, 152);
            this.grpnhapthongtinlichtruc.TabIndex = 30;
            this.grpnhapthongtinlichtruc.TabStop = false;
            this.grpnhapthongtinlichtruc.Text = "Nhập thời gian cần tra cứu";
            // 
            // cbonam
            // 
            this.cbonam.FormattingEnabled = true;
            this.cbonam.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cbonam.Location = new System.Drawing.Point(356, 72);
            this.cbonam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbonam.Name = "cbonam";
            this.cbonam.Size = new System.Drawing.Size(120, 33);
            this.cbonam.TabIndex = 38;
            // 
            // cbothang
            // 
            this.cbothang.FormattingEnabled = true;
            this.cbothang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbothang.Location = new System.Drawing.Point(255, 72);
            this.cbothang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbothang.Name = "cbothang";
            this.cbothang.Size = new System.Drawing.Size(79, 33);
            this.cbothang.TabIndex = 37;
            // 
            // cbongay
            // 
            this.cbongay.FormattingEnabled = true;
            this.cbongay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbongay.Location = new System.Drawing.Point(154, 72);
            this.cbongay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbongay.Name = "cbongay";
            this.cbongay.Size = new System.Drawing.Size(79, 33);
            this.cbongay.TabIndex = 36;
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.Location = new System.Drawing.Point(40, 77);
            this.lblsoluong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(107, 25);
            this.lblsoluong.TabIndex = 1;
            this.lblsoluong.Text = "Thời gian:";
            // 
            // grpthongtinlichtruc
            // 
            this.grpthongtinlichtruc.Controls.Add(this.lst_dl);
            this.grpthongtinlichtruc.ForeColor = System.Drawing.Color.White;
            this.grpthongtinlichtruc.Location = new System.Drawing.Point(134, 289);
            this.grpthongtinlichtruc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpthongtinlichtruc.Name = "grpthongtinlichtruc";
            this.grpthongtinlichtruc.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpthongtinlichtruc.Size = new System.Drawing.Size(1032, 464);
            this.grpthongtinlichtruc.TabIndex = 29;
            this.grpthongtinlichtruc.TabStop = false;
            this.grpthongtinlichtruc.Text = "Bảng lương";
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
            this.lst_dl.Location = new System.Drawing.Point(40, 62);
            this.lst_dl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_dl.Name = "lst_dl";
            this.lst_dl.Size = new System.Drawing.Size(952, 370);
            this.lst_dl.TabIndex = 1;
            this.lst_dl.UseCompatibleStateImageBehavior = false;
            this.lst_dl.View = System.Windows.Forms.View.Details;
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
            this.columnHeader3.Text = "SOGIOLAM";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TONGLUONG";
            this.columnHeader4.Width = 100;
            // 
            // TinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1311, 803);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpnhapthongtinlichtruc);
            this.Controls.Add(this.grpthongtinlichtruc);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TinhLuong";
            this.Text = "TinhLuong";
            this.Load += new System.EventHandler(this.TinhLuong_Load);
            this.grpnhapthongtinlichtruc.ResumeLayout(false);
            this.grpnhapthongtinlichtruc.PerformLayout();
            this.grpthongtinlichtruc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btntracuu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpnhapthongtinlichtruc;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.GroupBox grpthongtinlichtruc;
        private System.Windows.Forms.ListView lst_dl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cbonam;
        private System.Windows.Forms.ComboBox cbothang;
        private System.Windows.Forms.ComboBox cbongay;
    }
}