namespace GUI
{
    partial class XemPhanHoiBaiDang
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
            label3 = new Label();
            panel1 = new Panel();
            textBox4 = new TextBox();
            label7 = new Label();
            button3 = new Button();
            textBox8 = new TextBox();
            label9 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1053, 52);
            label3.TabIndex = 5;
            label3.Text = "Xem lại phản hồi";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1054, 434);
            panel1.TabIndex = 19;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.Location = new Point(179, 71);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(151, 27);
            textBox4.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 71);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 34;
            label7.Text = "Ngày phản hồi: ";
            // 
            // button3
            // 
            button3.Location = new Point(467, 365);
            button3.Name = "button3";
            button3.Size = new Size(122, 40);
            button3.TabIndex = 33;
            button3.Text = "Đóng";
            button3.Click += button3_Click;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.Control;
            textBox8.Location = new Point(19, 139);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.ScrollBars = ScrollBars.Vertical;
            textBox8.Size = new Size(1011, 172);
            textBox8.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 105);
            label9.Name = "label9";
            label9.Size = new Size(140, 20);
            label9.TabIndex = 31;
            label9.Text = "Nội dung phản hồi: ";
            // 
            // XemPhanHoiBaiDang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 434);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(120, 169);
            Name = "XemPhanHoiBaiDang";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;

        private Panel panel1;
        private TextBox textBox8;
        private Label label9;
        private Button button3;
        private TextBox textBox4;
        private Label label7;
    }
}