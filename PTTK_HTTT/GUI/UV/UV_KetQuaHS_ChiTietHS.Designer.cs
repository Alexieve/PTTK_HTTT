namespace GUI
{
    partial class UV_KetQuaHS_ChiTietHS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UV_KetQuaHS_ChiTietHS));
            TitlePanel = new Panel();
            TitleLabel = new Label();
            ParentPanel = new FlowLayoutPanel();
            PhanHoiTitlePanel = new Panel();
            label1 = new Label();
            PhanHoiPanel = new Panel();
            richTextBox1 = new RichTextBox();
            ThongTinPanel = new Panel();
            UngTuyenBtn = new Button();
            ThongTinLabel = new Label();
            TTUngTuyenPanel = new Panel();
            ThongTinUngTuyenPanel = new Panel();
            KinhNghiemPanel = new Panel();
            KinhNghiemBox = new RichTextBox();
            KinhNghiemLabel = new Label();
            HocVanPanel = new Panel();
            HocVanBox = new RichTextBox();
            HocVanLabel = new Label();
            GioiThieuPanel = new Panel();
            GioiThieuBox = new RichTextBox();
            GioiThieuLabel = new Label();
            UserInforPanel = new Panel();
            NamePanel = new Panel();
            NameBox = new TextBox();
            NameLabel = new Label();
            EmailPanel = new Panel();
            EmailBox = new TextBox();
            EmailLabel = new Label();
            SDTPanel = new Panel();
            SDTBox = new TextBox();
            SDTLabel = new Label();
            GiayToPanel = new Panel();
            ThemGiayToBtn = new Button();
            GiayToLabel = new Label();
            TitlePanel.SuspendLayout();
            ParentPanel.SuspendLayout();
            PhanHoiTitlePanel.SuspendLayout();
            PhanHoiPanel.SuspendLayout();
            ThongTinPanel.SuspendLayout();
            TTUngTuyenPanel.SuspendLayout();
            ThongTinUngTuyenPanel.SuspendLayout();
            KinhNghiemPanel.SuspendLayout();
            HocVanPanel.SuspendLayout();
            GioiThieuPanel.SuspendLayout();
            UserInforPanel.SuspendLayout();
            NamePanel.SuspendLayout();
            EmailPanel.SuspendLayout();
            SDTPanel.SuspendLayout();
            GiayToPanel.SuspendLayout();
            SuspendLayout();
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
            TitleLabel.Size = new Size(695, 41);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Hiệu Chỉnh Hồ Sơ Ứng Tuyển Cho TENBAIDANG";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ParentPanel
            // 
            ParentPanel.AutoScroll = true;
            ParentPanel.BackColor = SystemColors.ControlLight;
            ParentPanel.Controls.Add(TitlePanel);
            ParentPanel.Controls.Add(PhanHoiTitlePanel);
            ParentPanel.Controls.Add(PhanHoiPanel);
            ParentPanel.Controls.Add(ThongTinPanel);
            ParentPanel.Controls.Add(TTUngTuyenPanel);
            ParentPanel.Controls.Add(GiayToPanel);
            ParentPanel.Dock = DockStyle.Fill;
            ParentPanel.Location = new Point(0, 0);
            ParentPanel.Name = "ParentPanel";
            ParentPanel.Size = new Size(1139, 608);
            ParentPanel.TabIndex = 8;
            // 
            // PhanHoiTitlePanel
            // 
            PhanHoiTitlePanel.BackColor = SystemColors.ControlDark;
            PhanHoiTitlePanel.Controls.Add(label1);
            PhanHoiTitlePanel.Location = new Point(3, 84);
            PhanHoiTitlePanel.Name = "PhanHoiTitlePanel";
            PhanHoiTitlePanel.Size = new Size(1102, 65);
            PhanHoiTitlePanel.TabIndex = 15;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 0;
            label1.Text = "Phản hồi của nhân viên";
            // 
            // PhanHoiPanel
            // 
            PhanHoiPanel.Controls.Add(richTextBox1);
            PhanHoiPanel.Location = new Point(3, 155);
            PhanHoiPanel.Name = "PhanHoiPanel";
            PhanHoiPanel.Size = new Size(1102, 125);
            PhanHoiPanel.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(1102, 125);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // ThongTinPanel
            // 
            ThongTinPanel.BackColor = SystemColors.ControlDark;
            ThongTinPanel.Controls.Add(UngTuyenBtn);
            ThongTinPanel.Controls.Add(ThongTinLabel);
            ThongTinPanel.Location = new Point(3, 286);
            ThongTinPanel.Name = "ThongTinPanel";
            ThongTinPanel.Size = new Size(1102, 65);
            ThongTinPanel.TabIndex = 14;
            // 
            // UngTuyenBtn
            // 
            UngTuyenBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            UngTuyenBtn.Location = new Point(186, 7);
            UngTuyenBtn.Name = "UngTuyenBtn";
            UngTuyenBtn.Size = new Size(129, 46);
            UngTuyenBtn.TabIndex = 2;
            UngTuyenBtn.Text = "Hiệu chỉnh";
            UngTuyenBtn.UseVisualStyleBackColor = true;
            UngTuyenBtn.Click += UngTuyenBtn_Click;
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
            // TTUngTuyenPanel
            // 
            TTUngTuyenPanel.Controls.Add(ThongTinUngTuyenPanel);
            TTUngTuyenPanel.Location = new Point(3, 357);
            TTUngTuyenPanel.Name = "TTUngTuyenPanel";
            TTUngTuyenPanel.Size = new Size(1105, 450);
            TTUngTuyenPanel.TabIndex = 11;
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
            // HocVanBox
            // 
            HocVanBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HocVanBox.Location = new Point(147, 13);
            HocVanBox.Name = "HocVanBox";
            HocVanBox.Size = new Size(396, 200);
            HocVanBox.TabIndex = 1;
            HocVanBox.Text = "";
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
            // GioiThieuBox
            // 
            GioiThieuBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GioiThieuBox.Location = new Point(147, 16);
            GioiThieuBox.Name = "GioiThieuBox";
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
            // NamePanel
            // 
            NamePanel.Controls.Add(NameBox);
            NamePanel.Controls.Add(NameLabel);
            NamePanel.Location = new Point(0, 3);
            NamePanel.Name = "NamePanel";
            NamePanel.Size = new Size(545, 65);
            NamePanel.TabIndex = 0;
            // 
            // NameBox
            // 
            NameBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NameBox.Location = new Point(147, 13);
            NameBox.Name = "NameBox";
            NameBox.ReadOnly = true;
            NameBox.Size = new Size(396, 34);
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
            // EmailPanel
            // 
            EmailPanel.Controls.Add(EmailBox);
            EmailPanel.Controls.Add(EmailLabel);
            EmailPanel.Location = new Point(0, 74);
            EmailPanel.Name = "EmailPanel";
            EmailPanel.Size = new Size(548, 65);
            EmailPanel.TabIndex = 2;
            // 
            // EmailBox
            // 
            EmailBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmailBox.Location = new Point(147, 13);
            EmailBox.Name = "EmailBox";
            EmailBox.ReadOnly = true;
            EmailBox.Size = new Size(396, 34);
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
            // SDTPanel
            // 
            SDTPanel.Controls.Add(SDTBox);
            SDTPanel.Controls.Add(SDTLabel);
            SDTPanel.Location = new Point(0, 145);
            SDTPanel.Name = "SDTPanel";
            SDTPanel.Size = new Size(548, 65);
            SDTPanel.TabIndex = 3;
            // 
            // SDTBox
            // 
            SDTBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SDTBox.Location = new Point(147, 13);
            SDTBox.Name = "SDTBox";
            SDTBox.ReadOnly = true;
            SDTBox.Size = new Size(396, 34);
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
            // GiayToPanel
            // 
            GiayToPanel.BackColor = SystemColors.ControlDark;
            GiayToPanel.Controls.Add(ThemGiayToBtn);
            GiayToPanel.Controls.Add(GiayToLabel);
            GiayToPanel.Location = new Point(3, 813);
            GiayToPanel.Name = "GiayToPanel";
            GiayToPanel.Size = new Size(1102, 65);
            GiayToPanel.TabIndex = 9;
            // 
            // ThemGiayToBtn
            // 
            ThemGiayToBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ThemGiayToBtn.Location = new Point(186, 7);
            ThemGiayToBtn.Name = "ThemGiayToBtn";
            ThemGiayToBtn.Size = new Size(129, 46);
            ThemGiayToBtn.TabIndex = 1;
            ThemGiayToBtn.Text = "Thêm mới";
            ThemGiayToBtn.UseVisualStyleBackColor = true;
            ThemGiayToBtn.Click += ThemGiayToBtn_Click;
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
            // UV_KetQuaHS_ChiTietHS
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 608);
            Controls.Add(ParentPanel);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "UV_KetQuaHS_ChiTietHS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ứng Tuyển";
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ParentPanel.ResumeLayout(false);
            PhanHoiTitlePanel.ResumeLayout(false);
            PhanHoiTitlePanel.PerformLayout();
            PhanHoiPanel.ResumeLayout(false);
            ThongTinPanel.ResumeLayout(false);
            ThongTinPanel.PerformLayout();
            TTUngTuyenPanel.ResumeLayout(false);
            ThongTinUngTuyenPanel.ResumeLayout(false);
            KinhNghiemPanel.ResumeLayout(false);
            KinhNghiemPanel.PerformLayout();
            HocVanPanel.ResumeLayout(false);
            HocVanPanel.PerformLayout();
            GioiThieuPanel.ResumeLayout(false);
            GioiThieuPanel.PerformLayout();
            UserInforPanel.ResumeLayout(false);
            NamePanel.ResumeLayout(false);
            NamePanel.PerformLayout();
            EmailPanel.ResumeLayout(false);
            EmailPanel.PerformLayout();
            SDTPanel.ResumeLayout(false);
            SDTPanel.PerformLayout();
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
        private Button ThemGiayToBtn;
        private Button UngTuyenBtn;
        private Panel PhanHoiPanel;
        private RichTextBox richTextBox1;
        private Panel TTUngTuyenPanel;
        private Panel ThongTinUngTuyenPanel;
        private Panel KinhNghiemPanel;
        private RichTextBox KinhNghiemBox;
        private Label KinhNghiemLabel;
        private Panel HocVanPanel;
        private RichTextBox HocVanBox;
        private Label HocVanLabel;
        private Panel GioiThieuPanel;
        private RichTextBox GioiThieuBox;
        private Label GioiThieuLabel;
        private Panel UserInforPanel;
        private Panel NamePanel;
        private TextBox NameBox;
        private Label NameLabel;
        private Panel EmailPanel;
        private TextBox EmailBox;
        private Label EmailLabel;
        private Panel SDTPanel;
        private TextBox SDTBox;
        private Label SDTLabel;
        private Panel ThongTinPanel;
        private Label ThongTinLabel;
        private Panel PhanHoiTitlePanel;
        private Label label1;
    }
}