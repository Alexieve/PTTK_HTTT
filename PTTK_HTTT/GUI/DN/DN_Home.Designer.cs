namespace GUI
{
    partial class DN_Home
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
            childFormPanel = new Panel();
            sidePanel = new FlowLayoutPanel();
            panel1 = new Panel();
            usernameLabel = new Label();
            logoutBtn = new Button();
            LapYCBtn = new Button();
            TraCuuHDBtn = new Button();
            PhanHoiHSBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            sidePanel.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // childFormPanel
            // 
            childFormPanel.Font = new Font("Segoe UI", 12F);
            childFormPanel.Location = new Point(272, 0);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(1077, 721);
            childFormPanel.TabIndex = 8;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(64, 64, 64);
            sidePanel.Controls.Add(tableLayoutPanel1);
            sidePanel.Dock = DockStyle.Fill;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(1348, 721);
            sidePanel.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(logoutBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 108);
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
            usernameLabel.Size = new Size(260, 20);
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
            logoutBtn.Size = new Size(91, 29);
            logoutBtn.TabIndex = 0;
            logoutBtn.Text = "Đăng xuất";
            logoutBtn.UseVisualStyleBackColor = false;
            // 
            // LapYCBtn
            // 
            LapYCBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LapYCBtn.FlatAppearance.BorderSize = 0;
            LapYCBtn.FlatStyle = FlatStyle.Flat;
            LapYCBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LapYCBtn.ForeColor = Color.White;
            LapYCBtn.Location = new Point(3, 117);
            LapYCBtn.Name = "LapYCBtn";
            LapYCBtn.Size = new Size(260, 195);
            LapYCBtn.TabIndex = 0;
            LapYCBtn.Text = "Lập yêu cầu tuyển dụng";
            LapYCBtn.UseVisualStyleBackColor = true;
            LapYCBtn.Click += LapYCBtn_Click;
            // 
            // TraCuuHDBtn
            // 
            TraCuuHDBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TraCuuHDBtn.FlatAppearance.BorderSize = 0;
            TraCuuHDBtn.FlatStyle = FlatStyle.Flat;
            TraCuuHDBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TraCuuHDBtn.ForeColor = Color.White;
            TraCuuHDBtn.Location = new Point(3, 318);
            TraCuuHDBtn.Name = "TraCuuHDBtn";
            TraCuuHDBtn.Size = new Size(260, 195);
            TraCuuHDBtn.TabIndex = 0;
            TraCuuHDBtn.Text = "Tra Cứu Hợp Đồng";
            TraCuuHDBtn.UseVisualStyleBackColor = true;
            TraCuuHDBtn.Click += TraCuuHDBtn_Click;
            // 
            // PhanHoiHSBtn
            // 
            PhanHoiHSBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PhanHoiHSBtn.FlatAppearance.BorderSize = 0;
            PhanHoiHSBtn.FlatStyle = FlatStyle.Flat;
            PhanHoiHSBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PhanHoiHSBtn.ForeColor = Color.White;
            PhanHoiHSBtn.Location = new Point(3, 519);
            PhanHoiHSBtn.Name = "PhanHoiHSBtn";
            PhanHoiHSBtn.Size = new Size(260, 196);
            PhanHoiHSBtn.TabIndex = 0;
            PhanHoiHSBtn.Text = "Phản Hồi Hồ Sơ";
            PhanHoiHSBtn.UseVisualStyleBackColor = true;
            PhanHoiHSBtn.Click += PhanHoiHSBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(PhanHoiHSBtn, 0, 3);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(TraCuuHDBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(LapYCBtn, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tableLayoutPanel1.Size = new Size(266, 718);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // DN_Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(childFormPanel);
            Controls.Add(sidePanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DN_Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home_DN";
            sidePanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel childFormPanel;
        private FlowLayoutPanel sidePanel;
        private Panel panel1;
        private Label usernameLabel;
        private Button logoutBtn;
        private Button LapYCBtn;
        private Button TraCuuHDBtn;
        private Button PhanHoiHSBtn;
        private TableLayoutPanel tableLayoutPanel1;
    }
}