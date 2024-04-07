namespace GUI
{
    partial class PhanHoiHS_DSHopDong
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
            HopDongTb = new DataGridView();
            MAHOPDONG = new DataGridViewTextBoxColumn();
            CB_VT = new DataGridViewTextBoxColumn();
            SOLUONG = new DataGridViewTextBoxColumn();
            NGAYKT = new DataGridViewTextBoxColumn();
            AccessBtn = new DataGridViewButtonColumn();
            ParentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HopDongTb).BeginInit();
            SuspendLayout();
            // 
            // ParentPanel
            // 
            ParentPanel.Controls.Add(HopDongTb);
            ParentPanel.Dock = DockStyle.Fill;
            ParentPanel.Font = new Font("Segoe UI", 12F);
            ParentPanel.Location = new Point(0, 0);
            ParentPanel.Name = "ParentPanel";
            ParentPanel.Size = new Size(1053, 594);
            ParentPanel.TabIndex = 0;
            // 
            // HopDongTb
            // 
            HopDongTb.AllowUserToAddRows = false;
            HopDongTb.AllowUserToDeleteRows = false;
            HopDongTb.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            HopDongTb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            HopDongTb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HopDongTb.Columns.AddRange(new DataGridViewColumn[] { MAHOPDONG, CB_VT, SOLUONG, NGAYKT, AccessBtn });
            HopDongTb.Dock = DockStyle.Fill;
            HopDongTb.Location = new Point(0, 0);
            HopDongTb.Name = "HopDongTb";
            HopDongTb.ReadOnly = true;
            HopDongTb.RowHeadersWidth = 51;
            HopDongTb.Size = new Size(1053, 594);
            HopDongTb.TabIndex = 9;
            HopDongTb.CellContentClick += HopDongTb_CellContentClick;
            // 
            // MAHOPDONG
            // 
            MAHOPDONG.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MAHOPDONG.HeaderText = "Mã Hợp Đồng";
            MAHOPDONG.MinimumWidth = 6;
            MAHOPDONG.Name = "MAHOPDONG";
            MAHOPDONG.ReadOnly = true;
            // 
            // CB_VT
            // 
            CB_VT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CB_VT.HeaderText = "Vị Trí Ứng Tuyển";
            CB_VT.MinimumWidth = 6;
            CB_VT.Name = "CB_VT";
            CB_VT.ReadOnly = true;
            // 
            // SOLUONG
            // 
            SOLUONG.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SOLUONG.HeaderText = "Số HS Cần Phản Hồi";
            SOLUONG.MinimumWidth = 6;
            SOLUONG.Name = "SOLUONG";
            SOLUONG.ReadOnly = true;
            // 
            // NGAYKT
            // 
            NGAYKT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NGAYKT.HeaderText = "Hạn Chót Phản Hồi";
            NGAYKT.MinimumWidth = 6;
            NGAYKT.Name = "NGAYKT";
            NGAYKT.ReadOnly = true;
            // 
            // AccessBtn
            // 
            AccessBtn.HeaderText = "V";
            AccessBtn.MinimumWidth = 6;
            AccessBtn.Name = "AccessBtn";
            AccessBtn.ReadOnly = true;
            AccessBtn.Width = 50;
            // 
            // PhanHoiHS_DSHopDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 594);
            Controls.Add(ParentPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PhanHoiHS_DSHopDong";
            Text = "BaiDangChoDuyet";
            ParentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HopDongTb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ParentPanel;
        private DataGridView HopDongTb;
        private DataGridViewTextBoxColumn MAHOPDONG;
        private DataGridViewTextBoxColumn CB_VT;
        private DataGridViewTextBoxColumn SOLUONG;
        private DataGridViewTextBoxColumn NGAYKT;
        private DataGridViewButtonColumn AccessBtn;
    }
}