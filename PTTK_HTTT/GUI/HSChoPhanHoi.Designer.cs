﻿namespace GUI
{
    partial class HSChoPhanHoi
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
            KetQuaLabel = new Label();
            KetQuaCbb = new ComboBox();
            HoSoTb = new DataGridView();
            MAUV = new DataGridViewTextBoxColumn();
            TENUV = new DataGridViewTextBoxColumn();
            NGAYNOP = new DataGridViewTextBoxColumn();
            KETQUA = new DataGridViewTextBoxColumn();
            TitlePanel = new Panel();
            TitleLabel = new Label();
            ParentPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HoSoTb).BeginInit();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // ParentPanel
            // 
            ParentPanel.Controls.Add(panel1);
            ParentPanel.Controls.Add(HoSoTb);
            ParentPanel.Controls.Add(TitlePanel);
            ParentPanel.Dock = DockStyle.Fill;
            ParentPanel.Font = new Font("Segoe UI", 12F);
            ParentPanel.Location = new Point(0, 0);
            ParentPanel.Name = "ParentPanel";
            ParentPanel.Size = new Size(1077, 721);
            ParentPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(KetQuaLabel);
            panel1.Controls.Add(KetQuaCbb);
            panel1.Location = new Point(12, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 52);
            panel1.TabIndex = 10;
            // 
            // KetQuaLabel
            // 
            KetQuaLabel.AutoSize = true;
            KetQuaLabel.Location = new Point(654, 11);
            KetQuaLabel.Name = "KetQuaLabel";
            KetQuaLabel.Size = new Size(141, 28);
            KetQuaLabel.TabIndex = 12;
            KetQuaLabel.Text = "Kết Quả Hồ Sơ";
            // 
            // KetQuaCbb
            // 
            KetQuaCbb.DropDownStyle = ComboBoxStyle.DropDownList;
            KetQuaCbb.FormattingEnabled = true;
            KetQuaCbb.Location = new Point(801, 8);
            KetQuaCbb.Name = "KetQuaCbb";
            KetQuaCbb.Size = new Size(252, 36);
            KetQuaCbb.TabIndex = 11;
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
            HoSoTb.Columns.AddRange(new DataGridViewColumn[] { MAUV, TENUV, NGAYNOP, KETQUA });
            HoSoTb.Location = new Point(12, 135);
            HoSoTb.Name = "HoSoTb";
            HoSoTb.ReadOnly = true;
            HoSoTb.RowHeadersWidth = 51;
            HoSoTb.Size = new Size(1053, 574);
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
            // TitlePanel
            // 
            TitlePanel.BackColor = SystemColors.AppWorkspace;
            TitlePanel.BorderStyle = BorderStyle.Fixed3D;
            TitlePanel.Controls.Add(TitleLabel);
            TitlePanel.Location = new Point(12, 12);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(1053, 75);
            TitlePanel.TabIndex = 8;
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TitleLabel.Location = new Point(3, 17);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(672, 41);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "CÁC HỒ SƠ ỨNG TUYỂN CHO HỢP ĐỒNG ABC";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HSChoPhanHoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 721);
            Controls.Add(ParentPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HSChoPhanHoi";
            Text = "HSChoPhanHoi";
            ParentPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HoSoTb).EndInit();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ParentPanel;
        private Panel TitlePanel;
        private Label TitleLabel;
        private DataGridView HoSoTb;
        private DataGridViewTextBoxColumn MAUV;
        private DataGridViewTextBoxColumn TENUV;
        private DataGridViewTextBoxColumn NGAYNOP;
        private DataGridViewTextBoxColumn KETQUA;
        private Panel panel1;
        private ComboBox KetQuaCbb;
        private Label KetQuaLabel;
    }
}