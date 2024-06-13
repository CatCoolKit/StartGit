namespace Quanlysinhvien_01.GUI
{
    partial class fBangDiemSV
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
            txbDiemTB = new TextBox();
            label9 = new Label();
            txbDiemThi = new TextBox();
            label8 = new Label();
            txbDiemTrenLop = new TextBox();
            panel2 = new Panel();
            dgvDiemSV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            txbLoai = new TextBox();
            label7 = new Label();
            numPTThi = new NumericUpDown();
            numPTTrenLop = new NumericUpDown();
            label6 = new Label();
            txbMaMH = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            txbMaSV = new TextBox();
            label2 = new Label();
            txbID = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDiemSV).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPTThi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPTTrenLop).BeginInit();
            SuspendLayout();
            // 
            // txbDiemTB
            // 
            txbDiemTB.Enabled = false;
            txbDiemTB.Location = new Point(656, 56);
            txbDiemTB.MaxLength = 255;
            txbDiemTB.Name = "txbDiemTB";
            txbDiemTB.Size = new Size(59, 30);
            txbDiemTB.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(561, 60);
            label9.Name = "label9";
            label9.Size = new Size(89, 22);
            label9.TabIndex = 23;
            label9.Text = "Điểm TB:";
            // 
            // txbDiemThi
            // 
            txbDiemThi.Enabled = false;
            txbDiemThi.Location = new Point(499, 56);
            txbDiemThi.MaxLength = 255;
            txbDiemThi.Name = "txbDiemThi";
            txbDiemThi.Size = new Size(56, 30);
            txbDiemThi.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(409, 60);
            label8.Name = "label8";
            label8.Size = new Size(84, 22);
            label8.TabIndex = 21;
            label8.Text = "Điểm thi:";
            // 
            // txbDiemTrenLop
            // 
            txbDiemTrenLop.Enabled = false;
            txbDiemTrenLop.Location = new Point(343, 56);
            txbDiemTrenLop.MaxLength = 255;
            txbDiemTrenLop.Name = "txbDiemTrenLop";
            txbDiemTrenLop.Size = new Size(60, 30);
            txbDiemTrenLop.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvDiemSV);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(902, 479);
            panel2.TabIndex = 13;
            // 
            // dgvDiemSV
            // 
            dgvDiemSV.AllowUserToAddRows = false;
            dgvDiemSV.AllowUserToDeleteRows = false;
            dgvDiemSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiemSV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column5, Column2, Column8, Column4, Column6, Column7, Column9, Column10 });
            dgvDiemSV.Dock = DockStyle.Fill;
            dgvDiemSV.Location = new Point(0, 0);
            dgvDiemSV.MultiSelect = false;
            dgvDiemSV.Name = "dgvDiemSV";
            dgvDiemSV.ReadOnly = true;
            dgvDiemSV.RowHeadersVisible = false;
            dgvDiemSV.RowHeadersWidth = 51;
            dgvDiemSV.RowTemplate.Height = 30;
            dgvDiemSV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiemSV.Size = new Size(902, 479);
            dgvDiemSV.TabIndex = 2;
            dgvDiemSV.TabStop = false;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 65;
            // 
            // Column5
            // 
            Column5.HeaderText = "MÃ SINH VIÊN";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 170;
            // 
            // Column2
            // 
            Column2.HeaderText = "MÃ MÔN HỌC";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 170;
            // 
            // Column8
            // 
            Column8.HeaderText = "TRÊN LỚP (%)";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 165;
            // 
            // Column4
            // 
            Column4.HeaderText = "THI (%)";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "ĐIỂM TRÊN LỚP";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 200;
            // 
            // Column7
            // 
            Column7.HeaderText = "ĐIỂM THI";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "ĐIỂM TB";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "LOẠI";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 125;
            // 
            // panel1
            // 
            panel1.Controls.Add(txbLoai);
            panel1.Controls.Add(txbDiemTB);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txbDiemThi);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txbDiemTrenLop);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(numPTThi);
            panel1.Controls.Add(numPTTrenLop);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txbMaMH);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbMaSV);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 94);
            panel1.TabIndex = 12;
            // 
            // txbLoai
            // 
            txbLoai.Enabled = false;
            txbLoai.Location = new Point(779, 56);
            txbLoai.MaxLength = 255;
            txbLoai.Name = "txbLoai";
            txbLoai.Size = new Size(111, 30);
            txbLoai.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(217, 60);
            label7.Name = "label7";
            label7.Size = new Size(126, 22);
            label7.TabIndex = 19;
            label7.Text = "Điểm trên lớp:";
            // 
            // numPTThi
            // 
            numPTThi.Enabled = false;
            numPTThi.Location = new Point(808, 11);
            numPTThi.Margin = new Padding(6, 3, 6, 3);
            numPTThi.Name = "numPTThi";
            numPTThi.Size = new Size(64, 30);
            numPTThi.TabIndex = 4;
            // 
            // numPTTrenLop
            // 
            numPTTrenLop.Enabled = false;
            numPTTrenLop.Location = new Point(139, 56);
            numPTTrenLop.Margin = new Padding(6, 3, 6, 3);
            numPTTrenLop.Name = "numPTTrenLop";
            numPTTrenLop.Size = new Size(64, 30);
            numPTTrenLop.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(730, 15);
            label6.Name = "label6";
            label6.Size = new Size(79, 22);
            label6.TabIndex = 16;
            label6.Text = "Thi (%):";
            // 
            // txbMaMH
            // 
            txbMaMH.Enabled = false;
            txbMaMH.Location = new Point(548, 11);
            txbMaMH.MaxLength = 255;
            txbMaMH.Name = "txbMaMH";
            txbMaMH.Size = new Size(154, 30);
            txbMaMH.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 60);
            label4.Name = "label4";
            label4.Size = new Size(120, 22);
            label4.TabIndex = 13;
            label4.Text = "Trên lớp (%):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(721, 60);
            label5.Name = "label5";
            label5.Size = new Size(52, 22);
            label5.TabIndex = 12;
            label5.Text = "Loại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(429, 15);
            label3.Name = "label3";
            label3.Size = new Size(113, 22);
            label3.TabIndex = 4;
            label3.Text = "Mã môn học:";
            // 
            // txbMaSV
            // 
            txbMaSV.Enabled = false;
            txbMaSV.Location = new Point(251, 11);
            txbMaSV.MaxLength = 255;
            txbMaSV.Name = "txbMaSV";
            txbMaSV.Size = new Size(160, 30);
            txbMaSV.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 15);
            label2.Name = "label2";
            label2.Size = new Size(118, 22);
            label2.TabIndex = 2;
            label2.Text = "Mã sinh viên:";
            // 
            // txbID
            // 
            txbID.Enabled = false;
            txbID.Location = new Point(54, 11);
            txbID.Name = "txbID";
            txbID.Size = new Size(65, 30);
            txbID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(36, 22);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // fBangDiemSV
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 571);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Enabled = false;
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fBangDiemSV";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bảng điểm sinh viên";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDiemSV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPTThi).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPTTrenLop).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txbDiemTB;
        private Label label9;
        private TextBox txbDiemThi;
        private Label label8;
        private TextBox txbDiemTrenLop;
        private Panel panel2;
        private DataGridView dgvDiemSV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Panel panel1;
        private Label label7;
        private NumericUpDown numPTThi;
        private NumericUpDown numPTTrenLop;
        private Label label6;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox txbID;
        private Label label1;
        private TextBox txbLoai;
        private TextBox txbMaMH;
        private TextBox txbMaSV;
    }
}