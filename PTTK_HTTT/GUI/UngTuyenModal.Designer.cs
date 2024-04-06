namespace GUI
{
    partial class UngTuyenModal
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
            GiayToPanel = new Panel();
            ThemGiayToBtn = new Button();
            label1 = new Label();
            UngTuyenBtn = new Button();
            TitlePanel.SuspendLayout();
            ParentPanel.SuspendLayout();
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
            TitleLabel.Size = new Size(766, 41);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Bạn đang ứng tuyển vị trí CAPBAC - VITRI tại TENDN";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ParentPanel
            // 
            ParentPanel.AutoScroll = true;
            ParentPanel.BackColor = SystemColors.ControlLight;
            ParentPanel.Controls.Add(TitlePanel);
            ParentPanel.Controls.Add(GiayToPanel);
            ParentPanel.Dock = DockStyle.Fill;
            ParentPanel.Location = new Point(0, 0);
            ParentPanel.Name = "ParentPanel";
            ParentPanel.Size = new Size(1139, 608);
            ParentPanel.TabIndex = 8;
            // 
            // GiayToPanel
            // 
            GiayToPanel.BackColor = SystemColors.ControlDark;
            GiayToPanel.Controls.Add(UngTuyenBtn);
            GiayToPanel.Controls.Add(ThemGiayToBtn);
            GiayToPanel.Controls.Add(label1);
            GiayToPanel.Location = new Point(3, 84);
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
            // UngTuyenBtn
            // 
            UngTuyenBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            UngTuyenBtn.Location = new Point(321, 7);
            UngTuyenBtn.Name = "UngTuyenBtn";
            UngTuyenBtn.Size = new Size(129, 46);
            UngTuyenBtn.TabIndex = 2;
            UngTuyenBtn.Text = "Ứng tuyển";
            UngTuyenBtn.UseVisualStyleBackColor = true;
            // 
            // UngTuyenModal
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 608);
            Controls.Add(ParentPanel);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "UngTuyenModal";
            Text = "Ứng Tuyển";
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ParentPanel.ResumeLayout(false);
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
    }
}