using BLL;
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
    public partial class DN_PhanHoiBaiDang : Form
    {
        private string mahd = "";
        private HopDongBLL hdBLL = new HopDongBLL();
        private DNPhanHoiBLL phBLL = new DNPhanHoiBLL();
        public DN_PhanHoiBaiDang(string tmp)
        {
            InitializeComponent();
            mahd = tmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int chec = phBLL.ThemDNPhanHoi(mahd, textBox8.Text);
            if (chec == 1)
            {
                MessageBox.Show("Gửi phản hồi thành công.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if (chec == 5)
            {
                MessageBox.Show("Đã tồn tại phản hồi.");
            }
            if (chec == 0) MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau");
            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }
    }
}
