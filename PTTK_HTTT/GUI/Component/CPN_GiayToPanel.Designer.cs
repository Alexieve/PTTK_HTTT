namespace GUI
{
    partial class GiayToCpn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MoTaPanel = new Panel();
            MoTaBox = new RichTextBox();
            MoTaLabel = new Label();
            DelGiayToBtn = new Button();
            GiayToPanel = new Panel();
            LoaiGTPanel = new Panel();
            LoaiGTBox = new TextBox();
            LoaiGTLabel = new Label();
            MoTaPanel.SuspendLayout();
            GiayToPanel.SuspendLayout();
            LoaiGTPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MoTaPanel
            // 
            MoTaPanel.Controls.Add(MoTaBox);
            MoTaPanel.Controls.Add(MoTaLabel);
            MoTaPanel.Location = new Point(0, 74);
            MoTaPanel.Name = "MoTaPanel";
            MoTaPanel.Size = new Size(548, 221);
            MoTaPanel.TabIndex = 11;
            // 
            // MoTaBox
            // 
            MoTaBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MoTaBox.Font = new Font("Segoe UI", 12F);
            MoTaBox.Location = new Point(145, 13);
            MoTaBox.Name = "MoTaBox";
            MoTaBox.Size = new Size(398, 202);
            MoTaBox.TabIndex = 1;
            MoTaBox.Text = "";
            // 
            // MoTaLabel
            // 
            MoTaLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MoTaLabel.AutoSize = true;
            MoTaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MoTaLabel.Location = new Point(3, 16);
            MoTaLabel.Name = "MoTaLabel";
            MoTaLabel.Size = new Size(79, 56);
            MoTaLabel.TabIndex = 0;
            MoTaLabel.Text = "Mô tả\r\ngiấy tờ";
            // 
            // DelGiayToBtn
            // 
            DelGiayToBtn.Font = new Font("Segoe UI", 12F);
            DelGiayToBtn.Location = new Point(449, 8);
            DelGiayToBtn.Name = "DelGiayToBtn";
            DelGiayToBtn.Size = new Size(94, 39);
            DelGiayToBtn.TabIndex = 13;
            DelGiayToBtn.Text = "Xoá";
            DelGiayToBtn.UseVisualStyleBackColor = true;
            DelGiayToBtn.Click += DelGiayToBtn_Click;
            // 
            // GiayToPanel
            // 
            GiayToPanel.Controls.Add(LoaiGTPanel);
            GiayToPanel.Controls.Add(MoTaPanel);
            GiayToPanel.Dock = DockStyle.Fill;
            GiayToPanel.Location = new Point(0, 0);
            GiayToPanel.Name = "GiayToPanel";
            GiayToPanel.Size = new Size(548, 298);
            GiayToPanel.TabIndex = 12;
            // 
            // LoaiGTPanel
            // 
            LoaiGTPanel.Controls.Add(LoaiGTBox);
            LoaiGTPanel.Controls.Add(DelGiayToBtn);
            LoaiGTPanel.Controls.Add(LoaiGTLabel);
            LoaiGTPanel.Location = new Point(0, 3);
            LoaiGTPanel.Name = "LoaiGTPanel";
            LoaiGTPanel.Size = new Size(548, 65);
            LoaiGTPanel.TabIndex = 14;
            // 
            // LoaiGTBox
            // 
            LoaiGTBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoaiGTBox.Font = new Font("Segoe UI", 12F);
            LoaiGTBox.Location = new Point(147, 13);
            LoaiGTBox.Name = "LoaiGTBox";
            LoaiGTBox.Size = new Size(272, 34);
            LoaiGTBox.TabIndex = 1;
            // 
            // LoaiGTLabel
            // 
            LoaiGTLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoaiGTLabel.AutoSize = true;
            LoaiGTLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoaiGTLabel.Location = new Point(3, 16);
            LoaiGTLabel.Name = "LoaiGTLabel";
            LoaiGTLabel.Size = new Size(124, 28);
            LoaiGTLabel.TabIndex = 0;
            LoaiGTLabel.Text = "Loại giấy tờ";
            // 
            // GiayToCpn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(GiayToPanel);
            Name = "GiayToCpn";
            Size = new Size(548, 298);
            MoTaPanel.ResumeLayout(false);
            MoTaPanel.PerformLayout();
            GiayToPanel.ResumeLayout(false);
            LoaiGTPanel.ResumeLayout(false);
            LoaiGTPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MoTaPanel;
        internal RichTextBox MoTaBox;
        private Label MoTaLabel;
        internal Button DelGiayToBtn;
        private Panel GiayToPanel;
        private Panel LoaiGTPanel;
        internal TextBox LoaiGTBox;
        private Label LoaiGTLabel;
    }
}
