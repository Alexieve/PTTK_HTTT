using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;

namespace GUI
{
    public partial class UV_Home : Form
    {
        private Button currentButton;
        private Form activeForm = null;
        public UV_Home(string username)
        {
            InitializeComponent();
            usernameLabel.Text = username;
            HomeBtn_Click(HomeBtn, new EventArgs());
            addSample();
            addSample();
            addSample();
            addSample();
            addSample();


            //Test UngTuyenModal
            //ViTriUngTuyenDTO viTriUngTuyenDTO = new ViTriUngTuyenDTO("HD00000001", "Quỳnh Company", "Intern", "Back-end Developer");
            //HSUngTuyenBLL hsUngTuyenBLL = new HSUngTuyenBLL();
            //if (hsUngTuyenBLL.Check_Applied(viTriUngTuyenDTO.MAHOPDONG))
            //{
            //    MessageBox.Show("Bạn đã ứng tuyển cho vị trí này!");
            //    return;
            //}
            //UV_UngTuyenModal modal = new UV_UngTuyenModal(viTriUngTuyenDTO);
            //modal.ShowDialog();
        }

        private void addSample()
        {
            CPN_CardTuyenDung card = new CPN_CardTuyenDung();
            card.Margin = new Padding(0, 0, 0, 10);
            ContentPanel.Controls.Add(card);

        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            // delete ChildFormPanel
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(sender);
        }
        private void XemKQBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new UV_KetQuaHS());
            ActiveButton(sender);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DbConnection conn = new DbConnection();
            conn.Disconnect();
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();
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
    }
}
