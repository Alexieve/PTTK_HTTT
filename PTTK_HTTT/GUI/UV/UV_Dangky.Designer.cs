namespace GUI
{
    partial class UV_DangKy
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
            panel1 = new Panel();
            panel3 = new Panel();
            TitleLabel = new Label();
            panel2 = new Panel();
            MatKhauLabel = new Label();
            MatKhauBox = new TextBox();
            NgaySinhBox = new DateTimePicker();
            DangKyBtn = new Button();
            PhaiBox = new ComboBox();
            label5 = new Label();
            EmailBox = new TextBox();
            SDTBox = new TextBox();
            label6 = new Label();
            DiaChiBox = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            HoTenBox = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 777);
            panel1.TabIndex = 0;
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
            TitleLabel.Location = new Point(129, 34);
            TitleLabel.Margin = new Padding(6, 0, 6, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(501, 46);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Đăng Ký Thành Viên Ứng Viên";
            // 
            // panel2
            // 
            panel2.Controls.Add(MatKhauLabel);
            panel2.Controls.Add(MatKhauBox);
            panel2.Controls.Add(NgaySinhBox);
            panel2.Controls.Add(DangKyBtn);
            panel2.Controls.Add(PhaiBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(EmailBox);
            panel2.Controls.Add(SDTBox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(DiaChiBox);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(HoTenBox);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 134);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(757, 643);
            panel2.TabIndex = 0;
            // 
            // MatKhauLabel
            // 
            MatKhauLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MatKhauLabel.AutoSize = true;
            MatKhauLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            MatKhauLabel.Location = new Point(30, 520);
            MatKhauLabel.Name = "MatKhauLabel";
            MatKhauLabel.Size = new Size(102, 28);
            MatKhauLabel.TabIndex = 56;
            MatKhauLabel.Text = "Mật khẩu";
            MatKhauLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // MatKhauBox
            // 
            MatKhauBox.Font = new Font("Segoe UI", 12F);
            MatKhauBox.Location = new Point(174, 520);
            MatKhauBox.MaxLength = 50;
            MatKhauBox.Name = "MatKhauBox";
            MatKhauBox.PasswordChar = '*';
            MatKhauBox.Size = new Size(571, 34);
            MatKhauBox.TabIndex = 55;
            MatKhauBox.KeyPress += PreventSpaceAndTab_KeyPress;
            // 
            // NgaySinhBox
            // 
            NgaySinhBox.CustomFormat = "dd/MM/yyyy";
            NgaySinhBox.Format = DateTimePickerFormat.Custom;
            NgaySinhBox.Location = new Point(482, 120);
            NgaySinhBox.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            NgaySinhBox.Name = "NgaySinhBox";
            NgaySinhBox.Size = new Size(263, 34);
            NgaySinhBox.TabIndex = 54;
            // 
            // DangKyBtn
            // 
            DangKyBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DangKyBtn.Location = new Point(265, 582);
            DangKyBtn.Name = "DangKyBtn";
            DangKyBtn.Size = new Size(230, 49);
            DangKyBtn.TabIndex = 53;
            DangKyBtn.Text = "Đăng Ký";
            DangKyBtn.UseVisualStyleBackColor = true;
            DangKyBtn.Click += DangKyBtn_Click;
            // 
            // PhaiBox
            // 
            PhaiBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PhaiBox.FormattingEnabled = true;
            PhaiBox.Items.AddRange(new object[] { "Nam", "Nữ" });
            PhaiBox.Location = new Point(174, 120);
            PhaiBox.Name = "PhaiBox";
            PhaiBox.Size = new Size(135, 36);
            PhaiBox.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(30, 420);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 38;
            label5.Text = "Email";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // EmailBox
            // 
            EmailBox.Font = new Font("Segoe UI", 12F);
            EmailBox.Location = new Point(174, 420);
            EmailBox.MaxLength = 50;
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(571, 34);
            EmailBox.TabIndex = 37;
            EmailBox.KeyPress += PreventSpaceAndTab_KeyPress;
            // 
            // SDTBox
            // 
            SDTBox.Font = new Font("Segoe UI", 12F);
            SDTBox.Location = new Point(174, 320);
            SDTBox.MaxLength = 10;
            SDTBox.Name = "SDTBox";
            SDTBox.Size = new Size(571, 34);
            SDTBox.TabIndex = 36;
            SDTBox.KeyPress += SDTBox_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(30, 320);
            label6.Name = "label6";
            label6.Size = new Size(138, 28);
            label6.TabIndex = 35;
            label6.Text = "Số điện thoại";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // DiaChiBox
            // 
            DiaChiBox.Font = new Font("Segoe UI", 12F);
            DiaChiBox.Location = new Point(174, 220);
            DiaChiBox.MaxLength = 200;
            DiaChiBox.Name = "DiaChiBox";
            DiaChiBox.Size = new Size(571, 34);
            DiaChiBox.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(30, 220);
            label7.Name = "label7";
            label7.Size = new Size(78, 28);
            label7.TabIndex = 33;
            label7.Text = "Địa chỉ";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(350, 120);
            label4.Name = "label4";
            label4.Size = new Size(107, 28);
            label4.TabIndex = 32;
            label4.Text = "Ngày sinh";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(30, 120);
            label3.Name = "label3";
            label3.Size = new Size(53, 28);
            label3.TabIndex = 30;
            label3.Text = "Phái";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // HoTenBox
            // 
            HoTenBox.Font = new Font("Segoe UI", 12F);
            HoTenBox.Location = new Point(174, 20);
            HoTenBox.MaxLength = 50;
            HoTenBox.Name = "HoTenBox";
            HoTenBox.Size = new Size(571, 34);
            HoTenBox.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(30, 20);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 28;
            label2.Text = "Họ và tên";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // UV_DangKy
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 777);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F);
            Name = "UV_DangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Ký Ứng Viên";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ComboBox PhaiBox;
        private Label label5;
        private TextBox EmailBox;
        private TextBox SDTBox;
        private Label label6;
        private TextBox DiaChiBox;
        private Label label7;
        private Label label4;
        private Label label3;
        private TextBox HoTenBox;
        private Label label2;
        private Panel panel3;
        private Label TitleLabel;
        private DateTimePicker NgaySinhBox;
        private Button DangKyBtn;
        private Label MatKhauLabel;
        private TextBox MatKhauBox;
    }
}