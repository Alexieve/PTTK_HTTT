namespace GUI.DN
{
    partial class MultiSelect
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
            dtgviewLuaChon = new DataGridView();
            pnlTitle = new Panel();
            pnlTilte2 = new Panel();
            lbTitle = new Label();
            btnSave = new Button();
            groupBox1 = new GroupBox();
            dtgviewDaChon = new DataGridView();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dtgviewLuaChon).BeginInit();
            pnlTitle.SuspendLayout();
            pnlTilte2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgviewDaChon).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dtgviewLuaChon
            // 
            dtgviewLuaChon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgviewLuaChon.Location = new Point(6, 38);
            dtgviewLuaChon.Name = "dtgviewLuaChon";
            dtgviewLuaChon.RowHeadersWidth = 51;
            dtgviewLuaChon.Size = new Size(405, 289);
            dtgviewLuaChon.TabIndex = 0;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.MediumSeaGreen;
            pnlTitle.BorderStyle = BorderStyle.FixedSingle;
            pnlTitle.Controls.Add(pnlTilte2);
            pnlTitle.Location = new Point(12, 32);
            pnlTitle.Margin = new Padding(0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Padding = new Padding(7, 0, 0, 0);
            pnlTitle.Size = new Size(198, 61);
            pnlTitle.TabIndex = 29;
            // 
            // pnlTilte2
            // 
            pnlTilte2.BackColor = Color.White;
            pnlTilte2.Controls.Add(lbTitle);
            pnlTilte2.Dock = DockStyle.Fill;
            pnlTilte2.Location = new Point(7, 0);
            pnlTilte2.Name = "pnlTilte2";
            pnlTilte2.Size = new Size(189, 59);
            pnlTilte2.TabIndex = 7;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(0, 12);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(0, 31);
            lbTitle.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MediumSeaGreen;
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(748, 138);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 34);
            btnSave.TabIndex = 33;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgviewDaChon);
            groupBox1.Font = new Font("Segoe UI Semibold", 10F);
            groupBox1.Location = new Point(429, 143);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 333);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đã chọn";
            // 
            // dtgviewDaChon
            // 
            dtgviewDaChon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgviewDaChon.Location = new Point(8, 38);
            dtgviewDaChon.Name = "dtgviewDaChon";
            dtgviewDaChon.RowHeadersWidth = 51;
            dtgviewDaChon.Size = new Size(405, 289);
            dtgviewDaChon.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtgviewLuaChon);
            groupBox2.Font = new Font("Segoe UI Semibold", 10F);
            groupBox2.Location = new Point(12, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 333);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lựa chọn";
            // 
            // MultiSelect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 494);
            Controls.Add(btnSave);
            Controls.Add(pnlTitle);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MultiSelect";
            Text = "MultiSelect";
            ((System.ComponentModel.ISupportInitialize)dtgviewLuaChon).EndInit();
            pnlTitle.ResumeLayout(false);
            pnlTilte2.ResumeLayout(false);
            pnlTilte2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgviewDaChon).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgviewLuaChon;
        private Panel pnlTitle;
        private Panel pnlTilte2;
        private Label lbTitle;
        private Button btnSave;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dtgviewDaChon;
    }
}