namespace GUI
{
    partial class UV_XemBaiDang
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
            label3 = new Label();
            BackBtn = new Button();
            UngTuyenBtn = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ViTri = new TextBox();
            TenDN = new TextBox();
            label6 = new Label();
            CapBac = new TextBox();
            label4 = new Label();
            DiaChi = new TextBox();
            label5 = new Label();
            SoLuong = new TextBox();
            label7 = new Label();
            NgayDang = new TextBox();
            label1 = new Label();
            NgayKetThuc = new TextBox();
            label8 = new Label();
            MoTa = new TextBox();
            label9 = new Label();
            LienHe = new TextBox();
            label10 = new Label();
            childFormPanel = new Panel();
            label11 = new Label();
            KyNang = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            childFormPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1075, 52);
            label3.TabIndex = 5;
            label3.Text = "Chi tiết bài đăng";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Plum;
            BackBtn.Location = new Point(41, 60);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(198, 40);
            BackBtn.TabIndex = 9;
            BackBtn.Text = "Quay lại";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // UngTuyenBtn
            // 
            UngTuyenBtn.Location = new Point(479, 657);
            UngTuyenBtn.Name = "UngTuyenBtn";
            UngTuyenBtn.Size = new Size(128, 40);
            UngTuyenBtn.TabIndex = 11;
            UngTuyenBtn.Text = "Ứng tuyển";
            UngTuyenBtn.Click += UngTuyenBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.tải_xuống;
            pictureBox1.Location = new Point(41, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 218);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(320, 120);
            label2.Name = "label2";
            label2.Size = new Size(190, 28);
            label2.TabIndex = 13;
            label2.Text = "Vị trí tuyển  dụng: ";
            // 
            // ViTri
            // 
            ViTri.BackColor = SystemColors.ButtonHighlight;
            ViTri.Enabled = false;
            ViTri.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            ViTri.ForeColor = Color.Black;
            ViTri.Location = new Point(530, 122);
            ViTri.Name = "ViTri";
            ViTri.ReadOnly = true;
            ViTri.Size = new Size(217, 34);
            ViTri.TabIndex = 14;
            // 
            // TenDN
            // 
            TenDN.BackColor = SystemColors.ButtonHighlight;
            TenDN.Enabled = false;
            TenDN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            TenDN.Location = new Point(520, 213);
            TenDN.Name = "TenDN";
            TenDN.ReadOnly = true;
            TenDN.Size = new Size(217, 27);
            TenDN.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(320, 211);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 17;
            label6.Text = "Tên doanh nghiệp: ";
            // 
            // CapBac
            // 
            CapBac.BackColor = SystemColors.ButtonHighlight;
            CapBac.Enabled = false;
            CapBac.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            CapBac.Location = new Point(412, 293);
            CapBac.Name = "CapBac";
            CapBac.ReadOnly = true;
            CapBac.Size = new Size(255, 27);
            CapBac.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 291);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 19;
            label4.Text = "Cấp bậc: ";
            // 
            // DiaChi
            // 
            DiaChi.BackColor = SystemColors.ButtonHighlight;
            DiaChi.Enabled = false;
            DiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            DiaChi.Location = new Point(135, 392);
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            DiaChi.Size = new Size(447, 27);
            DiaChi.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 390);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 21;
            label5.Text = "Địa chỉ: ";
            // 
            // SoLuong
            // 
            SoLuong.BackColor = SystemColors.ButtonHighlight;
            SoLuong.Enabled = false;
            SoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            SoLuong.Location = new Point(520, 250);
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            SoLuong.Size = new Size(97, 27);
            SoLuong.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(320, 248);
            label7.Name = "label7";
            label7.Size = new Size(154, 20);
            label7.TabIndex = 23;
            label7.Text = "Số lượng tuyển dụng: ";
            // 
            // NgayDang
            // 
            NgayDang.BackColor = SystemColors.ButtonHighlight;
            NgayDang.Enabled = false;
            NgayDang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            NgayDang.Location = new Point(452, 173);
            NgayDang.Name = "NgayDang";
            NgayDang.ReadOnly = true;
            NgayDang.Size = new Size(187, 27);
            NgayDang.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(320, 171);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 25;
            label1.Text = "Ngày đăng: ";
            // 
            // NgayKetThuc
            // 
            NgayKetThuc.BackColor = SystemColors.ButtonHighlight;
            NgayKetThuc.Enabled = false;
            NgayKetThuc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            NgayKetThuc.Location = new Point(837, 173);
            NgayKetThuc.Name = "NgayKetThuc";
            NgayKetThuc.ReadOnly = true;
            NgayKetThuc.Size = new Size(195, 27);
            NgayKetThuc.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(688, 171);
            label8.Name = "label8";
            label8.Size = new Size(107, 20);
            label8.TabIndex = 27;
            label8.Text = "Ngày kết thúc: ";
            // 
            // MoTa
            // 
            MoTa.BackColor = SystemColors.ButtonHighlight;
            MoTa.Enabled = false;
            MoTa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            MoTa.Location = new Point(135, 435);
            MoTa.Multiline = true;
            MoTa.Name = "MoTa";
            MoTa.ReadOnly = true;
            MoTa.ScrollBars = ScrollBars.Vertical;
            MoTa.Size = new Size(861, 100);
            MoTa.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 435);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 29;
            label9.Text = "Mô tả: ";
            // 
            // LienHe
            // 
            LienHe.BackColor = SystemColors.ButtonHighlight;
            LienHe.Enabled = false;
            LienHe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            LienHe.Location = new Point(135, 550);
            LienHe.Name = "LienHe";
            LienHe.ReadOnly = true;
            LienHe.Size = new Size(301, 27);
            LienHe.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(43, 548);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 31;
            label10.Text = "Liên hệ: ";
            // 
            // childFormPanel
            // 
            childFormPanel.BorderStyle = BorderStyle.FixedSingle;
            childFormPanel.Controls.Add(label11);
            childFormPanel.Controls.Add(KyNang);
            childFormPanel.Controls.Add(pictureBox1);
            childFormPanel.Controls.Add(label3);
            childFormPanel.Controls.Add(BackBtn);
            childFormPanel.Controls.Add(UngTuyenBtn);
            childFormPanel.Controls.Add(LienHe);
            childFormPanel.Controls.Add(ViTri);
            childFormPanel.Controls.Add(label10);
            childFormPanel.Controls.Add(label2);
            childFormPanel.Controls.Add(MoTa);
            childFormPanel.Controls.Add(label6);
            childFormPanel.Controls.Add(label9);
            childFormPanel.Controls.Add(TenDN);
            childFormPanel.Controls.Add(NgayKetThuc);
            childFormPanel.Controls.Add(label4);
            childFormPanel.Controls.Add(label8);
            childFormPanel.Controls.Add(CapBac);
            childFormPanel.Controls.Add(NgayDang);
            childFormPanel.Controls.Add(label5);
            childFormPanel.Controls.Add(label1);
            childFormPanel.Controls.Add(DiaChi);
            childFormPanel.Controls.Add(SoLuong);
            childFormPanel.Controls.Add(label7);
            childFormPanel.Location = new Point(0, 0);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(1077, 721);
            childFormPanel.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(320, 339);
            label11.Name = "label11";
            label11.Size = new Size(69, 20);
            label11.TabIndex = 33;
            label11.Text = "Kỹ năng: ";
            // 
            // KyNang
            // 
            KyNang.BackColor = SystemColors.ButtonHighlight;
            KyNang.Enabled = false;
            KyNang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            KyNang.Location = new Point(412, 339);
            KyNang.Name = "KyNang";
            KyNang.ReadOnly = true;
            KyNang.Size = new Size(383, 27);
            KyNang.TabIndex = 34;
            // 
            // UV_XemBaiDang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 721);
            Controls.Add(childFormPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UV_XemBaiDang";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            childFormPanel.ResumeLayout(false);
            childFormPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Button BackBtn;
        private Button UngTuyenBtn;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox ViTri;
        private TextBox TenDN;
        private Label label6;
        private TextBox CapBac;
        private Label label4;
        private TextBox DiaChi;
        private Label label5;
        private TextBox SoLuong;
        private Label label7;
        private TextBox NgayDang;
        private Label label1;
        private TextBox NgayKetThuc;
        private Label label8;
        private TextBox MoTa;
        private Label label9;
        private TextBox LienHe;
        private Label label10;
        private Panel childFormPanel;
        private Label label11;
        private TextBox KyNang;
    }
}