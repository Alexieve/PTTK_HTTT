namespace GUI
{
    partial class GiaHanHopDong
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
            GiaHan = new Button();
            dataGridView1 = new DataGridView();
            MaDN = new DataGridViewCheckBoxColumn();
            TenDN = new DataGridViewTextBoxColumn();
            SoLuongUV = new DataGridViewTextBoxColumn();
            SoLuongViTri = new DataGridViewTextBoxColumn();
            NgayTD = new DataGridViewTextBoxColumn();
            ChienLuocUuDai = new DataGridViewTextBoxColumn();
            childFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // childFormPanel
            // 
            childFormPanel.Controls.Add(GiaHan);
            childFormPanel.Controls.Add(dataGridView1);
            childFormPanel.Font = new Font("Segoe UI", 12F);
            childFormPanel.Location = new Point(-2, 0);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(1077, 729);
            childFormPanel.TabIndex = 7;
            // 
            // GiaHan
            // 
            GiaHan.Location = new Point(491, 672);
            GiaHan.Name = "GiaHan";
            GiaHan.Size = new Size(94, 46);
            GiaHan.TabIndex = 1;
            GiaHan.Text = "Gia hạn";
            GiaHan.UseVisualStyleBackColor = true;
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
            dataGridView1.Size = new Size(1077, 666);
            dataGridView1.TabIndex = 0;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 721);
            Controls.Add(childFormPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            childFormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel childFormPanel;
        private Button GiaHan;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn MaDN;
        private DataGridViewTextBoxColumn TenDN;
        private DataGridViewTextBoxColumn SoLuongUV;
        private DataGridViewTextBoxColumn SoLuongViTri;
        private DataGridViewTextBoxColumn NgayTD;
        private DataGridViewTextBoxColumn ChienLuocUuDai;
    }
}