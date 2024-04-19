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
    public partial class CPN_LTGVHT : UserControl
    {
        public event EventHandler btnSaveMain_click;
        public CPN_LTGVHT()
        {
            InitializeComponent();
        }

        public string Thoigian
        {
            get { return nbThoigian.Value.ToString();}
        }

        public string Hinhthuc
        {
            get { return cbboxHinhthuc.Text;}
        }

        public DateTime NgayTD
        {
            get { return dtpkNgayTD.Value;}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSaveMain_click?.Invoke(this, EventArgs.Empty);
        }
    }
}
