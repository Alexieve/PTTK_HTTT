using System;
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
    public partial class DN_Home : Form
    {
        private Button currentButton;
        public DN_Home()
        {
            InitializeComponent();
            // call LapYCBtn_Click when Home_DN is loaded
            LapYCBtn_Click(LapYCBtn, new EventArgs());
        }

        public void loadform(object Form)
        {
            if (this.childFormPanel.Controls.Count > 0)
                this.childFormPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.childFormPanel.Controls.Add(f);
            this.childFormPanel.Tag = f;
            f.Show();
        }

        private void LapYCBtn_Click(object sender, EventArgs e)
        {
            loadform(new Page_LYCTD());
            ActiveButton(sender);
        }
        private void TraCuuHDBtn_Click(object sender, EventArgs e)
        {
            loadform(new DN_TraCuuHD());
            ActiveButton(sender);
        }
        private void PhanHoiHSBtn_Click(object sender, EventArgs e)
        {
            loadform(new DN_PhanHoiHS());
            ActiveButton(sender);
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
    }
}
