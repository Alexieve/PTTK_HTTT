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
    public partial class DN_PhanHoiHS : Form
    {
        private Form activeForm = null;
        private Button currentButton;
        private Panel currentPanel;

        public DN_PhanHoiHS()
        {
            InitializeComponent();
            HopDongBtn_Click(DSHopDongBtn, null);
        }
        private void HopDongBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new DN_PhanHoiHS_DSHopDong(this));
            ActiveTab(sender);
            DSHoSoBtn.Enabled = false;

        }
        public void openChildForm(Form childForm)
        {
            if (childForm is DN_PhanHoiHS_DSHoSo)
            {
                ActiveTab(DSHoSoBtn);
            }


            if (activeForm != null)
            {
                activeForm.Close();
                this.TablePanel.Controls.Clear();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.TablePanel.Controls.Add(childForm);
            this.TablePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActiveTab(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableTab();
                currentButton = (Button)senderBtn;
                currentPanel = (Panel)currentButton.Parent;
                currentPanel.BackColor = Color.MediumSeaGreen;
            }
        }

        private void DisableTab()
        {
            if (currentButton != null)
            {
                currentPanel.BackColor = Color.DarkGray;
            }
        }
    }
}
