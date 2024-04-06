namespace GUI
{
    partial class Home_UV
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
            ContentPanel = new Panel();
            cardTuyenDung1 = new CardTuyenDung();
            SearchPanel = new Panel();
            SearchBtn = new Button();
            textBox1 = new TextBox();
            sidePanel = new FlowLayoutPanel();
            panel1 = new Panel();
            usernameLabel = new Label();
            logoutBtn = new Button();
            panel2 = new Panel();
            XemKQBtn = new Button();
            panel3 = new Panel();
            XacThucHSBtn = new Button();
            panel4 = new Panel();
            ThanhToanBtn = new Button();
            panel5 = new Panel();
            DuyetHSBtn = new Button();
            panel6 = new Panel();
            GiaHanHDBtn = new Button();
            childFormPanel.SuspendLayout();
            ContentPanel.SuspendLayout();
            SearchPanel.SuspendLayout();
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
            childFormPanel.Controls.Add(ContentPanel);
            childFormPanel.Controls.Add(SearchPanel);
            childFormPanel.Font = new Font("Segoe UI", 12F);
            childFormPanel.Location = new Point(272, 0);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(1077, 721);
            childFormPanel.TabIndex = 6;
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(cardTuyenDung1);
            ContentPanel.Location = new Point(6, 73);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(1058, 636);
            ContentPanel.TabIndex = 3;
            // 
            // cardTuyenDung1
            // 
            cardTuyenDung1.Avatar = null;
            cardTuyenDung1.BackColor = Color.White;
            cardTuyenDung1.CapBacUngtuyen = null;
            cardTuyenDung1.DiaChiDN = null;
            cardTuyenDung1.KyNangUngTuyen = null;
            cardTuyenDung1.Location = new Point(3, 3);
            cardTuyenDung1.Name = "cardTuyenDung1";
            cardTuyenDung1.Size = new Size(1322, 285);
            cardTuyenDung1.TabIndex = 0;
            cardTuyenDung1.TenDoanhNghiep = null;
            cardTuyenDung1.ViTri = null;
            // 
            // SearchPanel
            // 
            SearchPanel.Controls.Add(SearchBtn);
            SearchPanel.Controls.Add(textBox1);
            SearchPanel.Location = new Point(3, 12);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(1061, 55);
            SearchPanel.TabIndex = 2;
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SearchBtn.Location = new Point(927, 4);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(134, 43);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "Tìm Kiếm";
            SearchBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(3, 8);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tìm kiếm theo các Vị trí, Kỹ năng, Công ty,...";
            textBox1.Size = new Size(921, 34);
            textBox1.TabIndex = 0;
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
            sidePanel.TabIndex = 5;
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
            panel2.Controls.Add(XemKQBtn);
            panel2.Location = new Point(3, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 112);
            panel2.TabIndex = 1;
            // 
            // XemKQBtn
            // 
            XemKQBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            XemKQBtn.FlatAppearance.BorderSize = 0;
            XemKQBtn.FlatStyle = FlatStyle.Flat;
            XemKQBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            XemKQBtn.ForeColor = Color.White;
            XemKQBtn.Location = new Point(0, 3);
            XemKQBtn.Name = "XemKQBtn";
            XemKQBtn.Size = new Size(263, 106);
            XemKQBtn.TabIndex = 0;
            XemKQBtn.Text = "Xem Kết Quả Ứng Tuyển";
            XemKQBtn.UseVisualStyleBackColor = true;
            XemKQBtn.Click += XemKQBtn_Click;
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
            XacThucHSBtn.Text = "Temporary";
            XacThucHSBtn.UseVisualStyleBackColor = true;
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
            ThanhToanBtn.Text = "Temporary";
            ThanhToanBtn.UseVisualStyleBackColor = true;
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
            DuyetHSBtn.Text = "Temporary";
            DuyetHSBtn.UseVisualStyleBackColor = true;
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
            GiaHanHDBtn.Text = "Temporary";
            GiaHanHDBtn.UseVisualStyleBackColor = true;
            // 
            // Home_UV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(childFormPanel);
            Controls.Add(sidePanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Home_UV";
            Text = "Home_UV";
            childFormPanel.ResumeLayout(false);
            ContentPanel.ResumeLayout(false);
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
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
        private Button XemKQBtn;
        private Panel panel3;
        private Button XacThucHSBtn;
        private Panel panel4;
        private Button ThanhToanBtn;
        private Panel panel5;
        private Button DuyetHSBtn;
        private Panel panel6;
        private Button GiaHanHDBtn;
        private Button SearchBtn;
        private TextBox textBox1;
        private Panel SearchPanel;
        private Panel ContentPanel;
        private CardTuyenDung cardTuyenDung1;
    }
}