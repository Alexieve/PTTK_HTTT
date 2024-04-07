namespace GUI
{
    partial class NV_DuyetHoSo_DSBaiDang
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            BaiDangTb = new DataGridView();
            MAHOPDONG = new DataGridViewTextBoxColumn();
            TENDN = new DataGridViewTextBoxColumn();
            CB_VT = new DataGridViewTextBoxColumn();
            SOLUONG = new DataGridViewTextBoxColumn();
            NGAYKT = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            XemDSHoSoBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)BaiDangTb).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BaiDangTb
            // 
            BaiDangTb.AllowUserToAddRows = false;
            BaiDangTb.AllowUserToDeleteRows = false;
            BaiDangTb.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            BaiDangTb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            BaiDangTb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BaiDangTb.Columns.AddRange(new DataGridViewColumn[] { MAHOPDONG, TENDN, CB_VT, SOLUONG, NGAYKT });
            BaiDangTb.Location = new Point(0, 58);
            BaiDangTb.Name = "BaiDangTb";
            BaiDangTb.ReadOnly = true;
            BaiDangTb.RowHeadersWidth = 51;
            BaiDangTb.Size = new Size(1053, 536);
            BaiDangTb.TabIndex = 10;
            // 
            // MAHOPDONG
            // 
            MAHOPDONG.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MAHOPDONG.HeaderText = "Mã Bài Đăng";
            MAHOPDONG.MinimumWidth = 6;
            MAHOPDONG.Name = "MAHOPDONG";
            MAHOPDONG.ReadOnly = true;
            // 
            // TENDN
            // 
            TENDN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TENDN.HeaderText = "Doanh Nghiệp";
            TENDN.MinimumWidth = 6;
            TENDN.Name = "TENDN";
            TENDN.ReadOnly = true;
            // 
            // CB_VT
            // 
            CB_VT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CB_VT.HeaderText = "Vị Trí Ứng Tuyển";
            CB_VT.MinimumWidth = 6;
            CB_VT.Name = "CB_VT";
            CB_VT.ReadOnly = true;
            // 
            // SOLUONG
            // 
            SOLUONG.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SOLUONG.HeaderText = "Số Lượng Hồ Sơ";
            SOLUONG.MinimumWidth = 6;
            SOLUONG.Name = "SOLUONG";
            SOLUONG.ReadOnly = true;
            // 
            // NGAYKT
            // 
            NGAYKT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NGAYKT.HeaderText = "Hạn Chót Nộp Hồ Sơ";
            NGAYKT.MinimumWidth = 6;
            NGAYKT.Name = "NGAYKT";
            NGAYKT.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(XemDSHoSoBtn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 52);
            panel1.TabIndex = 12;
            // 
            // XemDSHoSoBtn
            // 
            XemDSHoSoBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            XemDSHoSoBtn.Location = new Point(12, 8);
            XemDSHoSoBtn.Name = "XemDSHoSoBtn";
            XemDSHoSoBtn.Size = new Size(248, 37);
            XemDSHoSoBtn.TabIndex = 0;
            XemDSHoSoBtn.Text = "Xem Danh Sách Hồ Sơ";
            XemDSHoSoBtn.UseVisualStyleBackColor = true;
            XemDSHoSoBtn.Click += XemDSHoSoBtn_Click;
            // 
            // NV_DuyetHoSo_DSBaiDang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 594);
            Controls.Add(panel1);
            Controls.Add(BaiDangTb);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NV_DuyetHoSo_DSBaiDang";
            Text = "DuyetHoSo_DSBaiDang";
            ((System.ComponentModel.ISupportInitialize)BaiDangTb).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView BaiDangTb;
        private Panel panel1;
        private Button XemDSHoSoBtn;
        private DataGridViewTextBoxColumn MAHOPDONG;
        private DataGridViewTextBoxColumn TENDN;
        private DataGridViewTextBoxColumn CB_VT;
        private DataGridViewTextBoxColumn SOLUONG;
        private DataGridViewTextBoxColumn NGAYKT;
    }
}