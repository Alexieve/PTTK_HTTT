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
    public partial class Page_LYCTD : Form
    {
        public Page_LYCTD()
        {
            InitializeComponent();
            add_UControls(new Tab_LTTDT());
            pnlLtt.BackColor = Color.MediumSeaGreen;
        }

        private void add_UControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            foreach(var pnl in tabtbLout.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.Silver;
            }

            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnLtt":
                    add_UControls(new Tab_LTTDT());
                    pnlLtt.BackColor = Color.MediumSeaGreen;
                    break;
                case "btnLtgvht":
                    add_UControls(new Tab_LTGVHT());
                    pnlLtgvht.BackColor = Color.MediumSeaGreen;
                    break;
                case "btnXnpqc":
                    add_UControls(new Tab_XNPQC());
                    pnlXnpqc.BackColor = Color.MediumSeaGreen;
                    break;
                default:
                    break;
            }
        }
    }
}
