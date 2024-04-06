﻿using System;
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
    public partial class DuyetHoSoModal : Form
    {

        public DuyetHoSoModal()
        {
            InitializeComponent();
            LoadThongTinUngTuyen();
            LoadGiayToUngVien();

        }

        private void LoadThongTinUngTuyen()
        {
            // Add ThongTinUngTuyenCpn to ParentPanel before GiayToPanel
            ThongTinUngTuyenCpn thongTinUngTuyenCpn = new ThongTinUngTuyenCpn();
            thongTinUngTuyenCpn.Location = new Point(0, 0);
            thongTinUngTuyenCpn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ParentPanel.Controls.Add(thongTinUngTuyenCpn);
            // Move GiayToPanel to the after all ThongTinUngTuyenCpn
            GiayToPanel.Location = new Point(0, thongTinUngTuyenCpn.Height);
            GiayToPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ParentPanel.Controls.Add(GiayToPanel);
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

        }

        private void XacNhanBtn_Click(object sender, EventArgs e)
        {

        }

        private void TuChoiBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
