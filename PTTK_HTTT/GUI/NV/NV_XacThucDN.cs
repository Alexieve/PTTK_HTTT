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
    public partial class NV_XacThucDN : Form
    {
        public NV_XacThucDN()
        {
            InitializeComponent();
            addSampleData();
        }

        private void addSampleData()
        {
            // Add data for DNTb
            DNTb.Rows.Add("DN00000001", "Công ty ABC");
            DNTb.Rows.Add("DN00000002", "Công ty XYZ");
            DNTb.Rows.Add("DN00000003", "Công ty 123");
            DNTb.Rows.Add("DN00000004", "Công ty 456");
            DNTb.Rows.Add("DN00000005", "Công ty 789");
        }
        private void XemCTBtn_Click(object sender, EventArgs e)
        {
            MADNBox.Text = DNTb.CurrentRow.Cells[0].Value.ToString();
            TenDNBox.Text = DNTb.CurrentRow.Cells[1].Value.ToString();
            MAThueBox.Text = "123456789";
            NGDaiDienBox.Text = "Nguyễn Văn A";
            DiaChiBox.Text = "123 Đường ABC";
            SDTBox.Text = "0123456789";
            EmailBox.Text = "adasd@gmail.com";
        }
    }
}
