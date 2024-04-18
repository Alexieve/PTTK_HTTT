using BLL;

namespace GUI
{
    public partial class DangNhap : Form
    {
        private DangNhapBLL dangNhapBLL = new DangNhapBLL();
        private Button currentButton;
        private Form activeForm = null;
        public DangNhap()
        {
            InitializeComponent();
        }
        
        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text.Trim();
            string password = PasswordBox.Text.Trim();

            username = dangNhapBLL.GetUsernameByEmailSDT(username, password);
            if (username != null)
            {
                string role = dangNhapBLL.Connect(username, password);
                if (role == null)
                { 
                    MessageBox.Show("Tài khoản của bạn chưa được xác thực");
                    dangNhapBLL = new DangNhapBLL();
                    return;
                }
                this.Hide();
                Form homeForm = null;
                switch (role)
                {
                    case "RL_DOANHNGHIEP":
                        homeForm = new DN_Home(username);
                        break;
                    case "RL_UNGVIEN":
                        homeForm = new UV_Home(username);
                        break;
                    case "RL_NHANVIEN":
                        homeForm = new NV_Home(username);
                        break;
                    case "RL_BANLANHDAO":
                        homeForm = new BLD_Home(username);
                        break;
                }
                homeForm.ShowDialog();
                this.Close();
            }


        }
        private void DangKyUVBtn_Click(object sender, EventArgs e)
        {
            UV_DangKy uvDangKy = new UV_DangKy();
            uvDangKy.ShowDialog();
        }

        private void DangKyDNBtn_Click(object sender, EventArgs e)
        {
            DN_DangKy dnDangKy = new DN_DangKy();
            dnDangKy.ShowDialog();
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
    }
}
