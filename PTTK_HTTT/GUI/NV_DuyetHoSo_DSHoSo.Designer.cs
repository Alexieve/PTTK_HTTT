namespace GUI
{
    partial class NV_DuyetHoSo_DSHoSo
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
            ParentPanel = new Panel();
            panel1 = new Panel();
            SaveBtn = new Button();
            SortLabel = new Label();
            DownBtn = new Button();
            UpBtn = new Button();
            KetQuaLabel = new Label();
            KetQuaCbb = new ComboBox();
            HoSoTb = new DataGridView();
            MAUV = new DataGridViewTextBoxColumn();
            TENUV = new DataGridViewTextBoxColumn();
            NGAYNOP = new DataGridViewTextBoxColumn();
            KETQUA = new DataGridViewTextBoxColumn();
            AccessBtn = new DataGridViewButtonColumn();
            ParentPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HoSoTb).BeginInit();
            SuspendLayout();
            // 
            // ParentPanel
            // 
            ParentPanel.Controls.Add(panel1);
            ParentPanel.Controls.Add(HoSoTb);
            ParentPanel.Dock = DockStyle.Fill;
            ParentPanel.Font = new Font("Segoe UI", 12F);
            ParentPanel.Location = new Point(0, 0);
            ParentPanel.Name = "ParentPanel";
            ParentPanel.Size = new Size(1053, 594);
            ParentPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(SaveBtn);
            panel1.Controls.Add(SortLabel);
            panel1.Controls.Add(DownBtn);
            panel1.Controls.Add(UpBtn);
            panel1.Controls.Add(KetQuaLabel);
            panel1.Controls.Add(KetQuaCbb);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 52);
            panel1.TabIndex = 10;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.SteelBlue;
            SaveBtn.FlatAppearance.BorderColor = Color.White;
            SaveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.Location = new Point(404, 8);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(94, 36);
            SaveBtn.TabIndex = 16;
            SaveBtn.Text = "Lưu";
            SaveBtn.UseVisualStyleBackColor = false;
            // 
            // SortLabel
            // 
            SortLabel.AutoSize = true;
            SortLabel.Location = new Point(12, 11);
            SortLabel.Name = "SortLabel";
            SortLabel.Size = new Size(186, 28);
            SortLabel.TabIndex = 15;
            SortLabel.Text = "Sắp Xếp Độ Ưu Tiên";
            // 
            // DownBtn
            // 
            DownBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DownBtn.Location = new Point(204, 8);
            DownBtn.Name = "DownBtn";
            DownBtn.Size = new Size(94, 36);
            DownBtn.TabIndex = 14;
            DownBtn.Text = "Giảm";
            DownBtn.UseVisualStyleBackColor = true;
            DownBtn.Click += DownBtn_Click;
            // 
            // UpBtn
            // 
            UpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpBtn.Location = new Point(304, 8);
            UpBtn.Name = "UpBtn";
            UpBtn.Size = new Size(94, 36);
            UpBtn.TabIndex = 13;
            UpBtn.Text = "Tăng";
            UpBtn.UseVisualStyleBackColor = true;
            UpBtn.Click += UpBtn_Click;
            // 
            // KetQuaLabel
            // 
            KetQuaLabel.AutoSize = true;
            KetQuaLabel.Location = new Point(651, 11);
            KetQuaLabel.Name = "KetQuaLabel";
            KetQuaLabel.Size = new Size(141, 28);
            KetQuaLabel.TabIndex = 12;
            KetQuaLabel.Text = "Kết Quả Hồ Sơ";
            // 
            // KetQuaCbb
            // 
            KetQuaCbb.DropDownStyle = ComboBoxStyle.DropDownList;
            KetQuaCbb.FormattingEnabled = true;
            KetQuaCbb.Location = new Point(798, 8);
            KetQuaCbb.Name = "KetQuaCbb";
            KetQuaCbb.Size = new Size(252, 36);
            KetQuaCbb.TabIndex = 11;
            KetQuaCbb.SelectedIndexChanged += KetQuaCbb_SelectedIndexChanged;
            // 
            // HoSoTb
            // 
            HoSoTb.AllowUserToAddRows = false;
            HoSoTb.AllowUserToDeleteRows = false;
            HoSoTb.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            HoSoTb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            HoSoTb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HoSoTb.Columns.AddRange(new DataGridViewColumn[] { MAUV, TENUV, NGAYNOP, KETQUA, AccessBtn });
            HoSoTb.Location = new Point(0, 58);
            HoSoTb.Name = "HoSoTb";
            HoSoTb.ReadOnly = true;
            HoSoTb.RowHeadersWidth = 51;
            HoSoTb.Size = new Size(1053, 536);
            HoSoTb.TabIndex = 9;
            HoSoTb.CellContentClick += HoSoTb_CellContentClick;
            // 
            // MAUV
            // 
            MAUV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MAUV.HeaderText = "Mã Ứng Viên";
            MAUV.MinimumWidth = 6;
            MAUV.Name = "MAUV";
            MAUV.ReadOnly = true;
            // 
            // TENUV
            // 
            TENUV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TENUV.HeaderText = "Tên Ứng Viên";
            TENUV.MinimumWidth = 6;
            TENUV.Name = "TENUV";
            TENUV.ReadOnly = true;
            // 
            // NGAYNOP
            // 
            NGAYNOP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NGAYNOP.HeaderText = "Ngày Nộp Hồ Sơ";
            NGAYNOP.MinimumWidth = 6;
            NGAYNOP.Name = "NGAYNOP";
            NGAYNOP.ReadOnly = true;
            // 
            // KETQUA
            // 
            KETQUA.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            KETQUA.HeaderText = "Kết Quả Hồ Sơ";
            KETQUA.MinimumWidth = 6;
            KETQUA.Name = "KETQUA";
            KETQUA.ReadOnly = true;
            // 
            // AccessBtn
            // 
            AccessBtn.HeaderText = "V";
            AccessBtn.MinimumWidth = 6;
            AccessBtn.Name = "AccessBtn";
            AccessBtn.ReadOnly = true;
            AccessBtn.Width = 50;
            // 
            // DuyetHoSo_DSHoSo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 594);
            Controls.Add(ParentPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DuyetHoSo_DSHoSo";
            Text = "HSChoDuyet";
            ParentPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HoSoTb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ParentPanel;
        private DataGridView HoSoTb;
        private Panel panel1;
        private ComboBox KetQuaCbb;
        private Label KetQuaLabel;
        private DataGridViewTextBoxColumn MAUV;
        private DataGridViewTextBoxColumn TENUV;
        private DataGridViewTextBoxColumn NGAYNOP;
        private DataGridViewTextBoxColumn KETQUA;
        private DataGridViewButtonColumn AccessBtn;
        private Button DownBtn;
        private Button UpBtn;
        private Label SortLabel;
        private Button SaveBtn;
    }
}