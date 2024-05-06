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
            GiayToLabel = new Label();
            SDTBox = new TextBox();
            SDTLabel = new Label();
            SDTPanel = new Panel();
            EmailBox = new TextBox();
            EmailLabel = new Label();
            EmailPanel = new Panel();
            NameBox = new TextBox();
            NameLabel = new Label();
            NamePanel = new Panel();
            GioiThieuBox = new RichTextBox();
            GioiThieuLabel = new Label();
            HocVanLabel = new Label();
            KinhNghiemPanel = new Panel();
            KinhNghiemBox = new RichTextBox();
            KinhNghiemLabel = new Label();
            HocVanBox = new RichTextBox();
            GiayToPanel = new Panel();
            HocVanPanel = new Panel();
            TitlePanel = new Panel();
            TitleLabel = new Label();
            ParentPanel = new FlowLayoutPanel();
            ThongTinPanel = new Panel();
            TuChoiBtn = new Button();
            XacNhanBtn = new Button();
            ThongTinLabel = new Label();
            panel2 = new Panel();
            ThongTinUngTuyenPanel = new Panel();
            GioiThieuPanel = new Panel();
            UserInforPanel = new Panel();
            SDTPanel.SuspendLayout();
            EmailPanel.SuspendLayout();
            NamePanel.SuspendLayout();
            KinhNghiemPanel.SuspendLayout();
            GiayToPanel.SuspendLayout();
            HocVanPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            ParentPanel.SuspendLayout();
            ThongTinPanel.SuspendLayout();
            panel2.SuspendLayout();
            ThongTinUngTuyenPanel.SuspendLayout();
            GioiThieuPanel.SuspendLayout();
            UserInforPanel.SuspendLayout();
            SuspendLayout();
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
            // SDTBox
            // 
            SDTBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SDTBox.Location = new Point(147, 13);
            SDTBox.Name = "SDTBox";
            SDTBox.ReadOnly = true;
            SDTBox.Size = new Size(398, 34);
            SDTBox.TabIndex = 1;
            // 
            // SDTLabel
            // 
            SDTLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SDTLabel.AutoSize = true;
            SDTLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SDTLabel.Location = new Point(3, 16);
            SDTLabel.Name = "SDTLabel";
            SDTLabel.Size = new Size(138, 28);
            SDTLabel.TabIndex = 0;
            SDTLabel.Text = "Số điện thoại";
            // 
            // SDTPanel
            // 
            SDTPanel.Controls.Add(SDTBox);
            SDTPanel.Controls.Add(SDTLabel);
            SDTPanel.Location = new Point(0, 145);
            SDTPanel.Name = "SDTPanel";
            SDTPanel.Size = new Size(548, 65);
            SDTPanel.TabIndex = 3;
            // 
            // EmailBox
            // 
            EmailBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmailBox.Location = new Point(147, 13);
            EmailBox.Name = "EmailBox";
            EmailBox.ReadOnly = true;
            EmailBox.Size = new Size(398, 34);
            EmailBox.TabIndex = 1;
            // 
            // EmailLabel
            // 
            EmailLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLabel.Location = new Point(3, 16);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(64, 28);
            EmailLabel.TabIndex = 0;
            EmailLabel.Text = "Email";
            // 
            // EmailPanel
            // 
            EmailPanel.Controls.Add(EmailBox);
            EmailPanel.Controls.Add(EmailLabel);
            EmailPanel.Location = new Point(0, 74);
            EmailPanel.Name = "EmailPanel";
            EmailPanel.Size = new Size(548, 65);
            EmailPanel.TabIndex = 2;
            // 
            // NameBox
            // 
            NameBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NameBox.Location = new Point(147, 13);
            NameBox.Name = "NameBox";
            NameBox.ReadOnly = true;
            NameBox.Size = new Size(398, 34);
            NameBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameLabel.Location = new Point(3, 16);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(104, 28);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Họ và tên";
            // 
            // NamePanel
            // 
            NamePanel.Controls.Add(NameBox);
            NamePanel.Controls.Add(NameLabel);
            NamePanel.Location = new Point(0, 3);
            NamePanel.Name = "NamePanel";
            NamePanel.Size = new Size(548, 65);
            NamePanel.TabIndex = 0;
            // 
            // GioiThieuBox
            // 
            GioiThieuBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GioiThieuBox.Location = new Point(147, 16);
            GioiThieuBox.Name = "GioiThieuBox";
            GioiThieuBox.ReadOnly = true;
            GioiThieuBox.Size = new Size(396, 200);
            GioiThieuBox.TabIndex = 1;
            GioiThieuBox.Text = "";
            // 
            // GioiThieuLabel
            // 
            GioiThieuLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GioiThieuLabel.AutoSize = true;
            GioiThieuLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GioiThieuLabel.Location = new Point(3, 16);
            GioiThieuLabel.Name = "GioiThieuLabel";
            GioiThieuLabel.Size = new Size(106, 56);
            GioiThieuLabel.TabIndex = 0;
            GioiThieuLabel.Text = "Giới thiệu\r\nbản thân";
            // 
            // HocVanLabel
            // 
            HocVanLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HocVanLabel.AutoSize = true;
            HocVanLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HocVanLabel.Location = new Point(3, 16);
            HocVanLabel.Name = "HocVanLabel";
            HocVanLabel.Size = new Size(89, 28);
            HocVanLabel.TabIndex = 0;
            HocVanLabel.Text = "Học vấn";
            // 
            // KinhNghiemPanel
            // 
            KinhNghiemPanel.BorderStyle = BorderStyle.FixedSingle;
            KinhNghiemPanel.Controls.Add(KinhNghiemBox);
            KinhNghiemPanel.Controls.Add(KinhNghiemLabel);
            KinhNghiemPanel.Location = new Point(555, 228);
            KinhNghiemPanel.Name = "KinhNghiemPanel";
            KinhNghiemPanel.Size = new Size(548, 221);
            KinhNghiemPanel.TabIndex = 15;
            // 
            // KinhNghiemBox
            // 
            KinhNghiemBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            KinhNghiemBox.Location = new Point(147, 13);
            KinhNghiemBox.Name = "KinhNghiemBox";
            KinhNghiemBox.ReadOnly = true;
            KinhNghiemBox.Size = new Size(396, 200);
            KinhNghiemBox.TabIndex = 1;
            KinhNghiemBox.Text = "";
            // 
            // KinhNghiemLabel
            // 
            KinhNghiemLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            KinhNghiemLabel.AutoSize = true;
            KinhNghiemLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KinhNghiemLabel.Location = new Point(3, 16);
            KinhNghiemLabel.Name = "KinhNghiemLabel";
            KinhNghiemLabel.Size = new Size(132, 28);
            KinhNghiemLabel.TabIndex = 0;
            KinhNghiemLabel.Text = "Kinh nghiệm";
            // 
            // HocVanBox
            // 
            HocVanBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HocVanBox.Location = new Point(147, 13);
            HocVanBox.Name = "HocVanBox";
            HocVanBox.ReadOnly = true;
            HocVanBox.Size = new Size(396, 200);
            HocVanBox.TabIndex = 1;
            HocVanBox.Text = "";
            // 
            // GiayToPanel
            // 
            GiayToPanel.BackColor = SystemColors.ControlDark;
            GiayToPanel.Controls.Add(GiayToLabel);
            GiayToPanel.Location = new Point(3, 611);
            GiayToPanel.Name = "GiayToPanel";
            GiayToPanel.Size = new Size(1102, 65);
            GiayToPanel.TabIndex = 9;
            // 
            // HocVanPanel
            // 
            HocVanPanel.BorderStyle = BorderStyle.FixedSingle;
            HocVanPanel.Controls.Add(HocVanBox);
            HocVanPanel.Controls.Add(HocVanLabel);
            HocVanPanel.Location = new Point(0, 228);
            HocVanPanel.Name = "HocVanPanel";
            HocVanPanel.Size = new Size(548, 221);
            HocVanPanel.TabIndex = 14;
            // 
            // TitlePanel
            // 
            TitlePanel.BackColor = SystemColors.AppWorkspace;
            TitlePanel.BorderStyle = BorderStyle.Fixed3D;
            TitlePanel.Controls.Add(TitleLabel);
            TitlePanel.Location = new Point(3, 3);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(1102, 75);
            TitlePanel.TabIndex = 7;
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TitleLabel.Location = new Point(3, 17);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(400, 41);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Xác Thực Hồ Sơ Ứng Tuyển";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ParentPanel
            // 
            ParentPanel.AutoScroll = true;
            ParentPanel.BackColor = SystemColors.ControlLight;
            ParentPanel.Controls.Add(TitlePanel);
            ParentPanel.Controls.Add(ThongTinPanel);
            ParentPanel.Controls.Add(panel2);
            ParentPanel.Controls.Add(GiayToPanel);
            ParentPanel.Dock = DockStyle.Fill;
            ParentPanel.Location = new Point(0, 0);
            ParentPanel.Name = "ParentPanel";
            ParentPanel.Size = new Size(1139, 680);
            ParentPanel.TabIndex = 9;
            // 
            // ThongTinPanel
            // 
            ThongTinPanel.BackColor = SystemColors.ControlDark;
            ThongTinPanel.Controls.Add(TuChoiBtn);
            ThongTinPanel.Controls.Add(XacNhanBtn);
            ThongTinPanel.Controls.Add(ThongTinLabel);
            ThongTinPanel.Location = new Point(3, 84);
            ThongTinPanel.Name = "ThongTinPanel";
            ThongTinPanel.Size = new Size(1102, 65);
            ThongTinPanel.TabIndex = 11;
            // 
            // TuChoiBtn
            // 
            TuChoiBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TuChoiBtn.Location = new Point(318, 8);
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
            XacNhanBtn.Location = new Point(183, 8);
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
            // panel2
            // 
            panel2.Controls.Add(ThongTinUngTuyenPanel);
            panel2.Location = new Point(3, 155);
            panel2.Name = "panel2";
            panel2.Size = new Size(1105, 450);
            panel2.TabIndex = 9;
            // 
            // ThongTinUngTuyenPanel
            // 
            ThongTinUngTuyenPanel.Controls.Add(KinhNghiemPanel);
            ThongTinUngTuyenPanel.Controls.Add(HocVanPanel);
            ThongTinUngTuyenPanel.Controls.Add(GioiThieuPanel);
            ThongTinUngTuyenPanel.Controls.Add(UserInforPanel);
            ThongTinUngTuyenPanel.Dock = DockStyle.Fill;
            ThongTinUngTuyenPanel.Font = new Font("Segoe UI", 12F);
            ThongTinUngTuyenPanel.Location = new Point(0, 0);
            ThongTinUngTuyenPanel.Name = "ThongTinUngTuyenPanel";
            ThongTinUngTuyenPanel.Size = new Size(1105, 450);
            ThongTinUngTuyenPanel.TabIndex = 1;
            // 
            // GioiThieuPanel
            // 
            GioiThieuPanel.BorderStyle = BorderStyle.FixedSingle;
            GioiThieuPanel.Controls.Add(GioiThieuBox);
            GioiThieuPanel.Controls.Add(GioiThieuLabel);
            GioiThieuPanel.Location = new Point(555, 0);
            GioiThieuPanel.Name = "GioiThieuPanel";
            GioiThieuPanel.Size = new Size(548, 221);
            GioiThieuPanel.TabIndex = 13;
            // 
            // UserInforPanel
            // 
            UserInforPanel.BorderStyle = BorderStyle.FixedSingle;
            UserInforPanel.Controls.Add(NamePanel);
            UserInforPanel.Controls.Add(EmailPanel);
            UserInforPanel.Controls.Add(SDTPanel);
            UserInforPanel.Location = new Point(0, 0);
            UserInforPanel.Name = "UserInforPanel";
            UserInforPanel.Size = new Size(548, 221);
            UserInforPanel.TabIndex = 16;
            // 
            // NV_XacThucHS_ChiTietHS
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 680);
            Controls.Add(ParentPanel);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "NV_XacThucHS_ChiTietHS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xác Thực Hồ Sơ Ứng Tuyển";
            SDTPanel.ResumeLayout(false);
            SDTPanel.PerformLayout();
            EmailPanel.ResumeLayout(false);
            EmailPanel.PerformLayout();
            NamePanel.ResumeLayout(false);
            NamePanel.PerformLayout();
            KinhNghiemPanel.ResumeLayout(false);
            KinhNghiemPanel.PerformLayout();
            GiayToPanel.ResumeLayout(false);
            GiayToPanel.PerformLayout();
            HocVanPanel.ResumeLayout(false);
            HocVanPanel.PerformLayout();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ParentPanel.ResumeLayout(false);
            ThongTinPanel.ResumeLayout(false);
            ThongTinPanel.PerformLayout();
            panel2.ResumeLayout(false);
            ThongTinUngTuyenPanel.ResumeLayout(false);
            GioiThieuPanel.ResumeLayout(false);
            GioiThieuPanel.PerformLayout();
            UserInforPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label GiayToLabel;
        private TextBox SDTBox;
        private Label SDTLabel;
        private Panel SDTPanel;
        private TextBox EmailBox;
        private Label EmailLabel;
        private Panel EmailPanel;
        private TextBox NameBox;
        private Label NameLabel;
        private Panel NamePanel;
        private RichTextBox GioiThieuBox;
        private Label GioiThieuLabel;
        private Label HocVanLabel;
        private Panel KinhNghiemPanel;
        private RichTextBox KinhNghiemBox;
        private Label KinhNghiemLabel;
        private RichTextBox HocVanBox;
        private Panel GiayToPanel;
        private Panel HocVanPanel;
        private Panel TitlePanel;
        private Label TitleLabel;
        private FlowLayoutPanel ParentPanel;
        private Panel ThongTinPanel;
        internal Button TuChoiBtn;
        internal Button XacNhanBtn;
        private Label ThongTinLabel;
        private Panel panel2;
        private Panel ThongTinUngTuyenPanel;
        private Panel GioiThieuPanel;
        private Panel UserInforPanel;
    }
}