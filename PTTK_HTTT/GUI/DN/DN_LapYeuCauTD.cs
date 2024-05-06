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
    public partial class DN_LapYeuCauTD : Form
    {
        CPN_LTTDT cPN_LTTDT = new CPN_LTTDT();
        CPN_LTGVHT cPN_LTGVHT = new CPN_LTGVHT();
        CPN_XNPQC cPN_XNPQC = new CPN_XNPQC();

        public DN_LapYeuCauTD()
        {
            InitializeComponent();
            cPN_LTTDT.btnSaveMain_click += LTTDT_btnSaveClicked;
            cPN_LTGVHT.btnSaveMain_click += LTGVHT_btnSaveClicked;
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
                case "btnLtgvht":
                    chuyen_CPN_UC(cPN_LTGVHT);
                    pnlLtgvht.BackColor = Color.MediumSeaGreen;
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
        }
        private void LTGVHT_btnSaveClicked(object sender, EventArgs e)
        {
            cPN_XNPQC.Hinhthuc = cPN_LTGVHT.Hinhthuc;
            cPN_XNPQC.Thoigian = cPN_LTGVHT.Thoigian;
            cPN_XNPQC.NgayTD = cPN_LTGVHT.NgayTD;
        }
    }
}
