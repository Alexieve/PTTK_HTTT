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
        private HopDongBLL TuyenDung;
        private Button currentButton;
        private Form activeForm = null;

        public UV_Home(string username)
        {
            TuyenDung = new HopDongBLL();
            InitializeComponent();
            usernameLabel.Text = username;
            HomeBtn_Click(HomeBtn, new EventArgs());
            Load();
        }
        private void Load()
        {
            ContentPanel.Controls.Clear();
            List<HopDongDTO> danhSachTuyenDung = TuyenDung.Get_All_BaiDangTuyenDung();
            foreach (var array in danhSachTuyenDung)
            {
                addData(array.MAHOPDONG, array.VITRITD, array.TENDN, array.CAPBACTD, array.DIACHI, array.KYNANG);
            }
        }
        public string getUsername()
        {
            return usernameLabel.Text;
        }
        private void Load(string SearchString)
        {
            ContentPanel.Controls.Clear();
            List<HopDongDTO> danhSachTuyenDung = TuyenDung.Search_BaiDangTuyenDung(SearchString);
            foreach (var array in danhSachTuyenDung)
            {
                addData(array.MAHOPDONG, array.VITRITD, array.TENDN, array.CAPBACTD, array.DIACHI, array.KYNANG);
            }
        }
        private void addData(string MAHD, string MOTA, string TENDN, string CAPBAC, string DIACHI, string KYNANG)
        {
            CPN_CardTuyenDung card = new CPN_CardTuyenDung();
            card.Margin = new Padding(0, 0, 0, 10);
            card.MAHOPDONG = MAHD;
            card.ViTri = MOTA;
            card.TenDoanhNghiep = TENDN;
            card.CapBacUngtuyen = CAPBAC;
            card.DiaChiDN = DIACHI;
            card.KyNangUngTuyen = KYNANG;
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
        public void closeChildForm()
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Load();
        }
        public void openChildForm(Form childForm)
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

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchString = SearchBox.Text;
            if (searchString == "") Load();
            else Load(searchString);
        }
    }
}
