﻿namespace GUI
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
            pnlLtt = new Panel();
            btnLtt = new Button();
            pnlUserControl = new Panel();
            pnlTop.SuspendLayout();
            tabtbLout.SuspendLayout();
            pnlXnpqc.SuspendLayout();
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
            tabtbLout.ColumnCount = 2;
            tabtbLout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tabtbLout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tabtbLout.Controls.Add(pnlXnpqc, 1, 0);
            tabtbLout.Controls.Add(pnlLtt, 0, 0);
            tabtbLout.Dock = DockStyle.Top;
            tabtbLout.Location = new Point(0, 56);
            tabtbLout.Margin = new Padding(0);
            tabtbLout.Name = "tabtbLout";
            tabtbLout.RowCount = 1;
            tabtbLout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tabtbLout.Size = new Size(1077, 55);
            tabtbLout.TabIndex = 1;
            // 
            // pnlXnpqc
            // 
            pnlXnpqc.BackColor = Color.Silver;
            pnlXnpqc.Controls.Add(btnXnpqc);
            pnlXnpqc.Dock = DockStyle.Fill;
            pnlXnpqc.Location = new Point(543, 5);
            pnlXnpqc.Margin = new Padding(5);
            pnlXnpqc.Name = "pnlXnpqc";
            pnlXnpqc.Padding = new Padding(0, 0, 0, 5);
            pnlXnpqc.Size = new Size(529, 45);
            pnlXnpqc.TabIndex = 2;
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
            btnXnpqc.Size = new Size(529, 40);
            btnXnpqc.TabIndex = 2;
            btnXnpqc.Text = "Xác nhận phiếu quảng cáo";
            btnXnpqc.UseVisualStyleBackColor = false;
            btnXnpqc.Click += chuyen_Tab;
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
            pnlLtt.Size = new Size(528, 45);
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
            btnLtt.Size = new Size(528, 40);
            btnLtt.TabIndex = 0;
            btnLtt.Text = "Lấy thông tin đăng tuyển";
            btnLtt.UseVisualStyleBackColor = false;
            btnLtt.Click += chuyen_Tab;
            // 
            // pnlUserControl
            // 
            pnlUserControl.BackColor = SystemColors.Control;
            pnlUserControl.Location = new Point(0, 111);
            pnlUserControl.Name = "pnlUserControl";
            pnlUserControl.Size = new Size(1077, 610);
            pnlUserControl.TabIndex = 2;
            // 
            // DN_LapYeuCauTD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1077, 721);
            Controls.Add(pnlUserControl);
            Controls.Add(tabtbLout);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DN_LapYeuCauTD";
            Text = "Form1";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            tabtbLout.ResumeLayout(false);
            pnlXnpqc.ResumeLayout(false);
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
        private Panel pnlUserControl;
    }
}