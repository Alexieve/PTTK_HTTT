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
    public partial class NV_PhanHoiHS : Form
    {
        private string MAHOPDONG;
        private string MAUV;
        NVPhanHoiBLL nvPhanHoiBLL = new();
        public NV_PhanHoiHS(string MAUV, string MAHOPDONG)
        {
            InitializeComponent();
            this.MAHOPDONG = MAHOPDONG;
            this.MAUV = MAUV;
        }

        private void HuyBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void XacNhanBtn_Click(object sender, EventArgs e)
        {
            NVPhanHoiDTO ph = new NVPhanHoiDTO(MAUV, MAHOPDONG, NoiDungBox.Text);
            string error = nvPhanHoiBLL.Insert(ph);
            if (error != "")
            {
                MessageBox.Show(error);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
