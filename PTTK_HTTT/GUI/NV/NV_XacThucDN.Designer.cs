namespace GUI
{
    partial class NV_XacThucDN
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            ParentPanel = new Panel();
            panel2 = new Panel();
            TuChoiBtn = new Button();
            XacNhanBtn = new Button();
            XemCTBtn = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            DNTb = new DataGridView();
            MADN = new DataGridViewTextBoxColumn();
            TenDN = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            MADNBox = new TextBox();
            label7 = new Label();
            EmailBox = new TextBox();
            SDTBox = new TextBox();
            DiaChiBox = new TextBox();
            NGDaiDienBox = new TextBox();
            MAThueBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TenDNBox = new TextBox();
            TittlePanel = new Panel();
            TitleLabel = new Label();
            ParentPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DNTb).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            TittlePanel.SuspendLayout();
            SuspendLayout();
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
            ParentPanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(TuChoiBtn);
            panel2.Controls.Add(XacNhanBtn);
            panel2.Controls.Add(XemCTBtn);
            panel2.Location = new Point(0, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(1077, 45);
            panel2.TabIndex = 2;
            // 
            // TuChoiBtn
            // 
            TuChoiBtn.Location = new Point(763, 0);
            TuChoiBtn.Name = "TuChoiBtn";
            TuChoiBtn.Size = new Size(148, 45);
            TuChoiBtn.TabIndex = 2;
            TuChoiBtn.Text = "Từ Chối";
            TuChoiBtn.UseVisualStyleBackColor = true;
            TuChoiBtn.Click += TuChoiBtn_Click;
            // 
            // XacNhanBtn
            // 
            XacNhanBtn.Location = new Point(917, 0);
            XacNhanBtn.Name = "XacNhanBtn";
            XacNhanBtn.Size = new Size(148, 45);
            XacNhanBtn.TabIndex = 1;
            XacNhanBtn.Text = "Xác Nhận";
            XacNhanBtn.UseVisualStyleBackColor = true;
            XacNhanBtn.Click += XacNhanBtn_Click;
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(DNTb, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1053, 569);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // DNTb
            // 
            DNTb.AllowUserToAddRows = false;
            DNTb.AllowUserToDeleteRows = false;
            DNTb.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DNTb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DNTb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DNTb.Columns.AddRange(new DataGridViewColumn[] { MADN, TenDN });
            DNTb.Location = new Point(3, 3);
            DNTb.Name = "DNTb";
            DNTb.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            DNTb.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            DNTb.RowHeadersWidth = 51;
            DNTb.Size = new Size(520, 563);
            DNTb.TabIndex = 2;
            // 
            // MADN
            // 
            MADN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MADN.DefaultCellStyle = dataGridViewCellStyle6;
            MADN.HeaderText = "Mã Doanh Nghiệp";
            MADN.MinimumWidth = 6;
            MADN.Name = "MADN";
            MADN.ReadOnly = true;
            // 
            // TenDN
            // 
            TenDN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            TenDN.DefaultCellStyle = dataGridViewCellStyle7;
            TenDN.HeaderText = "Tên Doanh Nghiệp";
            TenDN.MinimumWidth = 6;
            TenDN.Name = "TenDN";
            TenDN.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel2.Controls.Add(MADNBox, 1, 0);
            tableLayoutPanel2.Controls.Add(label7, 0, 0);
            tableLayoutPanel2.Controls.Add(EmailBox, 1, 6);
            tableLayoutPanel2.Controls.Add(SDTBox, 1, 5);
            tableLayoutPanel2.Controls.Add(DiaChiBox, 1, 4);
            tableLayoutPanel2.Controls.Add(NGDaiDienBox, 1, 3);
            tableLayoutPanel2.Controls.Add(MAThueBox, 1, 2);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(label3, 0, 3);
            tableLayoutPanel2.Controls.Add(label4, 0, 4);
            tableLayoutPanel2.Controls.Add(label5, 0, 5);
            tableLayoutPanel2.Controls.Add(label6, 0, 6);
            tableLayoutPanel2.Controls.Add(TenDNBox, 1, 1);
            tableLayoutPanel2.Location = new Point(529, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.26F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(520, 563);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // MADNBox
            // 
            MADNBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MADNBox.Location = new Point(136, 24);
            MADNBox.Name = "MADNBox";
            MADNBox.ReadOnly = true;
            MADNBox.Size = new Size(378, 34);
            MADNBox.TabIndex = 7;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(6, 13);
            label7.Name = "label7";
            label7.Size = new Size(121, 56);
            label7.TabIndex = 1;
            label7.Text = "Mã Doanh Nghiệp";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EmailBox
            // 
            EmailBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EmailBox.Location = new Point(136, 504);
            EmailBox.Name = "EmailBox";
            EmailBox.ReadOnly = true;
            EmailBox.Size = new Size(378, 34);
            EmailBox.TabIndex = 11;
            // 
            // SDTBox
            // 
            SDTBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SDTBox.Location = new Point(136, 424);
            SDTBox.Name = "SDTBox";
            SDTBox.ReadOnly = true;
            SDTBox.Size = new Size(378, 34);
            SDTBox.TabIndex = 10;
            // 
            // DiaChiBox
            // 
            DiaChiBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DiaChiBox.Location = new Point(136, 344);
            DiaChiBox.Name = "DiaChiBox";
            DiaChiBox.Size = new Size(378, 34);
            DiaChiBox.TabIndex = 9;
            // 
            // NGDaiDienBox
            // 
            NGDaiDienBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NGDaiDienBox.Location = new Point(136, 264);
            NGDaiDienBox.Name = "NGDaiDienBox";
            NGDaiDienBox.Size = new Size(378, 34);
            NGDaiDienBox.TabIndex = 8;
            // 
            // MAThueBox
            // 
            MAThueBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MAThueBox.Location = new Point(136, 184);
            MAThueBox.Name = "MAThueBox";
            MAThueBox.Size = new Size(378, 34);
            MAThueBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(6, 93);
            label1.Name = "label1";
            label1.Size = new Size(121, 56);
            label1.TabIndex = 0;
            label1.Text = "Tên Doanh Nghiệp";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(6, 187);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 1;
            label2.Text = "Mã số Thuế";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(6, 253);
            label3.Name = "label3";
            label3.Size = new Size(121, 56);
            label3.TabIndex = 2;
            label3.Text = "Người Đại Diện";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(6, 347);
            label4.Name = "label4";
            label4.Size = new Size(121, 28);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(6, 413);
            label5.Name = "label5";
            label5.Size = new Size(121, 56);
            label5.TabIndex = 4;
            label5.Text = "Số Điện Thoại";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(6, 507);
            label6.Name = "label6";
            label6.Size = new Size(121, 28);
            label6.TabIndex = 5;
            label6.Text = "Email";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TenDNBox
            // 
            TenDNBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TenDNBox.Location = new Point(136, 104);
            TenDNBox.Name = "TenDNBox";
            TenDNBox.Size = new Size(378, 34);
            TenDNBox.TabIndex = 6;
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
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = SystemColors.Control;
            TitleLabel.Location = new Point(177, 19);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(718, 46);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Xác Thực Thông Tin Đăng Ký Doanh Nghiệp";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NV_XacThucDN
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 721);
            Controls.Add(ParentPanel);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NV_XacThucDN";
            Text = "Xác thực đăng ký doanh nghiệp";
            ParentPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DNTb).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            TittlePanel.ResumeLayout(false);
            TittlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ParentPanel;
        private Panel TittlePanel;
        private Panel panel2;
        private Button XemCTBtn;
        private Panel panel1;
        private Label TitleLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox EmailBox;
        private TextBox SDTBox;
        private TextBox DiaChiBox;
        private TextBox NGDaiDienBox;
        private TextBox MAThueBox;
        private TextBox TenDNBox;
        private DataGridView DNTb;
        private TextBox MADNBox;
        private Label label7;
        private DataGridViewTextBoxColumn MADN;
        private DataGridViewTextBoxColumn TenDN;
        private Button TuChoiBtn;
        private Button XacNhanBtn;
    }
}