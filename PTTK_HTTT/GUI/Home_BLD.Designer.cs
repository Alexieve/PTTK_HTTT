namespace GUI
{
    partial class Home_BLD
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
            childFormPanel = new Panel();
            sidePanel = new FlowLayoutPanel();
            panel1 = new Panel();
            usernameLabel = new Label();
            logoutBtn = new Button();
            panel2 = new Panel();
            ThongKeBtn = new Button();
            panel3 = new Panel();
            XacThucHSBtn = new Button();
            panel4 = new Panel();
            ThanhToanBtn = new Button();
            panel5 = new Panel();
            DuyetHSBtn = new Button();
            panel6 = new Panel();
            GiaHanHDBtn = new Button();
            dataGridView1 = new DataGridView();
            MaDN = new DataGridViewCheckBoxColumn();
            TenDN = new DataGridViewTextBoxColumn();
            SoLuongUV = new DataGridViewTextBoxColumn();
            SoLuongViTri = new DataGridViewTextBoxColumn();
            NgayTD = new DataGridViewTextBoxColumn();
            ChienLuocUuDai = new DataGridViewTextBoxColumn();
            childFormPanel.SuspendLayout();
            sidePanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // childFormPanel
            // 
            childFormPanel.Controls.Add(dataGridView1);
            childFormPanel.Font = new Font("Segoe UI", 12F);
            childFormPanel.Location = new Point(272, 0);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(1077, 721);
            childFormPanel.TabIndex = 6;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(64, 64, 64);
            sidePanel.Controls.Add(panel1);
            sidePanel.Controls.Add(panel2);
            sidePanel.Controls.Add(panel3);
            sidePanel.Controls.Add(panel4);
            sidePanel.Controls.Add(panel5);
            sidePanel.Controls.Add(panel6);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(269, 721);
            sidePanel.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(logoutBtn);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 116);
            panel1.TabIndex = 0;
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            usernameLabel.BackColor = Color.Gray;
            usernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = SystemColors.ControlLightLight;
            usernameLabel.ImageAlign = ContentAlignment.MiddleLeft;
            usernameLabel.Location = new Point(0, 33);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(263, 20);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "USERNAME";
            usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoutBtn
            // 
            logoutBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            logoutBtn.BackColor = SystemColors.ButtonHighlight;
            logoutBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            logoutBtn.Location = new Point(83, 69);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(94, 29);
            logoutBtn.TabIndex = 0;
            logoutBtn.Text = "Đăng xuất";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(ThongKeBtn);
            panel2.Location = new Point(3, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 112);
            panel2.TabIndex = 1;
            // 
            // ThongKeBtn
            // 
            ThongKeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ThongKeBtn.FlatAppearance.BorderSize = 0;
            ThongKeBtn.FlatStyle = FlatStyle.Flat;
            ThongKeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ThongKeBtn.ForeColor = Color.White;
            ThongKeBtn.Location = new Point(0, 3);
            ThongKeBtn.Name = "ThongKeBtn";
            ThongKeBtn.Size = new Size(263, 106);
            ThongKeBtn.TabIndex = 0;
            ThongKeBtn.Text = "Thống Kê Doanh Nghiệp\r\nTiềm Năng";
            ThongKeBtn.UseVisualStyleBackColor = true;
            ThongKeBtn.Click += ThongKeBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(XacThucHSBtn);
            panel3.Location = new Point(3, 243);
            panel3.Name = "panel3";
            panel3.Size = new Size(263, 112);
            panel3.TabIndex = 2;
            // 
            // XacThucHSBtn
            // 
            XacThucHSBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            XacThucHSBtn.FlatAppearance.BorderSize = 0;
            XacThucHSBtn.FlatStyle = FlatStyle.Flat;
            XacThucHSBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            XacThucHSBtn.ForeColor = Color.White;
            XacThucHSBtn.Location = new Point(0, 3);
            XacThucHSBtn.Name = "XacThucHSBtn";
            XacThucHSBtn.Size = new Size(263, 106);
            XacThucHSBtn.TabIndex = 0;
            XacThucHSBtn.Text = "Temporary";
            XacThucHSBtn.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(ThanhToanBtn);
            panel4.Location = new Point(3, 361);
            panel4.Name = "panel4";
            panel4.Size = new Size(263, 112);
            panel4.TabIndex = 3;
            // 
            // ThanhToanBtn
            // 
            ThanhToanBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ThanhToanBtn.FlatAppearance.BorderSize = 0;
            ThanhToanBtn.FlatStyle = FlatStyle.Flat;
            ThanhToanBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ThanhToanBtn.ForeColor = Color.White;
            ThanhToanBtn.Location = new Point(0, 3);
            ThanhToanBtn.Name = "ThanhToanBtn";
            ThanhToanBtn.Size = new Size(263, 106);
            ThanhToanBtn.TabIndex = 0;
            ThanhToanBtn.Text = "Temporary";
            ThanhToanBtn.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(DuyetHSBtn);
            panel5.Location = new Point(3, 479);
            panel5.Name = "panel5";
            panel5.Size = new Size(263, 112);
            panel5.TabIndex = 3;
            // 
            // DuyetHSBtn
            // 
            DuyetHSBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DuyetHSBtn.FlatAppearance.BorderSize = 0;
            DuyetHSBtn.FlatStyle = FlatStyle.Flat;
            DuyetHSBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DuyetHSBtn.ForeColor = Color.White;
            DuyetHSBtn.Location = new Point(0, 3);
            DuyetHSBtn.Name = "DuyetHSBtn";
            DuyetHSBtn.Size = new Size(263, 106);
            DuyetHSBtn.TabIndex = 0;
            DuyetHSBtn.Text = "Temporary";
            DuyetHSBtn.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(GiaHanHDBtn);
            panel6.Location = new Point(3, 597);
            panel6.Name = "panel6";
            panel6.Size = new Size(263, 112);
            panel6.TabIndex = 3;
            // 
            // GiaHanHDBtn
            // 
            GiaHanHDBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GiaHanHDBtn.FlatAppearance.BorderSize = 0;
            GiaHanHDBtn.FlatStyle = FlatStyle.Flat;
            GiaHanHDBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            GiaHanHDBtn.ForeColor = Color.White;
            GiaHanHDBtn.Location = new Point(0, 3);
            GiaHanHDBtn.Name = "GiaHanHDBtn";
            GiaHanHDBtn.Size = new Size(263, 106);
            GiaHanHDBtn.TabIndex = 0;
            GiaHanHDBtn.Text = "Temporary";
            GiaHanHDBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaDN, TenDN, SoLuongUV, SoLuongViTri, NgayTD, ChienLuocUuDai });
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1089, 718);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MaDN
            // 
            MaDN.FillWeight = 32.08556F;
            MaDN.HeaderText = "";
            MaDN.MinimumWidth = 6;
            MaDN.Name = "MaDN";
            MaDN.ReadOnly = true;
            MaDN.Resizable = DataGridViewTriState.True;
            MaDN.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // TenDN
            // 
            TenDN.FillWeight = 113.582878F;
            TenDN.HeaderText = "Tên Doanh Nghiệp";
            TenDN.MinimumWidth = 6;
            TenDN.Name = "TenDN";
            TenDN.ReadOnly = true;
            // 
            // SoLuongUV
            // 
            SoLuongUV.FillWeight = 113.582878F;
            SoLuongUV.HeaderText = "Số Lượng Ứng Viên";
            SoLuongUV.MinimumWidth = 6;
            SoLuongUV.Name = "SoLuongUV";
            SoLuongUV.ReadOnly = true;
            // 
            // SoLuongViTri
            // 
            SoLuongViTri.FillWeight = 113.582878F;
            SoLuongViTri.HeaderText = "Số Lượng Vị Trí";
            SoLuongViTri.MinimumWidth = 6;
            SoLuongViTri.Name = "SoLuongViTri";
            SoLuongViTri.ReadOnly = true;
            // 
            // NgayTD
            // 
            NgayTD.FillWeight = 113.582878F;
            NgayTD.HeaderText = "Thời Gian Hợp Đồng";
            NgayTD.MinimumWidth = 6;
            NgayTD.Name = "NgayTD";
            NgayTD.ReadOnly = true;
            // 
            // ChienLuocUuDai
            // 
            ChienLuocUuDai.FillWeight = 113.582878F;
            ChienLuocUuDai.HeaderText = "Chiến Lược Ưu Đãi";
            ChienLuocUuDai.MinimumWidth = 6;
            ChienLuocUuDai.Name = "ChienLuocUuDai";
            ChienLuocUuDai.ReadOnly = true;
            // 
            // Home_BLD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(childFormPanel);
            Controls.Add(sidePanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Home_BLD";
            Text = "Trang Chủ";
            childFormPanel.ResumeLayout(false);
            sidePanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel childFormPanel;
        private FlowLayoutPanel sidePanel;
        private Panel panel1;
        private Label usernameLabel;
        private Button logoutBtn;
        private Panel panel2;
        private Button ThongKeBtn;
        private Panel panel3;
        private Button XacThucHSBtn;
        private Panel panel4;
        private Button ThanhToanBtn;
        private Panel panel5;
        private Button DuyetHSBtn;
        private Panel panel6;
        private Button GiaHanHDBtn;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn MaDN;
        private DataGridViewTextBoxColumn TenDN;
        private DataGridViewTextBoxColumn SoLuongUV;
        private DataGridViewTextBoxColumn SoLuongViTri;
        private DataGridViewTextBoxColumn NgayTD;
        private DataGridViewTextBoxColumn ChienLuocUuDai;
    }
}