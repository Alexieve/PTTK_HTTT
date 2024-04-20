
using DAL;

namespace GUI
{
    public partial class NV_Home : Form
    {
        private Button currentButton;
        private Form activeForm = null;
        public NV_Home(string username)
        {
            InitializeComponent();
            usernameLabel.Text = username;
            this.IsMdiContainer = true;
        }

        private void XacThucDNBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new NV_XacThucDN());
        }

        private void XacThucHSBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new NV_XacThucHS());
        }
        private void TraCuuHDBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new NV_TraCuuHD());
        }
        private void ThanhToanBtn_Click(object sender, EventArgs e)
        {

            ActiveButton(sender);
            openChildForm(new NV_ThanhToan());
        }

        private void DuyetHSBtn_Click(object sender, EventArgs e)
        {

            ActiveButton(sender);
            openChildForm(new NV_DuyetHoSo());
        }

        private void GiaHanHDBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new NV_XuLyDNTN());
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
                this.childFormPanel.Controls.Clear();
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
