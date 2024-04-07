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
    public partial class DN_PhanHoiHS_DSHopDong : Form
    {
        private DN_PhanHoiHS phanHoiHsTab;
        public DN_PhanHoiHS_DSHopDong(DN_PhanHoiHS phanHoiHsTab)
        {
            InitializeComponent();
            addSampleData();
            this.phanHoiHsTab = phanHoiHsTab;
        }

        private void addSampleData()
        {
            // add sample data for row Mã hợp đồng, cấp bậc + vị trí tuyển dụng, số hồ sơ cần phản hồi, hạn chót phản hồi
            HopDongTb.Rows.Add("HD001", "Senior - Software Engineer", 10, "01/01/2022");
            HopDongTb.Rows.Add("HD002", "Middle - Data Engineer", 12, "01/01/2021");
            HopDongTb.Rows.Add("HD003", "Fresher - Data Analyst", 15, "01/01/2021");
            HopDongTb.Rows.Add("HD004", "Intern - Software Engineer", 67, "01/01/2021");
            HopDongTb.Rows.Add("HD005", "Intern - Data Engineer", 36, "01/01/2021");


        }

        private void HopDongTb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.phanHoiHsTab.openChildForm(new DN_PhanHoiHS_DSHoSo(this.phanHoiHsTab));
        }
    }
}
