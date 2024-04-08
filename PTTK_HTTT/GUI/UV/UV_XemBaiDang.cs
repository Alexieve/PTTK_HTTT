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
    public partial class UV_XemBaiDang : Form
    {
        public UV_XemBaiDang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UngTuyenBtn_Click(object sender, EventArgs e)
        {
            // Show dialog of UngTuyenModal
            UV_UngTuyenModal modal = new UV_UngTuyenModal();
            modal.ShowDialog();
        }
    }
}
