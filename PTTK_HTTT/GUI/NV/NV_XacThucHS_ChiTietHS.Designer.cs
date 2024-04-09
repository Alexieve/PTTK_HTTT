namespace GUI
{
    partial class NV_XacThucHS_ChiTietHS
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
            TitlePanel = new Panel();
            TitleLabel = new Label();
            ParentPanel = new FlowLayoutPanel();
            ThongTinPanel = new Panel();
            TuChoiBtn = new Button();
            XacNhanBtn = new Button();
            ThongTinLabel = new Label();
            GiayToPanel = new Panel();
            GiayToLabel = new Label();
            TitlePanel.SuspendLayout();
            ParentPanel.SuspendLayout();
            ThongTinPanel.SuspendLayout();
            GiayToPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TitlePanel
            // 
            TitlePanel.BackColor = SystemColors.AppWorkspace;
            TitlePanel.BorderStyle = BorderStyle.Fixed3D;
            TitlePanel.Controls.Add(TitleLabel);
            TitlePanel.Location = new Point(3, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(1139, 75);
            TitlePanel.TabIndex = 7;
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TitleLabel.Location = new Point(3, 17);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(293, 41);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Duyệt Hồ Sơ MAHS";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ParentPanel
            // 
            ParentPanel.AutoScroll = true;
            ParentPanel.BackColor = SystemColors.ControlLight;
            ParentPanel.Controls.Add(ThongTinPanel);
            ParentPanel.Controls.Add(GiayToPanel);
            ParentPanel.Location = new Point(3, 78);
            ParentPanel.Name = "ParentPanel";
            ParentPanel.Size = new Size(1139, 497);
            ParentPanel.TabIndex = 8;
            // 
            // ThongTinPanel
            // 
            ThongTinPanel.BackColor = SystemColors.ControlDark;
            ThongTinPanel.Controls.Add(TuChoiBtn);
            ThongTinPanel.Controls.Add(XacNhanBtn);
            ThongTinPanel.Controls.Add(ThongTinLabel);
            ThongTinPanel.Location = new Point(3, 3);
            ThongTinPanel.Name = "ThongTinPanel";
            ThongTinPanel.Size = new Size(1102, 65);
            ThongTinPanel.TabIndex = 11;
            // 
            // TuChoiBtn
            // 
            TuChoiBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TuChoiBtn.Location = new Point(321, 7);
            TuChoiBtn.Name = "TuChoiBtn";
            TuChoiBtn.Size = new Size(129, 46);
            TuChoiBtn.TabIndex = 2;
            TuChoiBtn.Text = "Từ chối";
            TuChoiBtn.UseVisualStyleBackColor = true;
            TuChoiBtn.Click += TuChoiBtn_Click;
            // 
            // XacNhanBtn
            // 
            XacNhanBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            XacNhanBtn.Location = new Point(186, 7);
            XacNhanBtn.Name = "XacNhanBtn";
            XacNhanBtn.Size = new Size(129, 46);
            XacNhanBtn.TabIndex = 1;
            XacNhanBtn.Text = "Xác nhận";
            XacNhanBtn.UseVisualStyleBackColor = true;
            XacNhanBtn.Click += XacNhanBtn_Click;
            // 
            // ThongTinLabel
            // 
            ThongTinLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ThongTinLabel.AutoSize = true;
            ThongTinLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThongTinLabel.Location = new Point(3, 16);
            ThongTinLabel.Name = "ThongTinLabel";
            ThongTinLabel.Size = new Size(174, 28);
            ThongTinLabel.TabIndex = 0;
            ThongTinLabel.Text = "Thông tin cơ bản";
            // 
            // GiayToPanel
            // 
            GiayToPanel.BackColor = SystemColors.ControlDark;
            GiayToPanel.Controls.Add(GiayToLabel);
            GiayToPanel.Location = new Point(3, 74);
            GiayToPanel.Name = "GiayToPanel";
            GiayToPanel.Size = new Size(1102, 65);
            GiayToPanel.TabIndex = 9;
            // 
            // GiayToLabel
            // 
            GiayToLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            GiayToLabel.AutoSize = true;
            GiayToLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GiayToLabel.Location = new Point(3, 16);
            GiayToLabel.Name = "GiayToLabel";
            GiayToLabel.Size = new Size(170, 28);
            GiayToLabel.TabIndex = 0;
            GiayToLabel.Text = "Giấy tờ ứng viên";
            // 
            // NV_XacThucHS_ChiTietHS
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 608);
            Controls.Add(TitlePanel);
            Controls.Add(ParentPanel);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "NV_XacThucHS_ChiTietHS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Duyệt Hồ Sơ Ứng Tuyển";
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ParentPanel.ResumeLayout(false);
            ThongTinPanel.ResumeLayout(false);
            ThongTinPanel.PerformLayout();
            GiayToPanel.ResumeLayout(false);
            GiayToPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel TitlePanel;
        private Label TitleLabel;
        private FlowLayoutPanel ParentPanel;
        private Panel GiayToPanel;
        private Label GiayToLabel;
        private Panel ThongTinPanel;
        private Button TuChoiBtn;
        private Button XacNhanBtn;
        private Label ThongTinLabel;
    }
}