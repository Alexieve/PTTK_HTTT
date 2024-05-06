namespace GUI
{
    partial class NV_ThanhToan
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lbTopbar = new Label();
            pnlTop = new Panel();
            dtgHoaDon = new DataGridView();
            tbMAHOPDONG = new TextBox();
            btnTimBai = new Button();
            pnlSave = new Panel();
            btnSave = new Button();
            panel1 = new Panel();
            btnThanhToan = new Button();
            rbtnTTToanBo = new RadioButton();
            rbtnTT30 = new RadioButton();
            panel2 = new Panel();
            gboxTTTT = new GroupBox();
            tbSoLan = new TextBox();
            tbConLai = new TextBox();
            tbTongTien = new TextBox();
            lbSoLan = new Label();
            lbConLai = new Label();
            lbTongTien = new Label();
            gboxHinhThuc = new GroupBox();
            rbtnThe = new RadioButton();
            rbtnTienMat = new RadioButton();
            gboxThoiHan = new GroupBox();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHoaDon).BeginInit();
            pnlSave.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            gboxTTTT.SuspendLayout();
            gboxHinhThuc.SuspendLayout();
            gboxThoiHan.SuspendLayout();
            SuspendLayout();
            // 
            // lbTopbar
            // 
            lbTopbar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbTopbar.AutoSize = true;
            lbTopbar.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTopbar.ForeColor = SystemColors.Control;
            lbTopbar.Location = new Point(345, 9);
            lbTopbar.Name = "lbTopbar";
            lbTopbar.Size = new Size(379, 46);
            lbTopbar.TabIndex = 0;
            lbTopbar.Text = "Thanh Toán Hợp Đồng";
            lbTopbar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.Gray;
            pnlTop.Controls.Add(lbTopbar);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.ForeColor = Color.Transparent;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1077, 69);
            pnlTop.TabIndex = 1;
            // 
            // dtgHoaDon
            // 
            dtgHoaDon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            dtgHoaDon.Location = new Point(402, 161);
            dtgHoaDon.Name = "dtgHoaDon";
            dtgHoaDon.ReadOnly = true;
            dtgHoaDon.RowHeadersWidth = 51;
            dtgHoaDon.Size = new Size(630, 436);
            dtgHoaDon.TabIndex = 3;
            // 
            // tbMAHOPDONG
            // 
            tbMAHOPDONG.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbMAHOPDONG.Location = new Point(174, 60);
            tbMAHOPDONG.Name = "tbMAHOPDONG";
            tbMAHOPDONG.PlaceholderText = "Nhập mã bài đăng tuyển dụng";
            tbMAHOPDONG.Size = new Size(211, 27);
            tbMAHOPDONG.TabIndex = 5;
            // 
            // btnTimBai
            // 
            btnTimBai.BackColor = Color.MediumSeaGreen;
            btnTimBai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimBai.Location = new Point(21, 43);
            btnTimBai.Name = "btnTimBai";
            btnTimBai.Size = new Size(147, 61);
            btnTimBai.TabIndex = 6;
            btnTimBai.Text = "Tìm";
            btnTimBai.UseVisualStyleBackColor = false;
            btnTimBai.Click += btnTimBai_Click;
            // 
            // pnlSave
            // 
            pnlSave.BackColor = Color.MediumSeaGreen;
            pnlSave.Controls.Add(btnSave);
            pnlSave.Location = new Point(832, 43);
            pnlSave.Name = "pnlSave";
            pnlSave.Size = new Size(200, 61);
            pnlSave.TabIndex = 25;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(194, 55);
            btnSave.TabIndex = 15;
            btnSave.Text = "In hóa đơn";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(btnThanhToan);
            panel1.Location = new Point(402, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 61);
            panel1.TabIndex = 26;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.White;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToan.Location = new Point(3, 3);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(194, 55);
            btnThanhToan.TabIndex = 15;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // rbtnTTToanBo
            // 
            rbtnTTToanBo.AutoSize = true;
            rbtnTTToanBo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            rbtnTTToanBo.Location = new Point(6, 32);
            rbtnTTToanBo.Name = "rbtnTTToanBo";
            rbtnTTToanBo.Size = new Size(165, 24);
            rbtnTTToanBo.TabIndex = 27;
            rbtnTTToanBo.TabStop = true;
            rbtnTTToanBo.Text = "Thanh toán toàn bộ";
            rbtnTTToanBo.UseVisualStyleBackColor = true;
            // 
            // rbtnTT30
            // 
            rbtnTT30.AutoSize = true;
            rbtnTT30.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            rbtnTT30.Location = new Point(217, 32);
            rbtnTT30.Name = "rbtnTT30";
            rbtnTT30.Size = new Size(141, 24);
            rbtnTT30.TabIndex = 28;
            rbtnTT30.TabStop = true;
            rbtnTT30.Text = "Thanh toán 30%";
            rbtnTT30.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(gboxTTTT);
            panel2.Controls.Add(gboxHinhThuc);
            panel2.Controls.Add(gboxThoiHan);
            panel2.Controls.Add(dtgHoaDon);
            panel2.Controls.Add(tbMAHOPDONG);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(btnTimBai);
            panel2.Controls.Add(pnlSave);
            panel2.Location = new Point(12, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(1053, 623);
            panel2.TabIndex = 29;
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
            gboxTTTT.Location = new Point(21, 151);
            gboxTTTT.Name = "gboxTTTT";
            gboxTTTT.Size = new Size(364, 280);
            gboxTTTT.TabIndex = 31;
            gboxTTTT.TabStop = false;
            gboxTTTT.Text = "Thông tin thanh toán";
            // 
            // tbSoLan
            // 
            tbSoLan.BackColor = Color.White;
            tbSoLan.Font = new Font("Segoe UI", 9F);
            tbSoLan.Location = new Point(20, 236);
            tbSoLan.Name = "tbSoLan";
            tbSoLan.ReadOnly = true;
            tbSoLan.Size = new Size(324, 27);
            tbSoLan.TabIndex = 6;
            // 
            // tbConLai
            // 
            tbConLai.BackColor = Color.White;
            tbConLai.Font = new Font("Segoe UI", 9F);
            tbConLai.Location = new Point(20, 154);
            tbConLai.Name = "tbConLai";
            tbConLai.ReadOnly = true;
            tbConLai.Size = new Size(324, 27);
            tbConLai.TabIndex = 5;
            // 
            // tbTongTien
            // 
            tbTongTien.BackColor = Color.White;
            tbTongTien.Font = new Font("Segoe UI", 9F);
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
            lbSoLan.Location = new Point(20, 213);
            lbSoLan.Name = "lbSoLan";
            lbSoLan.Size = new Size(155, 20);
            lbSoLan.TabIndex = 2;
            lbSoLan.Text = "Số lần đã thanh toán:";
            // 
            // lbConLai
            // 
            lbConLai.AutoSize = true;
            lbConLai.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbConLai.Location = new Point(20, 131);
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
            // gboxHinhThuc
            // 
            gboxHinhThuc.Controls.Add(rbtnThe);
            gboxHinhThuc.Controls.Add(rbtnTienMat);
            gboxHinhThuc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gboxHinhThuc.Location = new Point(21, 520);
            gboxHinhThuc.Name = "gboxHinhThuc";
            gboxHinhThuc.Size = new Size(364, 77);
            gboxHinhThuc.TabIndex = 30;
            gboxHinhThuc.TabStop = false;
            gboxHinhThuc.Text = "Hình thức thanh toán";
            // 
            // rbtnThe
            // 
            rbtnThe.AutoSize = true;
            rbtnThe.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            rbtnThe.Location = new Point(217, 33);
            rbtnThe.Name = "rbtnThe";
            rbtnThe.Size = new Size(55, 24);
            rbtnThe.TabIndex = 30;
            rbtnThe.TabStop = true;
            rbtnThe.Text = "Thẻ";
            rbtnThe.UseVisualStyleBackColor = true;
            // 
            // rbtnTienMat
            // 
            rbtnTienMat.AutoSize = true;
            rbtnTienMat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            rbtnTienMat.Location = new Point(10, 33);
            rbtnTienMat.Name = "rbtnTienMat";
            rbtnTienMat.Size = new Size(89, 24);
            rbtnTienMat.TabIndex = 29;
            rbtnTienMat.TabStop = true;
            rbtnTienMat.Text = "Tiền mặt";
            rbtnTienMat.UseVisualStyleBackColor = true;
            // 
            // gboxThoiHan
            // 
            gboxThoiHan.Controls.Add(rbtnTT30);
            gboxThoiHan.Controls.Add(rbtnTTToanBo);
            gboxThoiHan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gboxThoiHan.Location = new Point(21, 437);
            gboxThoiHan.Name = "gboxThoiHan";
            gboxThoiHan.Size = new Size(364, 77);
            gboxThoiHan.TabIndex = 29;
            gboxThoiHan.TabStop = false;
            gboxThoiHan.Text = "Mức thanh toán";
            // 
            // NV_ThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1077, 721);
            Controls.Add(pnlTop);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NV_ThanhToan";
            Text = "Page_TT";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHoaDon).EndInit();
            pnlSave.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            gboxTTTT.ResumeLayout(false);
            gboxTTTT.PerformLayout();
            gboxHinhThuc.ResumeLayout(false);
            gboxHinhThuc.PerformLayout();
            gboxThoiHan.ResumeLayout(false);
            gboxThoiHan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbTopbar;
        private Panel pnlTop;
        private DataGridView dtgHoaDon;
        private TextBox tbMAHOPDONG;
        private Button btnTimBai;
        private Panel pnlSave;
        private Button btnSave;
        private Panel panel1;
        private Button btnThanhToan;
        private RadioButton rbtnTTToanBo;
        private RadioButton rbtnTT30;
        private Panel panel2;
        private GroupBox gboxThoiHan;
        private GroupBox gboxHinhThuc;
        private RadioButton rbtnThe;
        private RadioButton rbtnTienMat;
        private GroupBox gboxTTTT;
        private Label lbTongTien;
        private Label lbSoLan;
        private Label lbConLai;
        private TextBox tbSoLan;
        private TextBox tbConLai;
        private TextBox tbTongTien;
    }
}