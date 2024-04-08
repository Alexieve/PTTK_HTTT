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
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            GiayToPanel = new Panel();
            UngTuyenBtn = new Button();
            ThemGiayToBtn = new Button();
            label1 = new Label();
            TitlePanel.SuspendLayout();
            ParentPanel.SuspendLayout();
            panel1.SuspendLayout();
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
            ParentPanel.Controls.Add(panel1);
            ParentPanel.Controls.Add(GiayToPanel);
            ParentPanel.Dock = DockStyle.Fill;
            ParentPanel.Location = new Point(0, 0);
            ParentPanel.Name = "ParentPanel";
            ParentPanel.Size = new Size(1139, 608);
            ParentPanel.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(richTextBox1);
            panel1.Location = new Point(3, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(1102, 125);
            panel1.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(1102, 120);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // GiayToPanel
            // 
            GiayToPanel.BackColor = SystemColors.ControlDark;
            GiayToPanel.Controls.Add(UngTuyenBtn);
            GiayToPanel.Controls.Add(ThemGiayToBtn);
            GiayToPanel.Controls.Add(label1);
            GiayToPanel.Location = new Point(3, 215);
            GiayToPanel.Name = "GiayToPanel";
            GiayToPanel.Size = new Size(1102, 65);
            GiayToPanel.TabIndex = 9;
            // 
            // UngTuyenBtn
            // 
            UngTuyenBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            UngTuyenBtn.Location = new Point(321, 7);
            UngTuyenBtn.Name = "UngTuyenBtn";
            UngTuyenBtn.Size = new Size(129, 46);
            UngTuyenBtn.TabIndex = 2;
            UngTuyenBtn.Text = "Hiệu chỉnh";
            UngTuyenBtn.UseVisualStyleBackColor = true;
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(170, 28);
            label1.TabIndex = 0;
            label1.Text = "Giấy tờ ứng viên";
            // 
            // KetQuaHS_ChiTietHS
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 608);
            Controls.Add(ParentPanel);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "KetQuaHS_ChiTietHS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ứng Tuyển";
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ParentPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            GiayToPanel.ResumeLayout(false);
            GiayToPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel TitlePanel;
        private Label TitleLabel;
        private FlowLayoutPanel ParentPanel;
        private Panel GiayToPanel;
        private Label label1;
        private Button ThemGiayToBtn;
        private Button UngTuyenBtn;
        private Panel panel1;
        private RichTextBox richTextBox1;
    }
}