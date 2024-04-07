namespace GUI
{
    partial class Tab_XemHoaDon
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            gboxTTTT = new GroupBox();
            tbSoLan = new TextBox();
            tbConLai = new TextBox();
            tbTongTien = new TextBox();
            lbSoLan = new Label();
            lbConLai = new Label();
            lbTongTien = new Label();
            dtgHoaDon = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            pnlTitle = new Panel();
            pnlTilte2 = new Panel();
            lbTitle = new Label();
            MAHOADON = new DataGridViewTextBoxColumn();
            NGAYTT = new DataGridViewTextBoxColumn();
            SOTIEN = new DataGridViewTextBoxColumn();
            HINHTHUCTT = new DataGridViewTextBoxColumn();
            NVTHANHTOAN = new DataGridViewTextBoxColumn();
            gboxTTTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHoaDon).BeginInit();
            panel2.SuspendLayout();
            pnlTitle.SuspendLayout();
            pnlTilte2.SuspendLayout();
            SuspendLayout();
            // 
            // gboxTTTT
            // 
            gboxTTTT.Controls.Add(tbSoLan);
            gboxTTTT.Controls.Add(tbConLai);
            gboxTTTT.Controls.Add(tbTongTien);
            gboxTTTT.Controls.Add(lbSoLan);
            gboxTTTT.Controls.Add(lbConLai);
            gboxTTTT.Controls.Add(lbTongTien);
            gboxTTTT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gboxTTTT.Location = new Point(3, 90);
            gboxTTTT.Name = "gboxTTTT";
            gboxTTTT.Size = new Size(364, 403);
            gboxTTTT.TabIndex = 35;
            gboxTTTT.TabStop = false;
            gboxTTTT.Text = "Thông tin thanh toán";
            // 
            // tbSoLan
            // 
            tbSoLan.BackColor = Color.White;
            tbSoLan.Location = new Point(20, 340);
            tbSoLan.Name = "tbSoLan";
            tbSoLan.ReadOnly = true;
            tbSoLan.Size = new Size(324, 27);
            tbSoLan.TabIndex = 6;
            // 
            // tbConLai
            // 
            tbConLai.BackColor = Color.White;
            tbConLai.Location = new Point(20, 203);
            tbConLai.Name = "tbConLai";
            tbConLai.ReadOnly = true;
            tbConLai.Size = new Size(324, 27);
            tbConLai.TabIndex = 5;
            // 
            // tbTongTien
            // 
            tbTongTien.BackColor = Color.White;
            tbTongTien.Location = new Point(20, 73);
            tbTongTien.Name = "tbTongTien";
            tbTongTien.ReadOnly = true;
            tbTongTien.Size = new Size(324, 27);
            tbTongTien.TabIndex = 4;
            // 
            // lbSoLan
            // 
            lbSoLan.AutoSize = true;
            lbSoLan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSoLan.Location = new Point(20, 317);
            lbSoLan.Name = "lbSoLan";
            lbSoLan.Size = new Size(155, 20);
            lbSoLan.TabIndex = 2;
            lbSoLan.Text = "Số lần đã thanh toán:";
            // 
            // lbConLai
            // 
            lbConLai.AutoSize = true;
            lbConLai.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbConLai.Location = new Point(20, 180);
            lbConLai.Name = "lbConLai";
            lbConLai.Size = new Size(146, 20);
            lbConLai.TabIndex = 1;
            lbConLai.Text = "Tổng số tiền còn lại:";
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTongTien.Location = new Point(20, 50);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(204, 20);
            lbTongTien.TabIndex = 0;
            lbTongTien.Text = "Tổng số tiền cần thanh toán:";
            // 
            // dtgHoaDon
            // 
            dtgHoaDon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHoaDon.Columns.AddRange(new DataGridViewColumn[] { MAHOADON, NGAYTT, SOTIEN, HINHTHUCTT, NVTHANHTOAN });
            dtgHoaDon.Location = new Point(375, 100);
            dtgHoaDon.Name = "dtgHoaDon";
            dtgHoaDon.ReadOnly = true;
            dtgHoaDon.RowHeadersWidth = 51;
            dtgHoaDon.Size = new Size(654, 393);
            dtgHoaDon.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(gboxTTTT);
            panel2.Controls.Add(dtgHoaDon);
            panel2.Location = new Point(14, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(1049, 516);
            panel2.TabIndex = 36;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 57);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 37;
            label1.Text = "Tìm kiếm:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(451, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(578, 27);
            textBox1.TabIndex = 36;
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
            pnlTitle.Size = new Size(293, 61);
            pnlTitle.TabIndex = 37;
            // 
            // pnlTilte2
            // 
            pnlTilte2.BackColor = Color.White;
            pnlTilte2.Controls.Add(lbTitle);
            pnlTilte2.Dock = DockStyle.Fill;
            pnlTilte2.Location = new Point(7, 0);
            pnlTilte2.Name = "pnlTilte2";
            pnlTilte2.Size = new Size(284, 59);
            pnlTilte2.TabIndex = 7;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(3, 15);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(281, 31);
            lbTitle.TabIndex = 7;
            lbTitle.Text = "Xem hoá đơn thanh toán";
            // 
            // MAHOADON
            // 
            MAHOADON.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MAHOADON.DefaultCellStyle = dataGridViewCellStyle2;
            MAHOADON.HeaderText = "Mã hóa đơn";
            MAHOADON.MinimumWidth = 6;
            MAHOADON.Name = "MAHOADON";
            MAHOADON.ReadOnly = true;
            // 
            // NGAYTT
            // 
            NGAYTT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NGAYTT.HeaderText = "Ngày thanh toán";
            NGAYTT.MinimumWidth = 6;
            NGAYTT.Name = "NGAYTT";
            NGAYTT.ReadOnly = true;
            // 
            // SOTIEN
            // 
            SOTIEN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SOTIEN.HeaderText = "Số tiền";
            SOTIEN.MinimumWidth = 6;
            SOTIEN.Name = "SOTIEN";
            SOTIEN.ReadOnly = true;
            // 
            // HINHTHUCTT
            // 
            HINHTHUCTT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HINHTHUCTT.HeaderText = "Hình thức thanh toán";
            HINHTHUCTT.MinimumWidth = 6;
            HINHTHUCTT.Name = "HINHTHUCTT";
            HINHTHUCTT.ReadOnly = true;
            // 
            // NVTHANHTOAN
            // 
            NVTHANHTOAN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NVTHANHTOAN.HeaderText = "Nhân viên thanh toán";
            NVTHANHTOAN.MinimumWidth = 6;
            NVTHANHTOAN.Name = "NVTHANHTOAN";
            NVTHANHTOAN.ReadOnly = true;
            // 
            // Tab_XemHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(pnlTitle);
            Controls.Add(panel2);
            Name = "Tab_XemHoaDon";
            Size = new Size(1077, 610);
            gboxTTTT.ResumeLayout(false);
            gboxTTTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHoaDon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlTitle.ResumeLayout(false);
            pnlTilte2.ResumeLayout(false);
            pnlTilte2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxTTTT;
        private TextBox tbSoLan;
        private TextBox tbConLai;
        private TextBox tbTongTien;
        private Label lbSoLan;
        private Label lbConLai;
        private Label lbTongTien;
        private DataGridView dtgHoaDon;
        private Panel panel2;
        private Panel pnlTitle;
        private Panel pnlTilte2;
        private Label lbTitle;
        private TextBox textBox1;
        private Label label1;
        private DataGridViewTextBoxColumn MAHOADON;
        private DataGridViewTextBoxColumn NGAYTT;
        private DataGridViewTextBoxColumn SOTIEN;
        private DataGridViewTextBoxColumn HINHTHUCTT;
        private DataGridViewTextBoxColumn NVTHANHTOAN;
    }
}
