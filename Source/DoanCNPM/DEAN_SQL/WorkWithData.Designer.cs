﻿namespace DEAN_SQL
{
    partial class WorkWithData
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnImportNewTable = new System.Windows.Forms.Button();
            this.txtNewTableName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDestinationTable = new System.Windows.Forms.ComboBox();
            this.btnExportAll = new System.Windows.Forms.Button();
            this.cboChooseTableToExport = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.lblChooseSheet = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.cboChooseSheet = new System.Windows.Forms.ComboBox();
            this.lblPhanQuyen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblChooseFilePath = new System.Windows.Forms.Label();
            this.dgvwShowData = new System.Windows.Forms.DataGridView();
            this.hANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnReturnAdminPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwShowData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImportNewTable
            // 
            this.btnImportNewTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportNewTable.Location = new System.Drawing.Point(946, 394);
            this.btnImportNewTable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnImportNewTable.Name = "btnImportNewTable";
            this.btnImportNewTable.Size = new System.Drawing.Size(456, 72);
            this.btnImportNewTable.TabIndex = 40;
            this.btnImportNewTable.Text = "Import a new Table";
            this.btnImportNewTable.UseVisualStyleBackColor = true;
            this.btnImportNewTable.Click += new System.EventHandler(this.btnImportNewTable_Click);
            // 
            // txtNewTableName
            // 
            this.txtNewTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewTableName.Location = new System.Drawing.Point(472, 408);
            this.txtNewTableName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNewTableName.Name = "txtNewTableName";
            this.txtNewTableName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNewTableName.Size = new System.Drawing.Size(444, 44);
            this.txtNewTableName.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 412);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 37);
            this.label4.TabIndex = 38;
            this.label4.Text = "Enter new Table Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 319);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 37);
            this.label3.TabIndex = 37;
            this.label3.Text = "Choose destination table";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 506);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 37);
            this.label1.TabIndex = 36;
            this.label1.Text = "Choose Table to Export";
            // 
            // cboDestinationTable
            // 
            this.cboDestinationTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDestinationTable.FormattingEnabled = true;
            this.cboDestinationTable.Location = new System.Drawing.Point(472, 314);
            this.cboDestinationTable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboDestinationTable.Name = "cboDestinationTable";
            this.cboDestinationTable.Size = new System.Drawing.Size(444, 45);
            this.cboDestinationTable.TabIndex = 35;
            // 
            // btnExportAll
            // 
            this.btnExportAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportAll.Location = new System.Drawing.Point(1180, 488);
            this.btnExportAll.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExportAll.Name = "btnExportAll";
            this.btnExportAll.Size = new System.Drawing.Size(222, 72);
            this.btnExportAll.TabIndex = 34;
            this.btnExportAll.Text = "Export All";
            this.btnExportAll.UseVisualStyleBackColor = true;
            this.btnExportAll.Click += new System.EventHandler(this.btnExportAll_Click);
            // 
            // cboChooseTableToExport
            // 
            this.cboChooseTableToExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChooseTableToExport.FormattingEnabled = true;
            this.cboChooseTableToExport.Location = new System.Drawing.Point(472, 502);
            this.cboChooseTableToExport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboChooseTableToExport.Name = "cboChooseTableToExport";
            this.cboChooseTableToExport.Size = new System.Drawing.Size(444, 45);
            this.cboChooseTableToExport.TabIndex = 33;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(946, 488);
            this.btnExport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(222, 72);
            this.btnExport.TabIndex = 32;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(946, 300);
            this.btnImport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(456, 72);
            this.btnImport.TabIndex = 31;
            this.btnImport.Text = "Import into Available Table";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblChooseSheet
            // 
            this.lblChooseSheet.AutoSize = true;
            this.lblChooseSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseSheet.ForeColor = System.Drawing.Color.White;
            this.lblChooseSheet.Location = new System.Drawing.Point(44, 223);
            this.lblChooseSheet.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblChooseSheet.Name = "lblChooseSheet";
            this.lblChooseSheet.Size = new System.Drawing.Size(349, 37);
            this.lblChooseSheet.TabIndex = 30;
            this.lblChooseSheet.Text = "Choose sheet to Import";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(472, 127);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFilePath.Size = new System.Drawing.Size(660, 44);
            this.txtFilePath.TabIndex = 29;
            // 
            // cboChooseSheet
            // 
            this.cboChooseSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChooseSheet.FormattingEnabled = true;
            this.cboChooseSheet.Location = new System.Drawing.Point(472, 220);
            this.cboChooseSheet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboChooseSheet.Name = "cboChooseSheet";
            this.cboChooseSheet.Size = new System.Drawing.Size(660, 45);
            this.cboChooseSheet.TabIndex = 28;
            // 
            // lblPhanQuyen
            // 
            this.lblPhanQuyen.AutoSize = true;
            this.lblPhanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanQuyen.ForeColor = System.Drawing.Color.White;
            this.lblPhanQuyen.Location = new System.Drawing.Point(1288, 38);
            this.lblPhanQuyen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPhanQuyen.Name = "lblPhanQuyen";
            this.lblPhanQuyen.Size = new System.Drawing.Size(114, 37);
            this.lblPhanQuyen.TabIndex = 27;
            this.lblPhanQuyen.Text = "&Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(40, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 48);
            this.label2.TabIndex = 26;
            this.label2.Text = "Data Manager";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(1176, 114);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(222, 72);
            this.btnBrowse.TabIndex = 25;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblChooseFilePath
            // 
            this.lblChooseFilePath.AutoSize = true;
            this.lblChooseFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseFilePath.ForeColor = System.Drawing.Color.White;
            this.lblChooseFilePath.Location = new System.Drawing.Point(44, 130);
            this.lblChooseFilePath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblChooseFilePath.Name = "lblChooseFilePath";
            this.lblChooseFilePath.Size = new System.Drawing.Size(149, 37);
            this.lblChooseFilePath.TabIndex = 24;
            this.lblChooseFilePath.Text = "File path:";
            // 
            // dgvwShowData
            // 
            this.dgvwShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwShowData.Location = new System.Drawing.Point(50, 572);
            this.dgvwShowData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvwShowData.Name = "dgvwShowData";
            this.dgvwShowData.RowHeadersWidth = 82;
            this.dgvwShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvwShowData.Size = new System.Drawing.Size(1353, 488);
            this.dgvwShowData.TabIndex = 23;
            // 
            // hANGHOABindingSource
            // 
            this.hANGHOABindingSource.DataMember = "HANGHOA";
            // 
            // btnReturnAdminPage
            // 
            this.btnReturnAdminPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnAdminPage.Location = new System.Drawing.Point(1058, 1105);
            this.btnReturnAdminPage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReturnAdminPage.Name = "btnReturnAdminPage";
            this.btnReturnAdminPage.Size = new System.Drawing.Size(344, 83);
            this.btnReturnAdminPage.TabIndex = 41;
            this.btnReturnAdminPage.Text = "Quay về trang quản lý";
            this.btnReturnAdminPage.UseVisualStyleBackColor = true;
            this.btnReturnAdminPage.Click += new System.EventHandler(this.btnReturnAdminPage_Click);
            // 
            // WorkWithData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1442, 1055);
            this.Controls.Add(this.btnReturnAdminPage);
            this.Controls.Add(this.btnImportNewTable);
            this.Controls.Add(this.txtNewTableName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDestinationTable);
            this.Controls.Add(this.btnExportAll);
            this.Controls.Add(this.cboChooseTableToExport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblChooseSheet);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.cboChooseSheet);
            this.Controls.Add(this.lblPhanQuyen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblChooseFilePath);
            this.Controls.Add(this.dgvwShowData);
            this.Name = "WorkWithData";
            this.Text = "WorkWithData";
            this.Load += new System.EventHandler(this.WorkWithData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwShowData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource hANGHOABindingSource;
        private System.Windows.Forms.Button btnImportNewTable;
        private System.Windows.Forms.TextBox txtNewTableName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDestinationTable;
        private System.Windows.Forms.Button btnExportAll;
        private System.Windows.Forms.ComboBox cboChooseTableToExport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblChooseSheet;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.ComboBox cboChooseSheet;
        private System.Windows.Forms.Label lblPhanQuyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblChooseFilePath;
        private System.Windows.Forms.DataGridView dgvwShowData;
        private System.Windows.Forms.Button btnReturnAdminPage;
    }
}