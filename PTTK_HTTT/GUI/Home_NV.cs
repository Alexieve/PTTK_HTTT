
namespace GUI
{
    public partial class Home_NV : Form
    {
        private Button currentButton;
        private Form activeForm = null;
        public Home_NV()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {

            ActiveButton(sender);
        }

        private void XacThucDNBtn_Click(object sender, EventArgs e)
        {

            ActiveButton(sender);
        }

        private void XacThucHSBtn_Click(object sender, EventArgs e)
        {

            ActiveButton(sender);
        }

        private void ThanhToanBtn_Click(object sender, EventArgs e)
        {

            ActiveButton(sender);
        }

        private void DuyetHSBtn_Click(object sender, EventArgs e)
        {

            ActiveButton(sender);
        }

        private void GiaHanHDBtn_Click(object sender, EventArgs e)
        {

            ActiveButton(sender);
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
