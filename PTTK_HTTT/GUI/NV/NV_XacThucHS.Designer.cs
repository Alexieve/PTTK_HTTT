namespace GUI
{
    partial class NV_XacThucHS
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            TittlePanel = new Panel();
            TitleLabel = new Label();
            ParentPanel = new Panel();
            panel2 = new Panel();
            XemCTBtn = new Button();
            panel1 = new Panel();
            HoSoTb = new DataGridView();
            MAUV = new DataGridViewTextBoxColumn();
            TenUV = new DataGridViewTextBoxColumn();
            NgayNop = new DataGridViewTextBoxColumn();
            TittlePanel.SuspendLayout();
            ParentPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HoSoTb).BeginInit();
            SuspendLayout();
            // 
            // TittlePanel
            // 
            TittlePanel.BackColor = Color.Gray;
            TittlePanel.Controls.Add(TitleLabel);
            TittlePanel.Location = new Point(0, 0);
            TittlePanel.Name = "TittlePanel";
            TittlePanel.Size = new Size(1077, 80);
            TittlePanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = SystemColors.Control;
            TitleLabel.Location = new Point(0, 19);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(1077, 46);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Xác Thực Hồ Sơ Ứng Tuyển";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ParentPanel
            // 
            ParentPanel.Controls.Add(panel2);
            ParentPanel.Controls.Add(panel1);
            ParentPanel.Controls.Add(TittlePanel);
            ParentPanel.Dock = DockStyle.Fill;
            ParentPanel.Location = new Point(0, 0);
            ParentPanel.Name = "ParentPanel";
            ParentPanel.Size = new Size(1077, 721);
            ParentPanel.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(XemCTBtn);
            panel2.Location = new Point(0, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(1077, 45);
            panel2.TabIndex = 2;
            // 
            // XemCTBtn
            // 
            XemCTBtn.Location = new Point(12, 0);
            XemCTBtn.Name = "XemCTBtn";
            XemCTBtn.Size = new Size(148, 45);
            XemCTBtn.TabIndex = 0;
            XemCTBtn.Text = "Xem Chi Tiết";
            XemCTBtn.UseVisualStyleBackColor = true;
            XemCTBtn.Click += XemCTBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(HoSoTb);
            panel1.Location = new Point(0, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(1077, 584);
            panel1.TabIndex = 1;
            // 
            // HoSoTb
            // 
            HoSoTb.AllowUserToAddRows = false;
            HoSoTb.AllowUserToDeleteRows = false;
            HoSoTb.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            HoSoTb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            HoSoTb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HoSoTb.Columns.AddRange(new DataGridViewColumn[] { MAUV, TenUV, NgayNop });
            HoSoTb.Location = new Point(12, 3);
            HoSoTb.Name = "HoSoTb";
            HoSoTb.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            HoSoTb.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            HoSoTb.RowHeadersWidth = 51;
            HoSoTb.Size = new Size(1053, 569);
            HoSoTb.TabIndex = 0;
            // 
            // MAUV
            // 
            MAUV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MAUV.DefaultCellStyle = dataGridViewCellStyle2;
            MAUV.HeaderText = "Mã Ứng Viên";
            MAUV.MinimumWidth = 6;
            MAUV.Name = "MAUV";
            MAUV.ReadOnly = true;
            // 
            // TenUV
            // 
            TenUV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenUV.HeaderText = "Tên Ứng Viên";
            TenUV.MinimumWidth = 6;
            TenUV.Name = "TenUV";
            TenUV.ReadOnly = true;
            // 
            // NgayNop
            // 
            NgayNop.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgayNop.HeaderText = "Ngày Nộp Hồ Sơ";
            NgayNop.MinimumWidth = 6;
            NgayNop.Name = "NgayNop";
            NgayNop.ReadOnly = true;
            // 
            // NV_XacThucHS
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 721);
            Controls.Add(ParentPanel);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NV_XacThucHS";
            Text = "XacthucHSUV_NV";
            TittlePanel.ResumeLayout(false);
            ParentPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HoSoTb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TittlePanel;
        private Label TitleLabel;
        private Panel ParentPanel;
        private Panel panel2;
        private Button XemCTBtn;
        private Panel panel1;
        private DataGridView HoSoTb;
        private DataGridViewTextBoxColumn MAUV;
        private DataGridViewTextBoxColumn TenUV;
        private DataGridViewTextBoxColumn NgayNop;
    }
}