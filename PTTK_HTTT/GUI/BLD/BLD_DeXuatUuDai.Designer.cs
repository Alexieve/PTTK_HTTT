namespace GUI
{
    partial class BLD_DeXuatUuDai
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            childFormPanel = new Panel();
            SaveBtn = new Button();
            dataGridView1 = new DataGridView();
            CheckBox = new DataGridViewCheckBoxColumn();
            TenDN = new DataGridViewTextBoxColumn();
            VTTuyenDung = new DataGridViewTextBoxColumn();
            SoLuongUV = new DataGridViewTextBoxColumn();
            NgayTD = new DataGridViewTextBoxColumn();
            ChienLuocUuDai = new DataGridViewTextBoxColumn();
            childFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // childFormPanel
            // 
            childFormPanel.Controls.Add(SaveBtn);
            childFormPanel.Controls.Add(dataGridView1);
            childFormPanel.Dock = DockStyle.Fill;
            childFormPanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            childFormPanel.Location = new Point(0, 0);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(1077, 721);
            childFormPanel.TabIndex = 7;
            // 
            // SaveBtn
            // 
            SaveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SaveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveBtn.Location = new Point(495, 672);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(94, 46);
            SaveBtn.TabIndex = 1;
            SaveBtn.Text = "Lưu";
            SaveBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CheckBox, TenDN, VTTuyenDung, SoLuongUV, NgayTD, ChienLuocUuDai });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1053, 654);
            dataGridView1.TabIndex = 0;
            // 
            // CheckBox
            // 
            CheckBox.FillWeight = 32.08556F;
            CheckBox.HeaderText = "";
            CheckBox.MinimumWidth = 6;
            CheckBox.Name = "CheckBox";
            CheckBox.Resizable = DataGridViewTriState.True;
            CheckBox.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // TenDN
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TenDN.DefaultCellStyle = dataGridViewCellStyle2;
            TenDN.FillWeight = 113.582878F;
            TenDN.HeaderText = "Tên Doanh Nghiệp";
            TenDN.MinimumWidth = 6;
            TenDN.Name = "TenDN";
            TenDN.ReadOnly = true;
            // 
            // VTTuyenDung
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            VTTuyenDung.DefaultCellStyle = dataGridViewCellStyle3;
            VTTuyenDung.FillWeight = 113.582878F;
            VTTuyenDung.HeaderText = "Vị Trí Tuyển Dụng";
            VTTuyenDung.MinimumWidth = 6;
            VTTuyenDung.Name = "VTTuyenDung";
            VTTuyenDung.ReadOnly = true;
            // 
            // SoLuongUV
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SoLuongUV.DefaultCellStyle = dataGridViewCellStyle4;
            SoLuongUV.FillWeight = 113.582878F;
            SoLuongUV.HeaderText = "Số Lượng Ứng Viên";
            SoLuongUV.MinimumWidth = 6;
            SoLuongUV.Name = "SoLuongUV";
            SoLuongUV.ReadOnly = true;
            // 
            // NgayTD
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            NgayTD.DefaultCellStyle = dataGridViewCellStyle5;
            NgayTD.FillWeight = 113.582878F;
            NgayTD.HeaderText = "Thời Gian Hợp Đồng";
            NgayTD.MinimumWidth = 6;
            NgayTD.Name = "NgayTD";
            NgayTD.ReadOnly = true;
            // 
            // ChienLuocUuDai
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ChienLuocUuDai.DefaultCellStyle = dataGridViewCellStyle6;
            ChienLuocUuDai.FillWeight = 113.582878F;
            ChienLuocUuDai.HeaderText = "Chiến Lược Ưu Đãi";
            ChienLuocUuDai.MinimumWidth = 6;
            ChienLuocUuDai.Name = "ChienLuocUuDai";
            ChienLuocUuDai.ReadOnly = true;
            // 
            // BLD_DeXuatUuDai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 721);
            Controls.Add(childFormPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BLD_DeXuatUuDai";
            Text = "Form1";
            childFormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel childFormPanel;
        private Button SaveBtn;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn CheckBox;
        private DataGridViewTextBoxColumn TenDN;
        private DataGridViewTextBoxColumn VTTuyenDung;
        private DataGridViewTextBoxColumn SoLuongUV;
        private DataGridViewTextBoxColumn NgayTD;
        private DataGridViewTextBoxColumn ChienLuocUuDai;
    }
}