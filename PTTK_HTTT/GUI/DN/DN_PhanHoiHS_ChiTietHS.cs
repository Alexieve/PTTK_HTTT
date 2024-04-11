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
    public partial class DN_PhanHoiHS_ChiTietHS : Form
    {

        public DN_PhanHoiHS_ChiTietHS()
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
            ParentPanel.Controls.Add(giayToCpn);
            giayToCpn.DelGiayToBtn.Visible = false;
        }

        private void XacNhanBtn_Click(object sender, EventArgs e)
        {

        }

        private void TuChoiBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
