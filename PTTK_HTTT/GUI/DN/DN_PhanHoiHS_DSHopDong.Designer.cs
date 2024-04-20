namespace GUI
{
    partial class DN_PhanHoiHS_DSHopDong
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
            XemDSHoSoBtn = new Button();
            HopDongTb = new DataGridView();
            MAHOPDONG = new DataGridViewTextBoxColumn();
            CB_VT = new DataGridViewTextBoxColumn();
            SOLUONG = new DataGridViewTextBoxColumn();
            NGAYKT = new DataGridViewTextBoxColumn();
            ParentPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HopDongTb).BeginInit();
            SuspendLayout();
            // 
            // ParentPanel
            // 
            ParentPanel.Controls.Add(panel1);
            ParentPanel.Controls.Add(HopDongTb);
            ParentPanel.Dock = DockStyle.Fill;
            ParentPanel.Font = new Font("Segoe UI", 12F);
            ParentPanel.Location = new Point(0, 0);
            ParentPanel.Name = "ParentPanel";
            ParentPanel.Size = new Size(1053, 594);
            ParentPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(XemDSHoSoBtn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 52);
            panel1.TabIndex = 11;
            // 
            // XemDSHoSoBtn
            // 
            XemDSHoSoBtn.Location = new Point(793, 8);
            XemDSHoSoBtn.Name = "XemDSHoSoBtn";
            XemDSHoSoBtn.Size = new Size(248, 37);
            XemDSHoSoBtn.TabIndex = 0;
            XemDSHoSoBtn.Text = "Xem Danh Sách Hồ Sơ";
            XemDSHoSoBtn.UseVisualStyleBackColor = true;
            XemDSHoSoBtn.Click += XemDSHoSoBtn_Click;
            // 
            // HopDongTb
            // 
            HopDongTb.AllowUserToAddRows = false;
            HopDongTb.AllowUserToDeleteRows = false;
            HopDongTb.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            HopDongTb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            HopDongTb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HopDongTb.Columns.AddRange(new DataGridViewColumn[] { MAHOPDONG, CB_VT, SOLUONG, NGAYKT });
            HopDongTb.Location = new Point(0, 58);
            HopDongTb.Name = "HopDongTb";
            HopDongTb.ReadOnly = true;
            HopDongTb.RowHeadersWidth = 51;
            HopDongTb.Size = new Size(1053, 536);
            HopDongTb.TabIndex = 9;
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
            // DN_PhanHoiHS_DSHopDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 594);
            Controls.Add(ParentPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DN_PhanHoiHS_DSHopDong";
            Text = "BaiDangChoDuyet";
            ParentPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HopDongTb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ParentPanel;
        private DataGridView HopDongTb;
        private Panel panel1;
        private Button XemDSHoSoBtn;
        private DataGridViewTextBoxColumn MAHOPDONG;
        private DataGridViewTextBoxColumn CB_VT;
        private DataGridViewTextBoxColumn SOLUONG;
        private DataGridViewTextBoxColumn NGAYKT;
    }
}