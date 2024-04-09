namespace GUI
{
    partial class NV_Home
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            usernameLabel = new Label();
            logoutBtn = new Button();
            XacThucDNBtn = new Button();
            XacThucHSBtn = new Button();
            GiaHanHDBtn = new Button();
            DuyetHSBtn = new Button();
            ThanhToanBtn = new Button();
            TraCuuHDBtn = new Button();
            sidePanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
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
            sidePanel.Controls.Add(tableLayoutPanel1);
            sidePanel.Dock = DockStyle.Fill;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(1348, 721);
            sidePanel.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(XacThucDNBtn, 0, 1);
            tableLayoutPanel1.Controls.Add(XacThucHSBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(GiaHanHDBtn, 0, 6);
            tableLayoutPanel1.Controls.Add(DuyetHSBtn, 0, 5);
            tableLayoutPanel1.Controls.Add(ThanhToanBtn, 0, 4);
            tableLayoutPanel1.Controls.Add(TraCuuHDBtn, 0, 3);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.29F));
            tableLayoutPanel1.Size = new Size(266, 718);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(logoutBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 96);
            panel1.TabIndex = 0;
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            usernameLabel.BackColor = Color.Gray;
            usernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = SystemColors.ControlLightLight;
            usernameLabel.ImageAlign = ContentAlignment.MiddleLeft;
            usernameLabel.Location = new Point(0, 13);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(257, 20);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "USERNAME";
            usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoutBtn
            // 
            logoutBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            logoutBtn.BackColor = SystemColors.ButtonHighlight;
            logoutBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            logoutBtn.Location = new Point(82, 46);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(88, 29);
            logoutBtn.TabIndex = 0;
            logoutBtn.Text = "Đăng xuất";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // XacThucDNBtn
            // 
            XacThucDNBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            XacThucDNBtn.FlatAppearance.BorderSize = 0;
            XacThucDNBtn.FlatStyle = FlatStyle.Flat;
            XacThucDNBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            XacThucDNBtn.ForeColor = Color.White;
            XacThucDNBtn.Location = new Point(3, 105);
            XacThucDNBtn.Name = "XacThucDNBtn";
            XacThucDNBtn.Size = new Size(260, 96);
            XacThucDNBtn.TabIndex = 0;
            XacThucDNBtn.Text = "Xác Thực Doanh Nghiệp";
            XacThucDNBtn.UseVisualStyleBackColor = true;
            XacThucDNBtn.Click += XacThucDNBtn_Click;
            // 
            // XacThucHSBtn
            // 
            XacThucHSBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            XacThucHSBtn.FlatAppearance.BorderSize = 0;
            XacThucHSBtn.FlatStyle = FlatStyle.Flat;
            XacThucHSBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            XacThucHSBtn.ForeColor = Color.White;
            XacThucHSBtn.Location = new Point(3, 207);
            XacThucHSBtn.Name = "XacThucHSBtn";
            XacThucHSBtn.Size = new Size(260, 96);
            XacThucHSBtn.TabIndex = 0;
            XacThucHSBtn.Text = "Xác Thực Hồ Sơ";
            XacThucHSBtn.UseVisualStyleBackColor = true;
            XacThucHSBtn.Click += XacThucHSBtn_Click;
            // 
            // GiaHanHDBtn
            // 
            GiaHanHDBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GiaHanHDBtn.FlatAppearance.BorderSize = 0;
            GiaHanHDBtn.FlatStyle = FlatStyle.Flat;
            GiaHanHDBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            GiaHanHDBtn.ForeColor = Color.White;
            GiaHanHDBtn.Location = new Point(3, 615);
            GiaHanHDBtn.Name = "GiaHanHDBtn";
            GiaHanHDBtn.Size = new Size(260, 100);
            GiaHanHDBtn.TabIndex = 0;
            GiaHanHDBtn.Text = "Xử Lý Gia Hạn Hợp Đồng";
            GiaHanHDBtn.UseVisualStyleBackColor = true;
            GiaHanHDBtn.Click += GiaHanHDBtn_Click;
            // 
            // DuyetHSBtn
            // 
            DuyetHSBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DuyetHSBtn.FlatAppearance.BorderSize = 0;
            DuyetHSBtn.FlatStyle = FlatStyle.Flat;
            DuyetHSBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DuyetHSBtn.ForeColor = Color.White;
            DuyetHSBtn.Location = new Point(3, 513);
            DuyetHSBtn.Name = "DuyetHSBtn";
            DuyetHSBtn.Size = new Size(260, 96);
            DuyetHSBtn.TabIndex = 0;
            DuyetHSBtn.Text = "Duyệt Hồ Sơ";
            DuyetHSBtn.UseVisualStyleBackColor = true;
            DuyetHSBtn.Click += DuyetHSBtn_Click;
            // 
            // ThanhToanBtn
            // 
            ThanhToanBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ThanhToanBtn.FlatAppearance.BorderSize = 0;
            ThanhToanBtn.FlatStyle = FlatStyle.Flat;
            ThanhToanBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ThanhToanBtn.ForeColor = Color.White;
            ThanhToanBtn.Location = new Point(3, 411);
            ThanhToanBtn.Name = "ThanhToanBtn";
            ThanhToanBtn.Size = new Size(260, 96);
            ThanhToanBtn.TabIndex = 0;
            ThanhToanBtn.Text = "Thanh Toán Hợp Đồng";
            ThanhToanBtn.UseVisualStyleBackColor = true;
            ThanhToanBtn.Click += ThanhToanBtn_Click;
            // 
            // TraCuuHDBtn
            // 
            TraCuuHDBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TraCuuHDBtn.FlatAppearance.BorderSize = 0;
            TraCuuHDBtn.FlatStyle = FlatStyle.Flat;
            TraCuuHDBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TraCuuHDBtn.ForeColor = Color.White;
            TraCuuHDBtn.Location = new Point(3, 309);
            TraCuuHDBtn.Name = "TraCuuHDBtn";
            TraCuuHDBtn.Size = new Size(260, 96);
            TraCuuHDBtn.TabIndex = 1;
            TraCuuHDBtn.Text = "Tra Cứu Hợp Đồng";
            TraCuuHDBtn.UseVisualStyleBackColor = true;
            TraCuuHDBtn.Click += TraCuuHDBtn_Click;
            // 
            // NV_Home
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(childFormPanel);
            Controls.Add(sidePanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "NV_Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang Chủ";
            sidePanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel childFormPanel;
        private FlowLayoutPanel sidePanel;
        private Panel panel1;
        private Label usernameLabel;
        private Button logoutBtn;
        private Button XacThucDNBtn;
        private Button XacThucHSBtn;
        private Button ThanhToanBtn;
        private Button DuyetHSBtn;
        private Button GiaHanHDBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private Button TraCuuHDBtn;
    }
}
