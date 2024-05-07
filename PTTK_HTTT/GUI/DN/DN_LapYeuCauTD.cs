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
    public partial class DN_LapYeuCauTD : Form
    {
        private CPN_LTTDT cPN_LTTDT;
        private CPN_XNPQC cPN_XNPQC;
        
        public DN_LapYeuCauTD()
        {
            InitializeComponent();
            cPN_LTTDT = new CPN_LTTDT();
            cPN_XNPQC = new CPN_XNPQC();
            cPN_LTTDT.btnSaveMain_click += LTTDT_btnSaveClicked;
            cPN_XNPQC.reloadOuter += reload;
            chuyen_CPN_UC(cPN_LTTDT);
            pnlLtt.BackColor = Color.MediumSeaGreen;
        }

        private void reload(object sender, EventArgs e)
        {
            cPN_LTTDT = new CPN_LTTDT();
            cPN_XNPQC = new CPN_XNPQC();
            cPN_LTTDT.btnSaveMain_click += LTTDT_btnSaveClicked;
            cPN_XNPQC.reloadOuter += reload;
            chuyen_CPN_UC(cPN_LTTDT);
            pnlLtt.BackColor = Color.MediumSeaGreen;
        }

        private void chuyen_CPN_UC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlUserControl.Controls.Clear();
            pnlUserControl.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void chuyen_Tab(object sender, EventArgs e)
        {
            foreach (var pnl in tabtbLout.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.Silver;
            }

            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnLtt":
                    chuyen_CPN_UC(cPN_LTTDT);
                    pnlLtt.BackColor = Color.MediumSeaGreen;
                    break;
                case "btnXnpqc":
                    chuyen_CPN_UC(cPN_XNPQC);
                    pnlXnpqc.BackColor = Color.MediumSeaGreen;
                    break;
                default:
                    break;
            }
        }

        private void LTTDT_btnSaveClicked(object sender, EventArgs e)
        {
            cPN_XNPQC.Capbac = cPN_LTTDT.Capbac;
            cPN_XNPQC.Vitri = cPN_LTTDT.Vitri;
            cPN_XNPQC.Soluong = cPN_LTTDT.Soluong;
            cPN_XNPQC.Yeucau = cPN_LTTDT.Yeucau;
            cPN_XNPQC.KyNang(cPN_LTTDT.KyNang);
            cPN_XNPQC.HinhThuc(cPN_LTTDT.HinhThuc);
            cPN_XNPQC.Thoigian = cPN_LTTDT.ThoiGian;
            cPN_XNPQC.NgayTD = cPN_LTTDT.NgayTD;
            cPN_XNPQC.kynang = cPN_LTTDT.kynang;
            cPN_XNPQC.hinhthuc = cPN_LTTDT.hinhthuc;
        }
    }
}
