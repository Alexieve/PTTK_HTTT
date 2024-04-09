namespace GUI
{
    partial class NV_TraCuuHD
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            childFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GrantPrivTable).BeginInit();
            SuspendLayout();
            // 
            // childFormPanel
            // 
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
            label3.BackColor = Color.Gray;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1077, 68);
            label3.TabIndex = 5;
            label3.Text = "Danh Sách Hợp Đồng";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(137, 652);
            button1.Name = "button1";
            button1.Size = new Size(137, 40);
            button1.TabIndex = 11;
            button1.Text = "Đăng bài";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(767, 652);
            button2.Name = "button2";
            button2.Size = new Size(177, 40);
            button2.TabIndex = 9;
            button2.Text = "Xem bài đăng";
            button2.Click += button2_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(403, 85);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(132, 40);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(173, 90);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 34);
            txtSearch.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 93);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 7;
            label1.Text = "Mã Hợp Đồng: ";
            // 
            // GrantPrivTable
            // 
            GrantPrivTable.AllowUserToAddRows = false;
            GrantPrivTable.AllowUserToDeleteRows = false;
            GrantPrivTable.Anchor = AnchorStyles.Bottom;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            GrantPrivTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            GrantPrivTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrantPrivTable.Columns.AddRange(new DataGridViewColumn[] { TableNameCol, ICol, SCol, UCol, DCol });
            GrantPrivTable.Location = new Point(10, 147);
            GrantPrivTable.Name = "GrantPrivTable";
            GrantPrivTable.RowHeadersWidth = 51;
            GrantPrivTable.Size = new Size(1053, 475);
            GrantPrivTable.TabIndex = 4;
            // 
            // TableNameCol
            // 
            TableNameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TableNameCol.HeaderText = "Mã Hợp Đồng";
            TableNameCol.MinimumWidth = 6;
            TableNameCol.Name = "TableNameCol";
            TableNameCol.ReadOnly = true;
            // 
            // ICol
            // 
            ICol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ICol.HeaderText = "Mã Doanh Nghiệp";
            ICol.MinimumWidth = 6;
            ICol.Name = "ICol";
            ICol.ReadOnly = true;
            // 
            // SCol
            // 
            SCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SCol.HeaderText = "Tên Doanh Nghiệp";
            SCol.MinimumWidth = 6;
            SCol.Name = "SCol";
            SCol.ReadOnly = true;
            // 
            // UCol
            // 
            UCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UCol.HeaderText = "Tổng Tiền";
            UCol.MinimumWidth = 6;
            UCol.Name = "UCol";
            UCol.ReadOnly = true;
            // 
            // DCol
            // 
            DCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DCol.HeaderText = "Số Tiền Chưa Thanh Toán";
            DCol.MinimumWidth = 6;
            DCol.Name = "DCol";
            DCol.ReadOnly = true;
            DCol.Resizable = DataGridViewTriState.True;
            // 
            // NV_TraCuuHD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 721);
            Controls.Add(childFormPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NV_TraCuuHD";
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
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn TableNameCol;
        private DataGridViewTextBoxColumn ICol;
        private DataGridViewTextBoxColumn SCol;
        private DataGridViewTextBoxColumn UCol;
        private DataGridViewTextBoxColumn DCol;
    }
}
