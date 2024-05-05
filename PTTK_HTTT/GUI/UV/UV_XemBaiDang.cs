using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

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
            //Test
            ViTriUngTuyenDTO viTriUngTuyenDTO = new ViTriUngTuyenDTO("HD00000001", "Quỳnh Company", "Intern", "Back-end Developer");
            UV_UngTuyenModal modal = new UV_UngTuyenModal(viTriUngTuyenDTO);
            modal.ShowDialog();
        }
    }
}
