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
    public partial class NV_XacThucDN : Form
    {
        private DoanhNghiepBLL doanhNghiepBLL = new();
        public NV_XacThucDN()
        {
            InitializeComponent();
            Load_Table();
        }

        private void Load_Table()
        {
            // Clear all box
            MADNBox.Text = "";
            TenDNBox.Text = "";
            MAThueBox.Text = "";
            NGDaiDienBox.Text = "";
            DiaChiBox.Text = "";
            SDTBox.Text = "";
            EmailBox.Text = "";

            List<DoanhNghiepDTO> listDN = doanhNghiepBLL.Get_List_DN_For_Xac_Thuc();
            // USE FOR LOOP TO ADD ROWS AND CELLS
            DNTb.Rows.Clear();
            foreach (DoanhNghiepDTO dn in listDN)
            {
                DNTb.Rows.Add(dn.MADN, dn.TENDN);
            }
        }
        private void XemCTBtn_Click(object sender, EventArgs e)
        {
            if (DNTb.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn doanh nghiệp");
                return;
            }
            DoanhNghiepDTO dn = doanhNghiepBLL.Get_Detail(DNTb.CurrentRow.Cells[0].Value.ToString());
            MADNBox.Text = dn.MADN;
            TenDNBox.Text = dn.TENDN;
            MAThueBox.Text = dn.MSTHUE;
            NGDaiDienBox.Text = dn.NGDAIDIEN;
            DiaChiBox.Text = dn.DIACHI;
            SDTBox.Text = dn.SDT;
            EmailBox.Text = dn.EMAIL;
        }

        private void TuChoiBtn_Click(object sender, EventArgs e)
        {
            string MADN = MADNBox.Text;
            if (MADN == "")
            {
                MessageBox.Show("Chưa chọn doanh nghiệp");
                return;
            }
            doanhNghiepBLL.Delete(MADN);
            MessageBox.Show("Đã từ chối doanh nghiệp");
            Load_Table();
        }

        private void XacNhanBtn_Click(object sender, EventArgs e)
        {
            string MADN = MADNBox.Text;
            string TENDN = TenDNBox.Text;
            string MSTHUE = MAThueBox.Text;
            string NGDAIDIEN = NGDaiDienBox.Text;
            string DIACHI = DiaChiBox.Text;

            if (MADN == "")
            {
                MessageBox.Show("Chưa chọn doanh nghiệp");
                return;
            }

            DoanhNghiepDTO dn = new(MADN, TENDN, MSTHUE, NGDAIDIEN, DIACHI);
            string errorCode = doanhNghiepBLL.Xac_Thuc(dn);
            if (errorCode == "")
            {
                MessageBox.Show("Đã xác thực doanh nghiệp");
                Load_Table();
            }
            else
            {
                MessageBox.Show(errorCode);
            }
        }
    }
}
