namespace GUI
{
    partial class NV_XuLyDNTN
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            TitleLabel = new Label();
            TittlePanel = new Panel();
            ParentPanel = new Panel();
            panel2 = new Panel();
            GiaHanBtn = new Button();
            XemCTBtn = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            MAHDBox = new TextBox();
            UuDaiBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            SoNgayGHBox = new TextBox();
            NgayKTBox = new TextBox();
            SoLuongTDBox = new TextBox();
            ViTriTDBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            TenDNBox = new TextBox();
            label2 = new Label();
            SDTBox = new TextBox();
            DNTb = new DataGridView();
            MADN = new DataGridViewTextBoxColumn();
            MAHD = new DataGridViewTextBoxColumn();
            TittlePanel.SuspendLayout();
            ParentPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DNTb).BeginInit();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = SystemColors.Control;
            TitleLabel.Location = new Point(0, 19);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(1077, 46);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Xác Thực Hồ Sơ Ứng Tuyển";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TittlePanel
            // 
            TittlePanel.BackColor = Color.Gray;
            TittlePanel.Controls.Add(TitleLabel);
            TittlePanel.Location = new Point(0, 0);
            TittlePanel.Name = "TittlePanel";
            TittlePanel.Size = new Size(1077, 80);
            TittlePanel.TabIndex = 0;
            // 
            // ParentPanel
            // 
            ParentPanel.Controls.Add(panel2);
            ParentPanel.Controls.Add(panel1);
            ParentPanel.Controls.Add(TittlePanel);
            ParentPanel.Dock = DockStyle.Fill;
            ParentPanel.Location = new Point(0, 0);
            ParentPanel.Name = "ParentPanel";
            ParentPanel.Size = new Size(1077, 721);
            ParentPanel.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(GiaHanBtn);
            panel2.Controls.Add(XemCTBtn);
            panel2.Location = new Point(0, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(1077, 45);
            panel2.TabIndex = 2;
            // 
            // GiaHanBtn
            // 
            GiaHanBtn.Location = new Point(917, 0);
            GiaHanBtn.Name = "GiaHanBtn";
            GiaHanBtn.Size = new Size(148, 45);
            GiaHanBtn.TabIndex = 1;
            GiaHanBtn.Text = "Gia Hạn";
            GiaHanBtn.UseVisualStyleBackColor = true;
            // 
            // XemCTBtn
            // 
            XemCTBtn.Location = new Point(12, 0);
            XemCTBtn.Name = "XemCTBtn";
            XemCTBtn.Size = new Size(148, 45);
            XemCTBtn.TabIndex = 0;
            XemCTBtn.Text = "Xem Chi Tiết";
            XemCTBtn.UseVisualStyleBackColor = true;
            XemCTBtn.Click += XemCTBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(0, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(1077, 584);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(DNTb, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1053, 569);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel2.Controls.Add(MAHDBox, 1, 2);
            tableLayoutPanel2.Controls.Add(UuDaiBox, 1, 6);
            tableLayoutPanel2.Controls.Add(label7, 0, 2);
            tableLayoutPanel2.Controls.Add(label8, 0, 6);
            tableLayoutPanel2.Controls.Add(SoNgayGHBox, 1, 7);
            tableLayoutPanel2.Controls.Add(NgayKTBox, 1, 5);
            tableLayoutPanel2.Controls.Add(SoLuongTDBox, 1, 4);
            tableLayoutPanel2.Controls.Add(ViTriTDBox, 1, 3);
            tableLayoutPanel2.Controls.Add(label3, 0, 3);
            tableLayoutPanel2.Controls.Add(label4, 0, 4);
            tableLayoutPanel2.Controls.Add(label5, 0, 5);
            tableLayoutPanel2.Controls.Add(label6, 0, 7);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(TenDNBox, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(SDTBox, 1, 1);
            tableLayoutPanel2.Location = new Point(424, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(626, 563);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // MAHDBox
            // 
            MAHDBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MAHDBox.Location = new Point(163, 159);
            MAHDBox.Name = "MAHDBox";
            MAHDBox.ReadOnly = true;
            MAHDBox.Size = new Size(457, 34);
            MAHDBox.TabIndex = 9;
            // 
            // UuDaiBox
            // 
            UuDaiBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UuDaiBox.Location = new Point(163, 439);
            UuDaiBox.Name = "UuDaiBox";
            UuDaiBox.ReadOnly = true;
            UuDaiBox.Size = new Size(457, 34);
            UuDaiBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(6, 162);
            label7.Name = "label7";
            label7.Size = new Size(148, 28);
            label7.TabIndex = 8;
            label7.Text = "Mã Hợp Đồng";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(6, 442);
            label8.Name = "label8";
            label8.Size = new Size(148, 28);
            label8.TabIndex = 5;
            label8.Text = "Ưu Đãi Đề Xuất";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SoNgayGHBox
            // 
            SoNgayGHBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SoNgayGHBox.Location = new Point(163, 509);
            SoNgayGHBox.Name = "SoNgayGHBox";
            SoNgayGHBox.Size = new Size(457, 34);
            SoNgayGHBox.TabIndex = 11;
            SoNgayGHBox.Text = "0";
            SoNgayGHBox.KeyPress += SoNgayGHBox_KeyPress;
            // 
            // NgayKTBox
            // 
            NgayKTBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NgayKTBox.Location = new Point(163, 369);
            NgayKTBox.Name = "NgayKTBox";
            NgayKTBox.ReadOnly = true;
            NgayKTBox.Size = new Size(457, 34);
            NgayKTBox.TabIndex = 10;
            // 
            // SoLuongTDBox
            // 
            SoLuongTDBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SoLuongTDBox.Location = new Point(163, 299);
            SoLuongTDBox.Name = "SoLuongTDBox";
            SoLuongTDBox.ReadOnly = true;
            SoLuongTDBox.Size = new Size(457, 34);
            SoLuongTDBox.TabIndex = 9;
            // 
            // ViTriTDBox
            // 
            ViTriTDBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ViTriTDBox.Location = new Point(163, 229);
            ViTriTDBox.Name = "ViTriTDBox";
            ViTriTDBox.ReadOnly = true;
            ViTriTDBox.Size = new Size(457, 34);
            ViTriTDBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(6, 218);
            label3.Name = "label3";
            label3.Size = new Size(148, 56);
            label3.TabIndex = 2;
            label3.Text = "Vị Trí Tuyển Dụng";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(6, 288);
            label4.Name = "label4";
            label4.Size = new Size(148, 56);
            label4.TabIndex = 3;
            label4.Text = "Số Lượng Tuyển Dụng";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(6, 358);
            label5.Name = "label5";
            label5.Size = new Size(148, 56);
            label5.TabIndex = 4;
            label5.Text = "Ngày Kết Thúc Hợp Đồng";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(6, 498);
            label6.Name = "label6";
            label6.Size = new Size(148, 56);
            label6.TabIndex = 5;
            label6.Text = "Số Ngày Gia Hạn";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(6, 8);
            label1.Name = "label1";
            label1.Size = new Size(148, 56);
            label1.TabIndex = 0;
            label1.Text = "Tên Doanh Nghiệp";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TenDNBox
            // 
            TenDNBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TenDNBox.Location = new Point(163, 19);
            TenDNBox.Name = "TenDNBox";
            TenDNBox.ReadOnly = true;
            TenDNBox.Size = new Size(457, 34);
            TenDNBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(6, 92);
            label2.Name = "label2";
            label2.Size = new Size(148, 28);
            label2.TabIndex = 1;
            label2.Text = "Số Điện Thoại";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SDTBox
            // 
            SDTBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SDTBox.Location = new Point(163, 89);
            SDTBox.Name = "SDTBox";
            SDTBox.ReadOnly = true;
            SDTBox.Size = new Size(457, 34);
            SDTBox.TabIndex = 7;
            // 
            // DNTb
            // 
            DNTb.AllowUserToAddRows = false;
            DNTb.AllowUserToDeleteRows = false;
            DNTb.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DNTb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DNTb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DNTb.Columns.AddRange(new DataGridViewColumn[] { MADN, MAHD });
            DNTb.Dock = DockStyle.Fill;
            DNTb.Location = new Point(3, 3);
            DNTb.Name = "DNTb";
            DNTb.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DNTb.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DNTb.RowHeadersWidth = 51;
            DNTb.Size = new Size(415, 563);
            DNTb.TabIndex = 2;
            // 
            // MADN
            // 
            MADN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MADN.HeaderText = "Mã Doanh Nghiệp";
            MADN.MinimumWidth = 6;
            MADN.Name = "MADN";
            MADN.ReadOnly = true;
            // 
            // MAHD
            // 
            MAHD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MAHD.DefaultCellStyle = dataGridViewCellStyle2;
            MAHD.HeaderText = "Mã Hợp Đồng";
            MAHD.MinimumWidth = 6;
            MAHD.Name = "MAHD";
            MAHD.ReadOnly = true;
            // 
            // NV_XuLyDNTN
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 721);
            Controls.Add(ParentPanel);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NV_XuLyDNTN";
            Text = "XulyDNTN";
            TittlePanel.ResumeLayout(false);
            ParentPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DNTb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label TitleLabel;
        private Panel TittlePanel;
        private Panel ParentPanel;
        private Panel panel2;
        private Button XemCTBtn;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView DNTb;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label8;
        private TextBox SoNgayGHBox;
        private TextBox NgayKTBox;
        private TextBox SoLuongTDBox;
        private TextBox ViTriTDBox;
        private TextBox SDTBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TenDNBox;
        private TextBox UuDaiBox;
        private Button GiaHanBtn;
        private DataGridViewTextBoxColumn MADN;
        private DataGridViewTextBoxColumn MAHD;
        private TextBox MAHDBox;
        private Label label7;
    }
}