namespace GUI
{
    partial class DangNhap
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
            panel3 = new Panel();
            TitleLabel = new Label();
            panel2 = new Panel();
            DangKyDNBtn = new Button();
            DangKyUVBtn = new Button();
            AcceptBtn = new Button();
            DiaChiBox = new TextBox();
            label7 = new Label();
            HoTenBox = new TextBox();
            label2 = new Label();
            childFormPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // childFormPanel
            // 
            childFormPanel.Controls.Add(panel3);
            childFormPanel.Controls.Add(panel2);
            childFormPanel.Dock = DockStyle.Fill;
            childFormPanel.Location = new Point(0, 0);
            childFormPanel.Margin = new Padding(4);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(757, 777);
            childFormPanel.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(TitleLabel);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(6);
            panel3.Name = "panel3";
            panel3.Size = new Size(757, 126);
            panel3.TabIndex = 41;
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(138, 34);
            TitleLabel.Margin = new Padding(6, 0, 6, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(483, 46);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Hệ Thống Hồ Sơ Tuyển Dụng";
            // 
            // panel2
            // 
            panel2.Controls.Add(DangKyDNBtn);
            panel2.Controls.Add(DangKyUVBtn);
            panel2.Controls.Add(AcceptBtn);
            panel2.Controls.Add(DiaChiBox);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(HoTenBox);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 134);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(757, 643);
            panel2.TabIndex = 0;
            // 
            // DangKyDNBtn
            // 
            DangKyDNBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DangKyDNBtn.Location = new Point(515, 206);
            DangKyDNBtn.Name = "DangKyDNBtn";
            DangKyDNBtn.Size = new Size(230, 49);
            DangKyDNBtn.TabIndex = 55;
            DangKyDNBtn.Text = "Đăng Ký Doanh Nghiệp";
            DangKyDNBtn.UseVisualStyleBackColor = true;
            DangKyDNBtn.Click += DangKyDNBtn_Click;
            // 
            // DangKyUVBtn
            // 
            DangKyUVBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DangKyUVBtn.Location = new Point(515, 151);
            DangKyUVBtn.Name = "DangKyUVBtn";
            DangKyUVBtn.Size = new Size(230, 49);
            DangKyUVBtn.TabIndex = 54;
            DangKyUVBtn.Text = "Đăng Ký Ứng Viên";
            DangKyUVBtn.UseVisualStyleBackColor = true;
            DangKyUVBtn.Click += DangKyUVBtn_Click;
            // 
            // AcceptBtn
            // 
            AcceptBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AcceptBtn.Location = new Point(30, 151);
            AcceptBtn.Name = "AcceptBtn";
            AcceptBtn.Size = new Size(230, 49);
            AcceptBtn.TabIndex = 53;
            AcceptBtn.Text = "Đăng Nhập";
            AcceptBtn.UseVisualStyleBackColor = true;
            // 
            // DiaChiBox
            // 
            DiaChiBox.Font = new Font("Segoe UI", 12F);
            DiaChiBox.Location = new Point(174, 94);
            DiaChiBox.Name = "DiaChiBox";
            DiaChiBox.Size = new Size(571, 34);
            DiaChiBox.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(30, 97);
            label7.Name = "label7";
            label7.Size = new Size(104, 28);
            label7.TabIndex = 33;
            label7.Text = "Mật Khẩu";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // HoTenBox
            // 
            HoTenBox.Font = new Font("Segoe UI", 12F);
            HoTenBox.Location = new Point(174, 39);
            HoTenBox.Name = "HoTenBox";
            HoTenBox.Size = new Size(571, 34);
            HoTenBox.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(30, 42);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 28;
            label2.Text = "Email";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 777);
            Controls.Add(childFormPanel);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            childFormPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel childFormPanel;
        private Panel panel2;
        private TextBox DiaChiBox;
        private Label label7;
        private TextBox HoTenBox;
        private Label label2;
        private Panel panel3;
        private Label TitleLabel;
        private Button AcceptBtn;
        private Button DangKyDNBtn;
        private Button DangKyUVBtn;
    }
}