namespace GUI
{
    partial class PhanHoiHSTab
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
            ParentPanel = new Panel();
            TablePanel = new Panel();
            TabPanel = new TableLayoutPanel();
            HopDongPanel = new Panel();
            HopDongBtn = new Button();
            HoSoPanel = new Panel();
            HoSoBtn = new Button();
            TitlePanel = new Panel();
            TitleLabel = new Label();
            tabtbLout = new TableLayoutPanel();
            pnlXnpqc = new Panel();
            btnXnpqc = new Button();
            pnlLtgvht = new Panel();
            btnLtgvht = new Button();
            ParentPanel.SuspendLayout();
            TabPanel.SuspendLayout();
            HopDongPanel.SuspendLayout();
            HoSoPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            tabtbLout.SuspendLayout();
            pnlXnpqc.SuspendLayout();
            pnlLtgvht.SuspendLayout();
            SuspendLayout();
            // 
            // ParentPanel
            // 
            ParentPanel.Controls.Add(TablePanel);
            ParentPanel.Controls.Add(TabPanel);
            ParentPanel.Controls.Add(TitlePanel);
            ParentPanel.Dock = DockStyle.Fill;
            ParentPanel.Font = new Font("Segoe UI", 12F);
            ParentPanel.Location = new Point(0, 0);
            ParentPanel.Name = "ParentPanel";
            ParentPanel.Size = new Size(1077, 721);
            ParentPanel.TabIndex = 0;
            // 
            // TablePanel
            // 
            TablePanel.Location = new Point(12, 115);
            TablePanel.Name = "TablePanel";
            TablePanel.Size = new Size(1053, 594);
            TablePanel.TabIndex = 11;
            // 
            // TabPanel
            // 
            TabPanel.BackColor = SystemColors.ControlLight;
            TabPanel.ColumnCount = 2;
            TabPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TabPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TabPanel.Controls.Add(HopDongPanel, 0, 0);
            TabPanel.Controls.Add(HoSoPanel, 1, 0);
            TabPanel.Location = new Point(0, 54);
            TabPanel.Name = "TabPanel";
            TabPanel.RowCount = 1;
            TabPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TabPanel.Size = new Size(1077, 55);
            TabPanel.TabIndex = 10;
            // 
            // HopDongPanel
            // 
            HopDongPanel.BackColor = Color.MediumSeaGreen;
            HopDongPanel.Controls.Add(HopDongBtn);
            HopDongPanel.Dock = DockStyle.Fill;
            HopDongPanel.Location = new Point(3, 3);
            HopDongPanel.Name = "HopDongPanel";
            HopDongPanel.Size = new Size(532, 49);
            HopDongPanel.TabIndex = 0;
            // 
            // HopDongBtn
            // 
            HopDongBtn.BackColor = SystemColors.ControlLight;
            HopDongBtn.FlatAppearance.BorderSize = 0;
            HopDongBtn.FlatStyle = FlatStyle.Flat;
            HopDongBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HopDongBtn.Location = new Point(0, -2);
            HopDongBtn.Name = "HopDongBtn";
            HopDongBtn.Size = new Size(532, 42);
            HopDongBtn.TabIndex = 0;
            HopDongBtn.Text = "Danh Sách Hợp Đồng";
            HopDongBtn.UseVisualStyleBackColor = false;
            HopDongBtn.Click += HopDongBtn_Click;
            // 
            // HoSoPanel
            // 
            HoSoPanel.BackColor = Color.DarkGray;
            HoSoPanel.Controls.Add(HoSoBtn);
            HoSoPanel.Dock = DockStyle.Fill;
            HoSoPanel.Location = new Point(541, 3);
            HoSoPanel.Name = "HoSoPanel";
            HoSoPanel.Size = new Size(533, 49);
            HoSoPanel.TabIndex = 1;
            // 
            // HoSoBtn
            // 
            HoSoBtn.BackColor = SystemColors.ControlLight;
            HoSoBtn.FlatAppearance.BorderSize = 0;
            HoSoBtn.FlatStyle = FlatStyle.Flat;
            HoSoBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HoSoBtn.Location = new Point(0, -2);
            HoSoBtn.Name = "HoSoBtn";
            HoSoBtn.Size = new Size(533, 42);
            HoSoBtn.TabIndex = 1;
            HoSoBtn.Text = "Danh Sách Hồ Sơ";
            HoSoBtn.UseVisualStyleBackColor = false;
            HoSoBtn.Click += HoSoBtn_Click;
            // 
            // TitlePanel
            // 
            TitlePanel.BackColor = Color.Gray;
            TitlePanel.BorderStyle = BorderStyle.Fixed3D;
            TitlePanel.Controls.Add(TitleLabel);
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(1077, 56);
            TitlePanel.TabIndex = 8;
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            TitleLabel.ForeColor = SystemColors.Control;
            TitleLabel.Location = new Point(404, 7);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(305, 31);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Phản Hồi Hồ Sơ Ứng Tuyển";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabtbLout
            // 
            tabtbLout.BackColor = Color.Silver;
            tabtbLout.ColumnCount = 3;
            tabtbLout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tabtbLout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tabtbLout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tabtbLout.Controls.Add(pnlXnpqc, 2, 0);
            tabtbLout.Location = new Point(0, 0);
            tabtbLout.Name = "tabtbLout";
            tabtbLout.RowCount = 1;
            tabtbLout.Size = new Size(200, 100);
            tabtbLout.TabIndex = 0;
            // 
            // pnlXnpqc
            // 
            pnlXnpqc.BackColor = Color.Silver;
            pnlXnpqc.Controls.Add(btnXnpqc);
            pnlXnpqc.Dock = DockStyle.Fill;
            pnlXnpqc.Location = new Point(137, 5);
            pnlXnpqc.Margin = new Padding(5);
            pnlXnpqc.Name = "pnlXnpqc";
            pnlXnpqc.Padding = new Padding(0, 0, 0, 5);
            pnlXnpqc.Size = new Size(58, 90);
            pnlXnpqc.TabIndex = 2;
            // 
            // btnXnpqc
            // 
            btnXnpqc.BackColor = Color.Silver;
            btnXnpqc.Dock = DockStyle.Fill;
            btnXnpqc.FlatAppearance.BorderSize = 0;
            btnXnpqc.FlatStyle = FlatStyle.Flat;
            btnXnpqc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXnpqc.ForeColor = SystemColors.GrayText;
            btnXnpqc.Location = new Point(0, 0);
            btnXnpqc.Margin = new Padding(0);
            btnXnpqc.Name = "btnXnpqc";
            btnXnpqc.Size = new Size(58, 85);
            btnXnpqc.TabIndex = 2;
            btnXnpqc.Text = "Xác nhận phiếu quảng cáo";
            btnXnpqc.UseVisualStyleBackColor = false;
            // 
            // pnlLtgvht
            // 
            pnlLtgvht.BackColor = Color.Silver;
            pnlLtgvht.Controls.Add(btnLtgvht);
            pnlLtgvht.Dock = DockStyle.Fill;
            pnlLtgvht.Location = new Point(5, 5);
            pnlLtgvht.Margin = new Padding(5);
            pnlLtgvht.Name = "pnlLtgvht";
            pnlLtgvht.Padding = new Padding(0, 0, 0, 5);
            pnlLtgvht.Size = new Size(200, 200);
            pnlLtgvht.TabIndex = 1;
            // 
            // btnLtgvht
            // 
            btnLtgvht.BackColor = Color.Silver;
            btnLtgvht.Dock = DockStyle.Fill;
            btnLtgvht.FlatAppearance.BorderSize = 0;
            btnLtgvht.FlatStyle = FlatStyle.Flat;
            btnLtgvht.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLtgvht.ForeColor = SystemColors.GrayText;
            btnLtgvht.Location = new Point(0, 0);
            btnLtgvht.Margin = new Padding(0);
            btnLtgvht.Name = "btnLtgvht";
            btnLtgvht.Size = new Size(200, 195);
            btnLtgvht.TabIndex = 3;
            btnLtgvht.Text = "Lấy thời gian và hình thức đăng tuyển";
            btnLtgvht.UseVisualStyleBackColor = false;
            // 
            // PhanHoiHSTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 721);
            Controls.Add(ParentPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PhanHoiHSTab";
            Text = "BaiDangChoDuyet";
            ParentPanel.ResumeLayout(false);
            TabPanel.ResumeLayout(false);
            HopDongPanel.ResumeLayout(false);
            HoSoPanel.ResumeLayout(false);
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            tabtbLout.ResumeLayout(false);
            pnlXnpqc.ResumeLayout(false);
            pnlLtgvht.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel ParentPanel;
        private Panel TitlePanel;
        private Label TitleLabel;
        private TableLayoutPanel TabPanel;
        private TableLayoutPanel tabtbLout;
        private Panel pnlXnpqc;
        private Button btnXnpqc;
        private Panel pnlLtgvht;
        private Button btnLtgvht;
        private Panel HopDongPanel;
        private Panel HoSoPanel;
        private Button HopDongBtn;
        private Button HoSoBtn;
        private Panel TablePanel;
    }
}