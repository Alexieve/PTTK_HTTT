namespace GUI
{
    partial class DN_LapYeuCauTD
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
            pnlTop = new Panel();
            labelTopbar = new Label();
            tabtbLout = new TableLayoutPanel();
            pnlXnpqc = new Panel();
            btnXnpqc = new Button();
            pnlLtgvht = new Panel();
            btnLtgvht = new Button();
            pnlLtt = new Panel();
            btnLtt = new Button();
            pnlMain = new Panel();
            pnlTop.SuspendLayout();
            tabtbLout.SuspendLayout();
            pnlXnpqc.SuspendLayout();
            pnlLtgvht.SuspendLayout();
            pnlLtt.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.Gray;
            pnlTop.Controls.Add(labelTopbar);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.ForeColor = Color.Transparent;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1077, 56);
            pnlTop.TabIndex = 0;
            // 
            // labelTopbar
            // 
            labelTopbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTopbar.AutoSize = true;
            labelTopbar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTopbar.ForeColor = SystemColors.Control;
            labelTopbar.Location = new Point(412, 13);
            labelTopbar.Name = "labelTopbar";
            labelTopbar.Size = new Size(276, 31);
            labelTopbar.TabIndex = 0;
            labelTopbar.Text = "Lập Yêu Cầu Tuyển Dụng";
            // 
            // tabtbLout
            // 
            tabtbLout.BackColor = Color.Silver;
            tabtbLout.ColumnCount = 3;
            tabtbLout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tabtbLout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tabtbLout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tabtbLout.Controls.Add(pnlXnpqc, 2, 0);
            tabtbLout.Controls.Add(pnlLtgvht, 1, 0);
            tabtbLout.Controls.Add(pnlLtt, 0, 0);
            tabtbLout.Dock = DockStyle.Top;
            tabtbLout.Location = new Point(0, 56);
            tabtbLout.Margin = new Padding(0);
            tabtbLout.Name = "tabtbLout";
            tabtbLout.RowCount = 1;
            tabtbLout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tabtbLout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tabtbLout.Size = new Size(1077, 55);
            tabtbLout.TabIndex = 1;
            // 
            // pnlXnpqc
            // 
            pnlXnpqc.BackColor = Color.Silver;
            pnlXnpqc.Controls.Add(btnXnpqc);
            pnlXnpqc.Dock = DockStyle.Fill;
            pnlXnpqc.Location = new Point(723, 5);
            pnlXnpqc.Margin = new Padding(5);
            pnlXnpqc.Name = "pnlXnpqc";
            pnlXnpqc.Padding = new Padding(0, 0, 0, 5);
            pnlXnpqc.Size = new Size(349, 45);
            pnlXnpqc.TabIndex = 2;
            pnlXnpqc.MouseClick += Btn_Click;
            // 
            // btnXnpqc
            // 
            btnXnpqc.BackColor = Color.Silver;
            btnXnpqc.Dock = DockStyle.Fill;
            btnXnpqc.FlatAppearance.BorderSize = 0;
            btnXnpqc.FlatStyle = FlatStyle.Flat;
            btnXnpqc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXnpqc.ForeColor = SystemColors.GrayText;
            btnXnpqc.Location = new Point(0, 0);
            btnXnpqc.Margin = new Padding(0);
            btnXnpqc.Name = "btnXnpqc";
            btnXnpqc.Size = new Size(349, 40);
            btnXnpqc.TabIndex = 2;
            btnXnpqc.Text = "Xác nhận phiếu quảng cáo";
            btnXnpqc.UseVisualStyleBackColor = false;
            btnXnpqc.Click += Btn_Click;
            // 
            // pnlLtgvht
            // 
            pnlLtgvht.BackColor = Color.Silver;
            pnlLtgvht.Controls.Add(btnLtgvht);
            pnlLtgvht.Dock = DockStyle.Fill;
            pnlLtgvht.Location = new Point(364, 5);
            pnlLtgvht.Margin = new Padding(5);
            pnlLtgvht.Name = "pnlLtgvht";
            pnlLtgvht.Padding = new Padding(0, 0, 0, 5);
            pnlLtgvht.Size = new Size(349, 45);
            pnlLtgvht.TabIndex = 1;
            // 
            // btnLtgvht
            // 
            btnLtgvht.BackColor = Color.Silver;
            btnLtgvht.Dock = DockStyle.Fill;
            btnLtgvht.FlatAppearance.BorderSize = 0;
            btnLtgvht.FlatStyle = FlatStyle.Flat;
            btnLtgvht.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLtgvht.ForeColor = SystemColors.GrayText;
            btnLtgvht.Location = new Point(0, 0);
            btnLtgvht.Margin = new Padding(0);
            btnLtgvht.Name = "btnLtgvht";
            btnLtgvht.Size = new Size(349, 40);
            btnLtgvht.TabIndex = 3;
            btnLtgvht.Text = "Lấy thời gian và hình thức đăng tuyển";
            btnLtgvht.UseVisualStyleBackColor = false;
            btnLtgvht.Click += Btn_Click;
            // 
            // pnlLtt
            // 
            pnlLtt.BackColor = Color.Silver;
            pnlLtt.Controls.Add(btnLtt);
            pnlLtt.Dock = DockStyle.Fill;
            pnlLtt.Location = new Point(5, 5);
            pnlLtt.Margin = new Padding(5);
            pnlLtt.Name = "pnlLtt";
            pnlLtt.Padding = new Padding(0, 0, 0, 5);
            pnlLtt.Size = new Size(349, 45);
            pnlLtt.TabIndex = 0;
            // 
            // btnLtt
            // 
            btnLtt.BackColor = Color.Silver;
            btnLtt.Dock = DockStyle.Fill;
            btnLtt.FlatAppearance.BorderSize = 0;
            btnLtt.FlatStyle = FlatStyle.Flat;
            btnLtt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLtt.ForeColor = SystemColors.GrayText;
            btnLtt.Location = new Point(0, 0);
            btnLtt.Margin = new Padding(0);
            btnLtt.Name = "btnLtt";
            btnLtt.Size = new Size(349, 40);
            btnLtt.TabIndex = 0;
            btnLtt.Text = "Lấy thông tin đăng tuyển";
            btnLtt.UseVisualStyleBackColor = false;
            btnLtt.Click += Btn_Click;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.Control;
            pnlMain.Location = new Point(0, 111);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1077, 610);
            pnlMain.TabIndex = 2;
            // 
            // Page_LYCTD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1077, 721);
            Controls.Add(pnlMain);
            Controls.Add(tabtbLout);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Page_LYCTD";
            Text = "Form1";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            tabtbLout.ResumeLayout(false);
            pnlXnpqc.ResumeLayout(false);
            pnlLtgvht.ResumeLayout(false);
            pnlLtt.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Label labelTopbar;
        private TableLayoutPanel tabtbLout;
        private Panel pnlLtt;
        private Button btnLtt;
        private Panel pnlXnpqc;
        private Button btnXnpqc;
        private Panel pnlLtgvht;
        private Button btnLtgvht;
        private Panel pnlMain;
    }
}