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
    public partial class NV_XuLyDNTN : Form
    {
        public NV_XuLyDNTN()
        {
            InitializeComponent();
            addSampleData();
        }

        private void addSampleData()
        {
            // Add some row for DNTb datagridview
            DNTb.Rows.Add("DN00000001", "HD00000001");
            DNTb.Rows.Add("DN00000002", "HD00000002");
            DNTb.Rows.Add("DN00000003", "HD00000003");
            DNTb.Rows.Add("DN00000004", "HD00000004");
            DNTb.Rows.Add("DN00000005", "HD00000005");

        }
        private void SoNgayGHBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void XemCTBtn_Click(object sender, EventArgs e)
        {
            TenDNBox.Text = "Công ty A";
            SDTBox.Text = "0123456789";
            MAHDBox.Text = DNTb.CurrentRow.Cells[1].Value.ToString();
            ViTriTDBox.Text = "Senior - Software Engineer";
            SoLuongTDBox.Text = "10";
            NgayKTBox.Text = "01/01/2022";
            UuDaiBox.Text = "10%";
        }
    }
}
