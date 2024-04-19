using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class CPN_LTTDT : UserControl
    {
        public event EventHandler btnSaveMain_click;

        public CPN_LTTDT()
        {
            InitializeComponent();
        }

        public string Capbac
        {
            get { return cbboxCapbac.Text;}
        }

        public string Vitri
        {
            get { return cbboxVitri.Text;}
        }

        public string Soluong
        {
            get { return nbSoluong.Value.ToString();}
        }

        public string Yeucau
        {
            get { return richboxYeucau.Text;}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSaveMain_click?.Invoke(this, EventArgs.Empty);
        }
    }
}
