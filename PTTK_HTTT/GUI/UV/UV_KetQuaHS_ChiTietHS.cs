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
        private string MAHOPDONG;
        public UV_KetQuaHS_ChiTietHS()
        {
            InitializeComponent();
        }
        private void ThemGiayToBtn_Click(object sender, EventArgs e)
        {
            // Add GiayToPanel to ParentPanel when click button Allow add multiple and can scroll
            GiayToCpn giayToCpn = new GiayToCpn(MAHOPDONG);
            giayToCpn.Location = new Point(0, 0);
            giayToCpn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ParentPanel.Controls.Add(giayToCpn);

        }

        private void UngTuyenBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
