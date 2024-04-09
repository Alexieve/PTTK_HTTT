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
    public partial class NV_XacThucHS : Form
    {
        public NV_XacThucHS()
        {
            InitializeComponent();
            addSampleData();
        }
        private void addSampleData()
        {
            HoSoTb.Rows.Add("HS001", "Nguyễn Văn A", "01/01/2021");
            HoSoTb.Rows.Add("HS002", "Nguyễn Văn B", "02/01/2021");
            HoSoTb.Rows.Add("HS003", "Nguyễn Văn C", "03/01/2021");
            HoSoTb.Rows.Add("HS004", "Nguyễn Văn D", "04/01/2021");
            HoSoTb.Rows.Add("HS005", "Nguyễn Văn E", "05/01/2021");

        }
        private void XemCTBtn_Click(object sender, EventArgs e)
        {
            NV_XacThucHS_ChiTietHS modal = new NV_XacThucHS_ChiTietHS();
            modal.ShowDialog();
        }
    }
}
