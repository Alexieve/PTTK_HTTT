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
    public partial class NV_XacThucHS_ChiTietHS : Form
    {

        public NV_XacThucHS_ChiTietHS()
        {
            InitializeComponent();
            LoadGiayToUngVien();

        }
        private void LoadGiayToUngVien()
        {
            // Add GiayToCpn to ParentPanel
            ThemGiayTo();
            ThemGiayTo();
        }

        private void ThemGiayTo()
        {
            // Add GiayToPanel to ParentPanel when click button Allow add multiple and can scroll
            GiayToCpn giayToCpn = new GiayToCpn();
            giayToCpn.Location = new Point(0, 0);
            giayToCpn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            giayToCpn.DelGiayToBtn.Visible = false;
            ParentPanel.Controls.Add(giayToCpn);

        }

        private void XacNhanBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TuChoiBtn_Click(object sender, EventArgs e)
        {
            NV_PhanHoiHS modal = new NV_PhanHoiHS();
            modal.ShowDialog();
            if (modal.DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
