namespace GUI
{
    partial class DN_TraCuuHD
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            childFormPanel = new Panel();
            panel1 = new Panel();
            btnSearch = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            button4 = new Button();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            GrantPrivTable = new DataGridView();
            TableNameCol = new DataGridViewTextBoxColumn();
            ICol = new DataGridViewTextBoxColumn();
            SCol = new DataGridViewTextBoxColumn();
            UCol = new DataGridViewTextBoxColumn();
            DCol = new DataGridViewTextBoxColumn();
            childFormPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GrantPrivTable).BeginInit();
            SuspendLayout();
            // 
            // childFormPanel
            // 
            childFormPanel.Controls.Add(panel1);
            childFormPanel.Controls.Add(button4);
            childFormPanel.Controls.Add(label3);
            childFormPanel.Controls.Add(button1);
            childFormPanel.Controls.Add(button2);
            childFormPanel.Controls.Add(GrantPrivTable);
            childFormPanel.Font = new Font("Segoe UI", 12F);
            childFormPanel.Location = new Point(0, 0);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(1077, 721);
            childFormPanel.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSearch);
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(1077, 51);
            panel1.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(407, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(132, 40);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 7;
            label1.Text = "Mã Hợp Đồng";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(170, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập mã hợp đồng...";
            txtSearch.Size = new Size(200, 34);
            txtSearch.TabIndex = 6;
            // 
            // button4
            // 
            button4.Location = new Point(820, 652);
            button4.Name = "button4";
            button4.Size = new Size(162, 40);
            button4.TabIndex = 13;
            button4.Text = "Xem hóa đơn";
            button4.Click += button4_Click;
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
            // GrantPrivTable
            // 
            GrantPrivTable.AllowUserToAddRows = false;
            GrantPrivTable.AllowUserToDeleteRows = false;
            GrantPrivTable.Anchor = AnchorStyles.Bottom;
            GrantPrivTable.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GrantPrivTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GrantPrivTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrantPrivTable.Columns.AddRange(new DataGridViewColumn[] { TableNameCol, ICol, SCol, UCol, DCol });
            GrantPrivTable.Location = new Point(10, 112);
            GrantPrivTable.Name = "GrantPrivTable";
            GrantPrivTable.RowHeadersWidth = 51;
            GrantPrivTable.Size = new Size(1053, 518);
            GrantPrivTable.TabIndex = 4;
            GrantPrivTable.SelectionChanged += GrantPrivTable_SelectionChanged;
            // 
            // TableNameCol
            // 
            TableNameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            //TableNameCol.DefaultCellStyle = dataGridViewCellStyle2;
            TableNameCol.HeaderText = "Mã Hợp Đồng";
            TableNameCol.MinimumWidth = 6;
            TableNameCol.Name = "TableNameCol";
            TableNameCol.ReadOnly = true;
            // 
            // ICol
            // 
            ICol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ICol.DefaultCellStyle = dataGridViewCellStyle3;
            ICol.HeaderText = "Ngày Tuyển Dụng";
            ICol.MinimumWidth = 6;
            ICol.Name = "ICol";
            ICol.ReadOnly = true;
            // 
            // SCol
            // 
            SCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SCol.DefaultCellStyle = dataGridViewCellStyle4;
            SCol.HeaderText = "Số Lượng Tuyển Dụng";
            SCol.MinimumWidth = 6;
            SCol.Name = "SCol";
            SCol.ReadOnly = true;
            // 
            // UCol
            // 
            UCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UCol.DefaultCellStyle = dataGridViewCellStyle5;
            UCol.HeaderText = "Tổng Tiền";
            UCol.MinimumWidth = 6;
            UCol.Name = "UCol";
            UCol.ReadOnly = true;
            // 
            // DCol
            // 
            DCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DCol.DefaultCellStyle = dataGridViewCellStyle6;
            DCol.HeaderText = "Số Tiền Chưa Thanh Toán";
            DCol.MinimumWidth = 6;
            DCol.Name = "DCol";
            DCol.ReadOnly = true;
            DCol.Resizable = DataGridViewTriState.True;
            // 
            // DN_TraCuuHD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 721);
            Controls.Add(childFormPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DN_TraCuuHD";
            Text = "Form1";
            childFormPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button button4;
        private Panel panel1;
        private DataGridViewTextBoxColumn TableNameCol;
        private DataGridViewTextBoxColumn ICol;
        private DataGridViewTextBoxColumn SCol;
        private DataGridViewTextBoxColumn UCol;
        private DataGridViewTextBoxColumn DCol;
    }
}
