namespace GUI
{
    partial class CPN_XNPQC
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
            panel2 = new Panel();
            gboxTGHT = new GroupBox();
            richboxHinhThuc = new RichTextBox();
            tbThoigian = new TextBox();
            lbNgayTD = new Label();
            dtpkNgayTD = new DateTimePicker();
            label3 = new Label();
            lbTgian = new Label();
            gboxTTDT = new GroupBox();
            richboxKyNang = new RichTextBox();
            lbKyNang = new Label();
            tbSoluong = new TextBox();
            tbVitri = new TextBox();
            tbCapbac = new TextBox();
            label7 = new Label();
            lbYeucau = new Label();
            lbSoluong = new Label();
            lbVitri = new Label();
            lbCapbac = new Label();
            richboxYeucau = new RichTextBox();
            pnlXacnhan = new Panel();
            btnXacnhan = new Button();
            pnlTitle = new Panel();
            pnlTilte2 = new Panel();
            lbTitle = new Label();
            panel2.SuspendLayout();
            gboxTGHT.SuspendLayout();
            gboxTTDT.SuspendLayout();
            pnlXacnhan.SuspendLayout();
            pnlTitle.SuspendLayout();
            pnlTilte2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(gboxTGHT);
            panel2.Controls.Add(gboxTTDT);
            panel2.Location = new Point(14, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(1049, 516);
            panel2.TabIndex = 24;
            // 
            // gboxTGHT
            // 
            gboxTGHT.Controls.Add(richboxHinhThuc);
            gboxTGHT.Controls.Add(tbThoigian);
            gboxTGHT.Controls.Add(lbNgayTD);
            gboxTGHT.Controls.Add(dtpkNgayTD);
            gboxTGHT.Controls.Add(label3);
            gboxTGHT.Controls.Add(lbTgian);
            gboxTGHT.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gboxTGHT.Location = new Point(762, 49);
            gboxTGHT.Name = "gboxTGHT";
            gboxTGHT.Size = new Size(265, 449);
            gboxTGHT.TabIndex = 1;
            gboxTGHT.TabStop = false;
            gboxTGHT.Text = "Thời gian và hình thức";
            // 
            // richboxHinhThuc
            // 
            richboxHinhThuc.Enabled = false;
            richboxHinhThuc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richboxHinhThuc.Location = new Point(18, 299);
            richboxHinhThuc.Name = "richboxHinhThuc";
            richboxHinhThuc.ReadOnly = true;
            richboxHinhThuc.Size = new Size(235, 144);
            richboxHinhThuc.TabIndex = 31;
            richboxHinhThuc.Text = "";
            // 
            // tbThoigian
            // 
            tbThoigian.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbThoigian.Location = new Point(18, 93);
            tbThoigian.Name = "tbThoigian";
            tbThoigian.ReadOnly = true;
            tbThoigian.Size = new Size(235, 27);
            tbThoigian.TabIndex = 29;
            // 
            // lbNgayTD
            // 
            lbNgayTD.AutoSize = true;
            lbNgayTD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbNgayTD.Location = new Point(18, 180);
            lbNgayTD.Name = "lbNgayTD";
            lbNgayTD.Size = new Size(129, 20);
            lbNgayTD.TabIndex = 26;
            lbNgayTD.Text = "Ngày tuyển dụng";
            // 
            // dtpkNgayTD
            // 
            dtpkNgayTD.Enabled = false;
            dtpkNgayTD.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpkNgayTD.Location = new Point(18, 203);
            dtpkNgayTD.Name = "dtpkNgayTD";
            dtpkNgayTD.Size = new Size(235, 27);
            dtpkNgayTD.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 276);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 23;
            label3.Text = "Hình thức đăng tuyển";
            // 
            // lbTgian
            // 
            lbTgian.AutoSize = true;
            lbTgian.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbTgian.Location = new Point(18, 73);
            lbTgian.Name = "lbTgian";
            lbTgian.Size = new Size(239, 20);
            lbTgian.TabIndex = 17;
            lbTgian.Text = "Thời gian tuyển dụng (theo ngày)";
            // 
            // gboxTTDT
            // 
            gboxTTDT.Controls.Add(richboxKyNang);
            gboxTTDT.Controls.Add(lbKyNang);
            gboxTTDT.Controls.Add(tbSoluong);
            gboxTTDT.Controls.Add(tbVitri);
            gboxTTDT.Controls.Add(tbCapbac);
            gboxTTDT.Controls.Add(label7);
            gboxTTDT.Controls.Add(lbYeucau);
            gboxTTDT.Controls.Add(lbSoluong);
            gboxTTDT.Controls.Add(lbVitri);
            gboxTTDT.Controls.Add(lbCapbac);
            gboxTTDT.Controls.Add(richboxYeucau);
            gboxTTDT.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gboxTTDT.Location = new Point(20, 49);
            gboxTTDT.Name = "gboxTTDT";
            gboxTTDT.Size = new Size(727, 449);
            gboxTTDT.TabIndex = 0;
            gboxTTDT.TabStop = false;
            gboxTTDT.Text = "Thông tin đăng tuyển";
            // 
            // richboxKyNang
            // 
            richboxKyNang.Enabled = false;
            richboxKyNang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richboxKyNang.Location = new Point(562, 169);
            richboxKyNang.Name = "richboxKyNang";
            richboxKyNang.ReadOnly = true;
            richboxKyNang.Size = new Size(148, 274);
            richboxKyNang.TabIndex = 30;
            richboxKyNang.Text = "";
            // 
            // lbKyNang
            // 
            lbKyNang.AutoSize = true;
            lbKyNang.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbKyNang.Location = new Point(562, 146);
            lbKyNang.Name = "lbKyNang";
            lbKyNang.Size = new Size(148, 20);
            lbKyNang.TabIndex = 29;
            lbKyNang.Text = "Kỹ năng tuyển dụng";
            // 
            // tbSoluong
            // 
            tbSoluong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSoluong.Location = new Point(561, 93);
            tbSoluong.Name = "tbSoluong";
            tbSoluong.ReadOnly = true;
            tbSoluong.Size = new Size(148, 27);
            tbSoluong.TabIndex = 28;
            // 
            // tbVitri
            // 
            tbVitri.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbVitri.Location = new Point(286, 93);
            tbVitri.Name = "tbVitri";
            tbVitri.ReadOnly = true;
            tbVitri.Size = new Size(198, 27);
            tbVitri.TabIndex = 27;
            // 
            // tbCapbac
            // 
            tbCapbac.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCapbac.Location = new Point(11, 93);
            tbCapbac.Name = "tbCapbac";
            tbCapbac.ReadOnly = true;
            tbCapbac.Size = new Size(198, 27);
            tbCapbac.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(764, 8);
            label7.Name = "label7";
            label7.Size = new Size(18, 23);
            label7.TabIndex = 25;
            label7.Text = "*";
            // 
            // lbYeucau
            // 
            lbYeucau.AutoSize = true;
            lbYeucau.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbYeucau.Location = new Point(14, 146);
            lbYeucau.Name = "lbYeucau";
            lbYeucau.Size = new Size(145, 20);
            lbYeucau.TabIndex = 23;
            lbYeucau.Text = "Yêu cầu tuyển dụng";
            // 
            // lbSoluong
            // 
            lbSoluong.AutoSize = true;
            lbSoluong.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbSoluong.Location = new Point(562, 73);
            lbSoluong.Name = "lbSoluong";
            lbSoluong.Size = new Size(153, 20);
            lbSoluong.TabIndex = 22;
            lbSoluong.Text = "Số lượng tuyển dụng";
            // 
            // lbVitri
            // 
            lbVitri.AutoSize = true;
            lbVitri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbVitri.Location = new Point(288, 72);
            lbVitri.Name = "lbVitri";
            lbVitri.Size = new Size(125, 20);
            lbVitri.TabIndex = 21;
            lbVitri.Text = "Vị trí tuyển dụng";
            // 
            // lbCapbac
            // 
            lbCapbac.AutoSize = true;
            lbCapbac.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbCapbac.Location = new Point(14, 72);
            lbCapbac.Name = "lbCapbac";
            lbCapbac.Size = new Size(146, 20);
            lbCapbac.TabIndex = 19;
            lbCapbac.Text = "Cấp bậc tuyển dụng";
            // 
            // richboxYeucau
            // 
            richboxYeucau.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richboxYeucau.Location = new Point(14, 169);
            richboxYeucau.Name = "richboxYeucau";
            richboxYeucau.ReadOnly = true;
            richboxYeucau.Size = new Size(470, 274);
            richboxYeucau.TabIndex = 18;
            richboxYeucau.Text = "";
            // 
            // pnlXacnhan
            // 
            pnlXacnhan.BackColor = Color.MediumSeaGreen;
            pnlXacnhan.Controls.Add(btnXacnhan);
            pnlXacnhan.Location = new Point(907, 32);
            pnlXacnhan.Name = "pnlXacnhan";
            pnlXacnhan.Size = new Size(135, 61);
            pnlXacnhan.TabIndex = 27;
            // 
            // btnXacnhan
            // 
            btnXacnhan.BackColor = Color.White;
            btnXacnhan.FlatStyle = FlatStyle.Flat;
            btnXacnhan.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXacnhan.Location = new Point(3, 3);
            btnXacnhan.Name = "btnXacnhan";
            btnXacnhan.Size = new Size(129, 55);
            btnXacnhan.TabIndex = 15;
            btnXacnhan.Text = "Xác nhận";
            btnXacnhan.UseVisualStyleBackColor = false;
            btnXacnhan.Click += btnXacnhan_Click;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.MediumSeaGreen;
            pnlTitle.BorderStyle = BorderStyle.FixedSingle;
            pnlTitle.Controls.Add(pnlTilte2);
            pnlTitle.Location = new Point(35, 32);
            pnlTitle.Margin = new Padding(0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Padding = new Padding(7, 0, 0, 0);
            pnlTitle.Size = new Size(306, 61);
            pnlTitle.TabIndex = 28;
            // 
            // pnlTilte2
            // 
            pnlTilte2.BackColor = Color.White;
            pnlTilte2.Controls.Add(lbTitle);
            pnlTilte2.Dock = DockStyle.Fill;
            pnlTilte2.Location = new Point(7, 0);
            pnlTilte2.Name = "pnlTilte2";
            pnlTilte2.Size = new Size(297, 59);
            pnlTilte2.TabIndex = 7;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(3, 15);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(296, 31);
            lbTitle.TabIndex = 7;
            lbTitle.Text = "Xác nhận phiếu quảng cáo";
            // 
            // CPN_XNPQC
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            Controls.Add(pnlTitle);
            Controls.Add(pnlXacnhan);
            Controls.Add(panel2);
            Margin = new Padding(0);
            Name = "CPN_XNPQC";
            Size = new Size(1077, 610);
            panel2.ResumeLayout(false);
            gboxTGHT.ResumeLayout(false);
            gboxTGHT.PerformLayout();
            gboxTTDT.ResumeLayout(false);
            gboxTTDT.PerformLayout();
            pnlXacnhan.ResumeLayout(false);
            pnlTitle.ResumeLayout(false);
            pnlTilte2.ResumeLayout(false);
            pnlTilte2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel pnlXacnhan;
        private Button btnXacnhan;
        private GroupBox gboxTGHT;
        private Panel pnlTitle;
        private Panel pnlTilte2;
        private Label lbTitle;
        private Label lbTgian;
        private Label label3;
        private Label lbNgayTD;
        private GroupBox gboxTTDT;
        private Label label7;
        private Label lbYeucau;
        private Label lbSoluong;
        private Label lbVitri;
        private Label lbCapbac;
        private RichTextBox richboxYeucau;
        private TextBox tbCapbac;
        private TextBox tbThoigian;
        private TextBox tbSoluong;
        private TextBox tbVitri;
        private DateTimePicker dtpkNgayTD;
        private RichTextBox richboxKyNang;
        private Label lbKyNang;
        private RichTextBox richboxHinhThuc;
    }
}
