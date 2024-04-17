namespace GUI
{
    partial class CPN_CardTuyenDung
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Ava = new PictureBox();
            Title = new Label();
            TenDN = new Label();
            CapBac = new Label();
            DiaChi = new Label();
            KyNang = new Label();
            ((System.ComponentModel.ISupportInitialize)Ava).BeginInit();
            SuspendLayout();
            // 
            // Ava
            // 
            Ava.Location = new Point(30, 18);
            Ava.Name = "Ava";
            Ava.Size = new Size(164, 153);
            Ava.SizeMode = PictureBoxSizeMode.Zoom;
            Ava.TabIndex = 0;
            Ava.TabStop = false;
            Ava.Click += Ava_Click;
            // 
            // Title
            // 
            Title.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Title.Location = new Point(248, 18);
            Title.Name = "Title";
            Title.Size = new Size(606, 40);
            Title.TabIndex = 1;
            Title.Text = "Vị trí tuyển dụng";
            // 
            // TenDN
            // 
            TenDN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            TenDN.Location = new Point(248, 58);
            TenDN.Name = "TenDN";
            TenDN.Size = new Size(613, 40);
            TenDN.TabIndex = 2;
            TenDN.Text = "Tên doanh nghiệp";
            TenDN.Click += TenDN_Click;
            // 
            // CapBac
            // 
            CapBac.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            CapBac.Location = new Point(248, 98);
            CapBac.Name = "CapBac";
            CapBac.Size = new Size(539, 34);
            CapBac.TabIndex = 3;
            CapBac.Text = "Cấp bậc";
            // 
            // DiaChi
            // 
            DiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            DiaChi.Location = new Point(248, 143);
            DiaChi.Name = "DiaChi";
            DiaChi.Size = new Size(660, 40);
            DiaChi.TabIndex = 4;
            DiaChi.Text = "Địa chỉ";
            DiaChi.Click += DiaChi_Click;
            // 
            // KyNang
            // 
            KyNang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            KyNang.Location = new Point(248, 183);
            KyNang.Name = "KyNang";
            KyNang.Size = new Size(555, 32);
            KyNang.TabIndex = 5;
            KyNang.Text = "Kỹ năng";
            // 
            // CPN_CardTuyenDung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(KyNang);
            Controls.Add(DiaChi);
            Controls.Add(CapBac);
            Controls.Add(TenDN);
            Controls.Add(Title);
            Controls.Add(Ava);
            Name = "CPN_CardTuyenDung";
            Size = new Size(1056, 226);
            Load += CPN_CardTuyenDung_Load;
            ((System.ComponentModel.ISupportInitialize)Ava).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Ava;
        private Label Title;
        private Label TenDN;
        private Label CapBac;
        private Label DiaChi;
        private Label KyNang;
    }
}
