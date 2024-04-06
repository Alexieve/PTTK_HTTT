namespace GUI
{
    partial class BaiDangChoDuyetHS
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
            ParentPanel = new Panel();
            BaiDangTb = new DataGridView();
            TitlePanel = new Panel();
            TitleLabel = new Label();
            MAHOPDONG = new DataGridViewTextBoxColumn();
            TENDN = new DataGridViewTextBoxColumn();
            CB_VT = new DataGridViewTextBoxColumn();
            SOLUONG = new DataGridViewTextBoxColumn();
            NGAYKT = new DataGridViewTextBoxColumn();
            ParentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BaiDangTb).BeginInit();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // ParentPanel
            // 
            ParentPanel.Controls.Add(BaiDangTb);
            ParentPanel.Controls.Add(TitlePanel);
            ParentPanel.Dock = DockStyle.Fill;
            ParentPanel.Font = new Font("Segoe UI", 12F);
            ParentPanel.Location = new Point(0, 0);
            ParentPanel.Name = "ParentPanel";
            ParentPanel.Size = new Size(1077, 721);
            ParentPanel.TabIndex = 0;
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
            BaiDangTb.Location = new Point(12, 93);
            BaiDangTb.Name = "BaiDangTb";
            BaiDangTb.ReadOnly = true;
            BaiDangTb.RowHeadersWidth = 51;
            BaiDangTb.Size = new Size(1053, 616);
            BaiDangTb.TabIndex = 9;
            // 
            // TitlePanel
            // 
            TitlePanel.BackColor = SystemColors.AppWorkspace;
            TitlePanel.BorderStyle = BorderStyle.Fixed3D;
            TitlePanel.Controls.Add(TitleLabel);
            TitlePanel.Location = new Point(12, 12);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(1053, 75);
            TitlePanel.TabIndex = 8;
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TitleLabel.Location = new Point(3, 17);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(613, 41);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "DUYỆT HỒ SƠ CỦA CÁC BÀI ĐĂNG TUYỂN";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            TENDN.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TENDN.HeaderText = "Doanh Nghiệp";
            TENDN.MinimumWidth = 6;
            TENDN.Name = "TENDN";
            TENDN.ReadOnly = true;
            TENDN.Width = 178;
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
            // BaiDangChoDuyet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 721);
            Controls.Add(ParentPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BaiDangChoDuyet";
            Text = "BaiDangChoDuyet";
            ParentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BaiDangTb).EndInit();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ParentPanel;
        private Panel TitlePanel;
        private Label TitleLabel;
        private DataGridView BaiDangTb;
        private DataGridViewTextBoxColumn MAHOPDONG;
        private DataGridViewTextBoxColumn TENDN;
        private DataGridViewTextBoxColumn CB_VT;
        private DataGridViewTextBoxColumn SOLUONG;
        private DataGridViewTextBoxColumn NGAYKT;
    }
}