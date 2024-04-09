namespace GUI
{
    partial class UV_Home
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
            ContentPanel = new FlowLayoutPanel();
            SearchPanel = new Panel();
            SearchBtn = new Button();
            textBox1 = new TextBox();
            sidePanel = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            usernameLabel = new Label();
            logoutBtn = new Button();
            HomeBtn = new Button();
            XemKQBtn = new Button();
            childFormPanel.SuspendLayout();
            SearchPanel.SuspendLayout();
            sidePanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // childFormPanel
            // 
            childFormPanel.Controls.Add(ContentPanel);
            childFormPanel.Controls.Add(SearchPanel);
            childFormPanel.Font = new Font("Segoe UI", 12F);
            childFormPanel.Location = new Point(272, 0);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(1077, 721);
            childFormPanel.TabIndex = 6;
            // 
            // ContentPanel
            // 
            ContentPanel.AutoScroll = true;
            ContentPanel.Location = new Point(3, 73);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(1061, 636);
            ContentPanel.TabIndex = 3;
            // 
            // SearchPanel
            // 
            SearchPanel.Controls.Add(SearchBtn);
            SearchPanel.Controls.Add(textBox1);
            SearchPanel.Location = new Point(3, 12);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(1061, 55);
            SearchPanel.TabIndex = 2;
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SearchBtn.Location = new Point(927, 4);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(134, 43);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "Tìm Kiếm";
            SearchBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(3, 8);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tìm kiếm theo các Vị trí, Kỹ năng, Công ty,...";
            textBox1.Size = new Size(921, 34);
            textBox1.TabIndex = 0;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(64, 64, 64);
            sidePanel.Controls.Add(tableLayoutPanel1);
            sidePanel.Dock = DockStyle.Fill;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(1348, 721);
            sidePanel.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(HomeBtn, 0, 1);
            tableLayoutPanel1.Controls.Add(XemKQBtn, 0, 2);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 41F));
            tableLayoutPanel1.Size = new Size(266, 718);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(logoutBtn);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 116);
            panel1.TabIndex = 0;
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            usernameLabel.BackColor = Color.Gray;
            usernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = SystemColors.ControlLightLight;
            usernameLabel.ImageAlign = ContentAlignment.MiddleLeft;
            usernameLabel.Location = new Point(0, 33);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(260, 20);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "USERNAME";
            usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoutBtn
            // 
            logoutBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            logoutBtn.BackColor = SystemColors.ButtonHighlight;
            logoutBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            logoutBtn.Location = new Point(83, 69);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(94, 29);
            logoutBtn.TabIndex = 0;
            logoutBtn.Text = "Đăng xuất";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HomeBtn.FlatAppearance.BorderSize = 0;
            HomeBtn.FlatStyle = FlatStyle.Flat;
            HomeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HomeBtn.ForeColor = Color.White;
            HomeBtn.Location = new Point(3, 132);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(260, 288);
            HomeBtn.TabIndex = 0;
            HomeBtn.Text = "Trang Chủ";
            HomeBtn.UseVisualStyleBackColor = true;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // XemKQBtn
            // 
            XemKQBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            XemKQBtn.FlatAppearance.BorderSize = 0;
            XemKQBtn.FlatStyle = FlatStyle.Flat;
            XemKQBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            XemKQBtn.ForeColor = Color.White;
            XemKQBtn.Location = new Point(3, 426);
            XemKQBtn.Name = "XemKQBtn";
            XemKQBtn.Size = new Size(260, 289);
            XemKQBtn.TabIndex = 0;
            XemKQBtn.Text = "Xem Kết Quả Ứng Tuyển";
            XemKQBtn.UseVisualStyleBackColor = true;
            XemKQBtn.Click += XemKQBtn_Click;
            // 
            // UV_Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(childFormPanel);
            Controls.Add(sidePanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UV_Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home_UV";
            childFormPanel.ResumeLayout(false);
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            sidePanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel childFormPanel;
        private FlowLayoutPanel sidePanel;
        private Panel panel1;
        private Label usernameLabel;
        private Button logoutBtn;
        private Button HomeBtn;
        private Button XemKQBtn;
        private Button SearchBtn;
        private TextBox textBox1;
        private Panel SearchPanel;
        private FlowLayoutPanel ContentPanel;
        private TableLayoutPanel tableLayoutPanel1;
    }
}