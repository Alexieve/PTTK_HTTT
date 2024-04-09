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
    public partial class UV_KetQuaHS_ChiTietHS : Form
    {

        public UV_KetQuaHS_ChiTietHS()
        {
            InitializeComponent();
            LoadThongTinHoSo();
        }

        private void LoadThongTinHoSo()
        {
            ThongTinUngTuyenCpn thongTinUngTuyenCpn = new ThongTinUngTuyenCpn();
            thongTinUngTuyenCpn.Location = new Point(0, 0);
            thongTinUngTuyenCpn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ParentPanel.Controls.Add(thongTinUngTuyenCpn);
            // Move GiayToPanel to the after all ThongTinUngTuyenCpn
            GiayToPanel.Location = new Point(0, thongTinUngTuyenCpn.Height);
            GiayToPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ParentPanel.Controls.Add(GiayToPanel);
        }

        private void ThemGiayToBtn_Click(object sender, EventArgs e)
        {
            // Add GiayToPanel to ParentPanel when click button Allow add multiple and can scroll
            GiayToCpn giayToCpn = new GiayToCpn();
            giayToCpn.Location = new Point(0, 0);
            giayToCpn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ParentPanel.Controls.Add(giayToCpn);
      
        }
    }
}
