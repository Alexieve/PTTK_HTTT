namespace GUI
{
    partial class UV_KetQuaHS
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
            panel1 = new Panel();
            XemCTHoSoBtn = new Button();
            KetQuaTb = new DataGridView();
            TitlePanel = new Panel();
            TitleLabel = new Label();
            TENDN = new DataGridViewTextBoxColumn();
            CB_VT = new DataGridViewTextBoxColumn();
            NGAYNOP = new DataGridViewTextBoxColumn();
            KETQUA = new DataGridViewTextBoxColumn();
            ParentPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)KetQuaTb).BeginInit();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // ParentPanel
            // 
            ParentPanel.Controls.Add(panel1);
            ParentPanel.Controls.Add(KetQuaTb);
            ParentPanel.Controls.Add(TitlePanel);
            ParentPanel.Dock = DockStyle.Fill;
            ParentPanel.Font = new Font("Segoe UI", 12F);
            ParentPanel.Location = new Point(0, 0);
            ParentPanel.Name = "ParentPanel";
            ParentPanel.Size = new Size(1077, 721);
            ParentPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(XemCTHoSoBtn);
            panel1.Location = new Point(12, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 52);
            panel1.TabIndex = 11;
            // 
            // XemCTHoSoBtn
            // 
            XemCTHoSoBtn.Location = new Point(12, 8);
            XemCTHoSoBtn.Name = "XemCTHoSoBtn";
            XemCTHoSoBtn.Size = new Size(248, 37);
            XemCTHoSoBtn.TabIndex = 13;
            XemCTHoSoBtn.Text = "Xem Chi Tiết Hồ Sơ";
            XemCTHoSoBtn.UseVisualStyleBackColor = true;
            XemCTHoSoBtn.Click += XemCTHoSoBtn_Click;
            // 
            // KetQuaTb
            // 
            KetQuaTb.AllowUserToAddRows = false;
            KetQuaTb.AllowUserToDeleteRows = false;
            KetQuaTb.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            KetQuaTb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            KetQuaTb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KetQuaTb.Columns.AddRange(new DataGridViewColumn[] { TENDN, CB_VT, NGAYNOP, KETQUA });
            KetQuaTb.Location = new Point(12, 144);
            KetQuaTb.Name = "KetQuaTb";
            KetQuaTb.ReadOnly = true;
            KetQuaTb.RowHeadersWidth = 51;
            KetQuaTb.Size = new Size(1053, 565);
            KetQuaTb.TabIndex = 9;
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
            TitleLabel.Size = new Size(291, 41);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Kết Quả Ứng Tuyển";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TENDN
            // 
            TENDN.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TENDN.HeaderText = "Doanh Nghiệp Ứng Tuyển";
            TENDN.MinimumWidth = 6;
            TENDN.Name = "TENDN";
            TENDN.ReadOnly = true;
            TENDN.Width = 209;
            // 
            // CB_VT
            // 
            CB_VT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CB_VT.HeaderText = "Vị Trí Ứng Tuyển";
            CB_VT.MinimumWidth = 6;
            CB_VT.Name = "CB_VT";
            CB_VT.ReadOnly = true;
            // 
            // NGAYNOP
            // 
            NGAYNOP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NGAYNOP.HeaderText = "Ngày Nộp Hồ Sơ";
            NGAYNOP.MinimumWidth = 6;
            NGAYNOP.Name = "NGAYNOP";
            NGAYNOP.ReadOnly = true;
            // 
            // KETQUA
            // 
            KETQUA.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            KETQUA.HeaderText = "Kết Quả Ứng Tuyển";
            KETQUA.MinimumWidth = 6;
            KETQUA.Name = "KETQUA";
            KETQUA.ReadOnly = true;
            // 
            // UV_KetQuaHS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 721);
            Controls.Add(ParentPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UV_KetQuaHS";
            Text = "KetQuaUngTuyen";
            ParentPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)KetQuaTb).EndInit();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ParentPanel;
        private Panel TitlePanel;
        private Label TitleLabel;
        private DataGridView KetQuaTb;
        private Panel panel1;
        private Button XemCTHoSoBtn;
        private DataGridViewTextBoxColumn TENDN;
        private DataGridViewTextBoxColumn CB_VT;
        private DataGridViewTextBoxColumn NGAYNOP;
        private DataGridViewTextBoxColumn KETQUA;
    }
}