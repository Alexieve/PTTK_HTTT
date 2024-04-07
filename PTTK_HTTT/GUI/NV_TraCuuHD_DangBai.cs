﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{

    public partial class NV_TraCuuHD_DangBai : Form
    {
        private Button currentButton;
        private Form activeForm = null;
        public NV_TraCuuHD_DangBai()
        {
            InitializeComponent();
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.childFormPanel.Controls.Add(childForm);
            this.childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void ActiveButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                if (currentButton != (Button)senderBtn)
                {
                    DisableButton();
                    currentButton = (Button)senderBtn;
                    currentButton.BackColor = Color.FromArgb(128, 128, 128);
                }
            }
        }
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new NV_TraCuuHD());
            ActiveButton(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new NV_TraCuuHD());
            ActiveButton(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new NV_TraCuuHD());
            ActiveButton(sender);
        }
    }
}