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
using DTO;

namespace GUI
{
    public partial class UV_DangKy : Form
    {
        private DangKyBLL dangKyBLL = new();
        public UV_DangKy()
        {
            InitializeComponent();
        }
        private void DangKyBtn_Click(object sender, EventArgs e)
        {
            string hoten = HoTenBox.Text;
            string phai = PhaiBox.Text;
            DateTime ngaysinh = NgaySinhBox.Value;
            string diachi = DiaChiBox.Text;
            string sdt = SDTBox.Text;
            string email = EmailBox.Text;
            string password = MatKhauBox.Text;
            UngVienDTO uv = new UngVienDTO(hoten, phai, ngaysinh, diachi, sdt, email);
            if (dangKyBLL.DangKy_UV(uv, password))
            {
                MessageBox.Show("Đăng ký thành công");
                this.Close();
            }
        }
        private void SDTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void PreventSpaceAndTab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || e.KeyChar == '\t')
            {
                e.Handled = true;
            }
        }
    }
}
