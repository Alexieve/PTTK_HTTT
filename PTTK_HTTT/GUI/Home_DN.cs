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
    public partial class Home_DN : Form
    {
        public Home_DN()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.childFormPanel.Controls.Count > 0)
                this.childFormPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.childFormPanel.Controls.Add(f);
            this.childFormPanel.Tag = f;
            f.Show();
        }

        private void LapYCBtn_Click(object sender, EventArgs e)
        {
            loadform(new Page_LYCTD());
        }
    }
}
