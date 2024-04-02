namespace GUI
{
    partial class Home_NV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            childFormPanel = new Panel();
            sidePanel = new FlowLayoutPanel();
            panel1 = new Panel();
            usernameLabel = new Label();
            logoutBtn = new Button();
            panel2 = new Panel();
            XacThucDNBtn = new Button();
            panel3 = new Panel();
            XacThucHSBtn = new Button();
            panel4 = new Panel();
            ThanhToanBtn = new Button();
            panel5 = new Panel();
            DuyetHSBtn = new Button();
            panel6 = new Panel();
            GiaHanHDBtn = new Button();
            sidePanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // childFormPanel
            // 
            childFormPanel.Location = new Point(272, 0);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(1077, 721);
            childFormPanel.TabIndex = 4;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(64, 64, 64);
            sidePanel.Controls.Add(panel1);
            sidePanel.Controls.Add(panel2);
            sidePanel.Controls.Add(panel3);
            sidePanel.Controls.Add(panel4);
            sidePanel.Controls.Add(panel5);
            sidePanel.Controls.Add(panel6);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(269, 721);
            sidePanel.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(logoutBtn);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 116);
            panel1.TabIndex = 0;
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            usernameLabel.BackColor = Color.Gray;
            usernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = SystemColors.ControlLightLight;
            usernameLabel.ImageAlign = ContentAlignment.MiddleLeft;
            usernameLabel.Location = new Point(0, 33);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(263, 20);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "USERNAME";
            usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoutBtn
            // 
            logoutBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            logoutBtn.BackColor = SystemColors.ButtonHighlight;
            logoutBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            logoutBtn.Location = new Point(83, 69);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(94, 29);
            logoutBtn.TabIndex = 0;
            logoutBtn.Text = "Đăng xuất";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(XacThucDNBtn);
            panel2.Location = new Point(3, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 112);
            panel2.TabIndex = 1;
            // 
            // XacThucDNBtn
            // 
            XacThucDNBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            XacThucDNBtn.FlatAppearance.BorderSize = 0;
            XacThucDNBtn.FlatStyle = FlatStyle.Flat;
            XacThucDNBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            XacThucDNBtn.ForeColor = Color.White;
            XacThucDNBtn.Location = new Point(0, 3);
            XacThucDNBtn.Name = "XacThucDNBtn";
            XacThucDNBtn.Size = new Size(263, 106);
            XacThucDNBtn.TabIndex = 0;
            XacThucDNBtn.Text = "Xác Thực Doanh Nghiệp";
            XacThucDNBtn.UseVisualStyleBackColor = true;
            XacThucDNBtn.Click += XacThucDNBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(XacThucHSBtn);
            panel3.Location = new Point(3, 243);
            panel3.Name = "panel3";
            panel3.Size = new Size(263, 112);
            panel3.TabIndex = 2;
            // 
            // XacThucHSBtn
            // 
            XacThucHSBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            XacThucHSBtn.FlatAppearance.BorderSize = 0;
            XacThucHSBtn.FlatStyle = FlatStyle.Flat;
            XacThucHSBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            XacThucHSBtn.ForeColor = Color.White;
            XacThucHSBtn.Location = new Point(0, 3);
            XacThucHSBtn.Name = "XacThucHSBtn";
            XacThucHSBtn.Size = new Size(263, 106);
            XacThucHSBtn.TabIndex = 0;
            XacThucHSBtn.Text = "Xác Thực Hồ Sơ";
            XacThucHSBtn.UseVisualStyleBackColor = true;
            XacThucHSBtn.Click += XacThucHSBtn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(ThanhToanBtn);
            panel4.Location = new Point(3, 361);
            panel4.Name = "panel4";
            panel4.Size = new Size(263, 112);
            panel4.TabIndex = 3;
            // 
            // ThanhToanBtn
            // 
            ThanhToanBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ThanhToanBtn.FlatAppearance.BorderSize = 0;
            ThanhToanBtn.FlatStyle = FlatStyle.Flat;
            ThanhToanBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ThanhToanBtn.ForeColor = Color.White;
            ThanhToanBtn.Location = new Point(0, 3);
            ThanhToanBtn.Name = "ThanhToanBtn";
            ThanhToanBtn.Size = new Size(263, 106);
            ThanhToanBtn.TabIndex = 0;
            ThanhToanBtn.Text = "Thanh Toán Hợp Đồng";
            ThanhToanBtn.UseVisualStyleBackColor = true;
            ThanhToanBtn.Click += ThanhToanBtn_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(DuyetHSBtn);
            panel5.Location = new Point(3, 479);
            panel5.Name = "panel5";
            panel5.Size = new Size(263, 112);
            panel5.TabIndex = 3;
            // 
            // DuyetHSBtn
            // 
            DuyetHSBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DuyetHSBtn.FlatAppearance.BorderSize = 0;
            DuyetHSBtn.FlatStyle = FlatStyle.Flat;
            DuyetHSBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DuyetHSBtn.ForeColor = Color.White;
            DuyetHSBtn.Location = new Point(0, 3);
            DuyetHSBtn.Name = "DuyetHSBtn";
            DuyetHSBtn.Size = new Size(263, 106);
            DuyetHSBtn.TabIndex = 0;
            DuyetHSBtn.Text = "Duyệt Hồ Sơ";
            DuyetHSBtn.UseVisualStyleBackColor = true;
            DuyetHSBtn.Click += DuyetHSBtn_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(GiaHanHDBtn);
            panel6.Location = new Point(3, 597);
            panel6.Name = "panel6";
            panel6.Size = new Size(263, 112);
            panel6.TabIndex = 3;
            // 
            // GiaHanHDBtn
            // 
            GiaHanHDBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GiaHanHDBtn.FlatAppearance.BorderSize = 0;
            GiaHanHDBtn.FlatStyle = FlatStyle.Flat;
            GiaHanHDBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            GiaHanHDBtn.ForeColor = Color.White;
            GiaHanHDBtn.Location = new Point(0, 3);
            GiaHanHDBtn.Name = "GiaHanHDBtn";
            GiaHanHDBtn.Size = new Size(263, 106);
            GiaHanHDBtn.TabIndex = 0;
            GiaHanHDBtn.Text = "Xử Lý Gia Hạn Hợp Đồng";
            GiaHanHDBtn.UseVisualStyleBackColor = true;
            GiaHanHDBtn.Click += GiaHanHDBtn_Click;
            // 
            // Home_NV
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(childFormPanel);
            Controls.Add(sidePanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "Home_NV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang Chủ";
            sidePanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel childFormPanel;
        private FlowLayoutPanel sidePanel;
        private Panel panel1;
        private Label usernameLabel;
        private Button logoutBtn;
        private Panel panel2;
        private Button XacThucDNBtn;
        private Panel panel3;
        private Button XacThucHSBtn;
        private Panel panel4;
        private Button ThanhToanBtn;
        private Panel panel5;
        private Button DuyetHSBtn;
        private Panel panel6;
        private Button GiaHanHDBtn;
    }
}
