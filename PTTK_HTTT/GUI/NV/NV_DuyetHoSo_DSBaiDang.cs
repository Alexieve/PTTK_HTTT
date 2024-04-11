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
    public partial class NV_DuyetHoSo_DSBaiDang : Form
    {
        private NV_DuyetHoSo duyetHoSoTab;
        public NV_DuyetHoSo_DSBaiDang(NV_DuyetHoSo duyetHoSoTab)
        {
            InitializeComponent();
            addSampleData();
            this.duyetHoSoTab = duyetHoSoTab;
        }

        private void addSampleData()
        {
            // add sample data for row Mã hợp đồng, cấp bậc + vị trí tuyển dụng, số hồ sơ cần phản hồi, hạn chót phản hồi
            BaiDangTb.Rows.Add("HD001", "Senior - Software Engineer", 10, "01/01/2022");
            BaiDangTb.Rows.Add("HD002", "Middle - Data Engineer", 12, "01/01/2021");
            BaiDangTb.Rows.Add("HD003", "Fresher - Data Analyst", 15, "01/01/2021");
            BaiDangTb.Rows.Add("HD004", "Intern - Software Engineer", 67, "01/01/2021");
            BaiDangTb.Rows.Add("HD005", "Intern - Data Engineer", 36, "01/01/2021");
        }
        private void XemDSHoSoBtn_Click(object sender, EventArgs e)
        {
            this.duyetHoSoTab.openChildForm(new NV_DuyetHoSo_DSHoSo(this.duyetHoSoTab));
        }
    }
}
