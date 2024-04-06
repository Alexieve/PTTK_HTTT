namespace GUI
{
    partial class TraCuuHopDong
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
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            GrantPrivTable = new DataGridView();
            TableNameCol = new DataGridViewTextBoxColumn();
            ICol = new DataGridViewTextBoxColumn();
            SCol = new DataGridViewTextBoxColumn();
            UCol = new DataGridViewTextBoxColumn();
            DCol = new DataGridViewTextBoxColumn();
            button4 = new Button();
            childFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GrantPrivTable).BeginInit();
            SuspendLayout();
            // 
            // childFormPanel
            // 
            childFormPanel.Controls.Add(button4);
            childFormPanel.Controls.Add(label3);
            childFormPanel.Controls.Add(button1);
            childFormPanel.Controls.Add(button2);
            childFormPanel.Controls.Add(btnSearch);
            childFormPanel.Controls.Add(txtSearch);
            childFormPanel.Controls.Add(label1);
            childFormPanel.Controls.Add(GrantPrivTable);
            childFormPanel.Font = new Font("Segoe UI", 12F);
            childFormPanel.Location = new Point(0, 0);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(1077, 721);
            childFormPanel.TabIndex = 8;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1077, 52);
            label3.TabIndex = 5;
            label3.Text = "Danh sách Hợp đồng";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(77, 652);
            button1.Name = "button1";
            button1.Size = new Size(157, 40);
            button1.TabIndex = 11;
            button1.Text = "Xem chi tiết";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(429, 652);
            button2.Name = "button2";
            button2.Size = new Size(177, 40);
            button2.TabIndex = 9;
            button2.Text = "Xem bài đăng";
            button2.Click += button2_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(413, 114);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(132, 40);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(173, 119);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 34);
            txtSearch.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 122);
            label1.Name = "label1";
            label1.Size = new Size(150, 28);
            label1.TabIndex = 7;
            label1.Text = "MAHOPDONG: ";
            // 
            // GrantPrivTable
            // 
            GrantPrivTable.AllowUserToAddRows = false;
            GrantPrivTable.AllowUserToDeleteRows = false;
            GrantPrivTable.Anchor = AnchorStyles.Bottom;
            GrantPrivTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrantPrivTable.Columns.AddRange(new DataGridViewColumn[] { TableNameCol, ICol, SCol, UCol, DCol });
            GrantPrivTable.Location = new Point(10, 188);
            GrantPrivTable.Name = "GrantPrivTable";
            GrantPrivTable.RowHeadersWidth = 51;
            GrantPrivTable.Size = new Size(1053, 442);
            GrantPrivTable.TabIndex = 4;
            // 
            // TableNameCol
            // 
            TableNameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TableNameCol.HeaderText = "MAHOPDONG";
            TableNameCol.MinimumWidth = 6;
            TableNameCol.Name = "TableNameCol";
            TableNameCol.ReadOnly = true;
            // 
            // ICol
            // 
            ICol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ICol.HeaderText = "NGAYTD";
            ICol.MinimumWidth = 6;
            ICol.Name = "ICol";
            ICol.ReadOnly = true;
            // 
            // SCol
            // 
            SCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SCol.HeaderText = "SOLUONGTD";
            SCol.MinimumWidth = 6;
            SCol.Name = "SCol";
            SCol.ReadOnly = true;
            // 
            // UCol
            // 
            UCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UCol.HeaderText = "TONGTIEN";
            UCol.MinimumWidth = 6;
            UCol.Name = "UCol";
            UCol.ReadOnly = true;
            // 
            // DCol
            // 
            DCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DCol.HeaderText = "TIENCONLAI";
            DCol.MinimumWidth = 6;
            DCol.Name = "DCol";
            DCol.ReadOnly = true;
            DCol.Resizable = DataGridViewTriState.True;
            // 
            // button4
            // 
            button4.Location = new Point(820, 652);
            button4.Name = "button4";
            button4.Size = new Size(162, 40);
            button4.TabIndex = 13;
            button4.Text = "Xem hóa đơn";
            // 
            // TraCuuHopDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 721);
            Controls.Add(childFormPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TraCuuHopDong";
            Text = "Form1";
            childFormPanel.ResumeLayout(false);
            childFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GrantPrivTable).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel childFormPanel;
        private DataGridView GrantPrivTable;
        private TextBox txtSearch;
        private Label label1;
        private Label label3;
        private Button btnSearch;
        private DataGridViewTextBoxColumn TableNameCol;
        private DataGridViewTextBoxColumn ICol;
        private DataGridViewTextBoxColumn SCol;
        private DataGridViewTextBoxColumn UCol;
        private DataGridViewTextBoxColumn DCol;
        private Button button2;
        private Button button1;
        private Button button4;
    }
}